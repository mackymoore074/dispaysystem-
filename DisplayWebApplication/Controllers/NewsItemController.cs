using ClassLibraryModels;
using ClassLibraryModels.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DisplayAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsItemController : ControllerBase
    {
        private readonly InformationDbContext _context;

        public NewsItemController(InformationDbContext context)
        {
            _context = context;
        }

        // GET: api/NewsItem
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NewsItem>>> GetNewsItems()
        {
            return await _context.NewsItems
                .Include(n => n.Screen)
                .OrderByDescending(n => n.DateCreated)
                .ToListAsync();
        }

        // GET: api/NewsItem/Screen/5
        [HttpGet("Screen/{screenId}")]
        public async Task<ActionResult<IEnumerable<NewsItem>>> GetNewsItemsByScreen(int screenId)
        {
            return await _context.NewsItems
                .Where(n => n.ScreenId == screenId)
                .OrderByDescending(n => n.DateCreated)
                .ToListAsync();
        }

        // GET: api/NewsItem/Active
        [HttpGet("Active")]
        public async Task<ActionResult<IEnumerable<NewsItem>>> GetActiveNewsItems()
        {
            var now = DateTime.UtcNow;
            return await _context.NewsItems
                .Where(n => n.IsActive && 
                           (!n.StartDate.HasValue || n.StartDate <= now) &&
                           (!n.EndDate.HasValue || n.EndDate >= now))
                .OrderByDescending(n => n.DateCreated)
                .ToListAsync();
        }

        // GET: api/NewsItem/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NewsItem>> GetNewsItem(int id)
        {
            var newsItem = await _context.NewsItems
                .Include(n => n.Screen)
                .FirstOrDefaultAsync(n => n.Id == id);

            if (newsItem == null)
            {
                return NotFound();
            }

            return newsItem;
        }

        // POST: api/NewsItem
        [HttpPost]
        public async Task<ActionResult<NewsItem>> CreateNewsItem(NewsItem newsItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            newsItem.DateCreated = DateTime.UtcNow;
            newsItem.LastUpdated = DateTime.UtcNow;

            _context.NewsItems.Add(newsItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetNewsItem), new { id = newsItem.Id }, newsItem);
        }

        // PUT: api/NewsItem/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateNewsItem(int id, NewsItem newsItem)
        {
            if (id != newsItem.Id)
            {
                return BadRequest();
            }

            newsItem.LastUpdated = DateTime.UtcNow;
            _context.Entry(newsItem).State = EntityState.Modified;
            // Don't modify DateCreated
            _context.Entry(newsItem).Property(x => x.DateCreated).IsModified = false;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NewsItemExists(id))
                {
                    return NotFound();
                }
                throw;
            }

            return NoContent();
        }

        // PATCH: api/NewsItem/5/ToggleActive
        [HttpPatch("{id}/ToggleActive")]
        public async Task<IActionResult> ToggleNewsItemActive(int id)
        {
            var newsItem = await _context.NewsItems.FindAsync(id);
            if (newsItem == null)
            {
                return NotFound();
            }

            newsItem.IsActive = !newsItem.IsActive;
            newsItem.LastUpdated = DateTime.UtcNow;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/NewsItem/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNewsItem(int id)
        {
            var newsItem = await _context.NewsItems.FindAsync(id);
            if (newsItem == null)
            {
                return NotFound();
            }

            _context.NewsItems.Remove(newsItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool NewsItemExists(int id)
        {
            return _context.NewsItems.Any(e => e.Id == id);
        }
    }
} 