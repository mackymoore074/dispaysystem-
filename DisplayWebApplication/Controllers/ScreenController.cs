using ClassLibraryModels;
using ClassLibraryModels.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DisplayAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScreenController : ControllerBase
    {
        private readonly InformationDbContext _context;

        public ScreenController(InformationDbContext context)
        {
            _context = context;
        }

        // GET: api/Screen
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Screen>>> GetScreens()
        {
            return await _context.Screens
                .Include(s => s.Location)
                .Include(s => s.Department)
                .ToListAsync();
        }

        // GET: api/Screen/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Screen>> GetScreen(int id)
        {
            var screen = await _context.Screens
                .Include(s => s.Location)
                .Include(s => s.Department)
                .FirstOrDefaultAsync(s => s.Id == id);

            if (screen == null)
            {
                return NotFound();
            }

            return screen;
        }

        // POST: api/Screen
        [HttpPost]
        public async Task<ActionResult<Screen>> CreateScreen(Screen screen)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            screen.DateCreated = DateTime.UtcNow;
            screen.LastUpdated = DateTime.UtcNow;
            _context.Screens.Add(screen);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetScreen), new { id = screen.Id }, screen);
        }

        // PUT: api/Screen/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateScreen(int id, Screen screen)
        {
            if (id != screen.Id)
            {
                return BadRequest();
            }

            screen.LastUpdated = DateTime.UtcNow;
            _context.Entry(screen).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ScreenExists(id))
                {
                    return NotFound();
                }
                throw;
            }

            return NoContent();
        }

        // DELETE: api/Screen/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteScreen(int id)
        {
            var screen = await _context.Screens.FindAsync(id);
            if (screen == null)
            {
                return NotFound();
            }

            _context.Screens.Remove(screen);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ScreenExists(int id)
        {
            return _context.Screens.Any(e => e.Id == id);
        }
    }
} 