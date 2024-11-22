using ClassLibraryModels;
using ClassLibraryModels.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DisplayAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        private readonly InformationDbContext _context;

        public MenuItemController(InformationDbContext context)
        {
            _context = context;
        }

        // GET: api/MenuItem
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MenuItem>>> GetMenuItems()
        {
            return await _context.MenuItems
                .Include(m => m.Screen)
                .OrderBy(m => m.Order)
                .ToListAsync();
        }

        // GET: api/MenuItem/Screen/5
        [HttpGet("Screen/{screenId}")]
        public async Task<ActionResult<IEnumerable<MenuItem>>> GetMenuItemsByScreen(int screenId)
        {
            return await _context.MenuItems
                .Where(m => m.ScreenId == screenId)
                .OrderBy(m => m.Order)
                .ToListAsync();
        }

        // GET: api/MenuItem/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MenuItem>> GetMenuItem(int id)
        {
            var menuItem = await _context.MenuItems
                .Include(m => m.Screen)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (menuItem == null)
            {
                return NotFound();
            }

            return menuItem;
        }

        // POST: api/MenuItem
        [HttpPost]
        public async Task<ActionResult<MenuItem>> CreateMenuItem(MenuItem menuItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Set creation date
            menuItem.DateCreated = DateTime.UtcNow;
            menuItem.LastUpdated = DateTime.UtcNow;

            _context.MenuItems.Add(menuItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetMenuItem), new { id = menuItem.Id }, menuItem);
        }

        // PUT: api/MenuItem/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMenuItem(int id, MenuItem menuItem)
        {
            if (id != menuItem.Id)
            {
                return BadRequest();
            }

            menuItem.LastUpdated = DateTime.UtcNow;
            _context.Entry(menuItem).State = EntityState.Modified;
            // Don't modify DateCreated
            _context.Entry(menuItem).Property(x => x.DateCreated).IsModified = false;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MenuItemExists(id))
                {
                    return NotFound();
                }
                throw;
            }

            return NoContent();
        }

        // PUT: api/MenuItem/UpdateOrder
        [HttpPut("UpdateOrder")]
        public async Task<IActionResult> UpdateMenuItemsOrder(List<MenuItemOrder> menuItemOrders)
        {
            foreach (var order in menuItemOrders)
            {
                var menuItem = await _context.MenuItems.FindAsync(order.Id);
                if (menuItem != null)
                {
                    menuItem.Order = order.NewOrder;
                    menuItem.LastUpdated = DateTime.UtcNow;
                }
            }

            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/MenuItem/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMenuItem(int id)
        {
            var menuItem = await _context.MenuItems.FindAsync(id);
            if (menuItem == null)
            {
                return NotFound();
            }

            _context.MenuItems.Remove(menuItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MenuItemExists(int id)
        {
            return _context.MenuItems.Any(e => e.Id == id);
        }
    }

    public class MenuItemOrder
    {
        public int Id { get; set; }
        public int NewOrder { get; set; }
    }
} 