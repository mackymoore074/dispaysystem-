using ClassLibraryModels;
using ClassLibraryModels.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DisplayAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgencyController : ControllerBase
    {
        private readonly InformationDbContext _context;

        public AgencyController(InformationDbContext context)
        {
            _context = context;
        }

        // GET: api/Agency
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Agency>>> GetAgencies()
        {
            return await _context.Agencies
                .Include(a => a.Departments)
                .ToListAsync();
        }

        // GET: api/Agency/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Agency>> GetAgency(int id)
        {
            var agency = await _context.Agencies
                .Include(a => a.Departments)
                .FirstOrDefaultAsync(a => a.Id == id);

            if (agency == null)
            {
                return NotFound();
            }

            return agency;
        }

        // POST: api/Agency
        [HttpPost]
        public async Task<ActionResult<Agency>> CreateAgency(Agency agency)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Agencies.Add(agency);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAgency), new { id = agency.Id }, agency);
        }

        // PUT: api/Agency/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAgency(int id, Agency agency)
        {
            if (id != agency.Id)
            {
                return BadRequest();
            }

            _context.Entry(agency).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AgencyExists(id))
                {
                    return NotFound();
                }
                throw;
            }

            return NoContent();
        }

        // DELETE: api/Agency/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAgency(int id)
        {
            var agency = await _context.Agencies.FindAsync(id);
            if (agency == null)
            {
                return NotFound();
            }

            _context.Agencies.Remove(agency);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AgencyExists(int id)
        {
            return _context.Agencies.Any(e => e.Id == id);
        }
    }
} 