using ClassLibraryModels;
using ClassLibraryModels.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DisplayAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AllowedIpAddressController : ControllerBase
    {
        private readonly InformationDbContext _context;

        public AllowedIpAddressController(InformationDbContext context)
        {
            _context = context;
        }

        // GET: api/AllowedIpAddress
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AllowedIpAddress>>> GetAllowedIpAddresses()
        {
            return await _context.AllowedIpAddresses
                .Include(ip => ip.Location)
                .ToListAsync();
        }

        // GET: api/AllowedIpAddress/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AllowedIpAddress>> GetAllowedIpAddress(int id)
        {
            var ipAddress = await _context.AllowedIpAddresses
                .Include(ip => ip.Location)
                .FirstOrDefaultAsync(ip => ip.Id == id);

            if (ipAddress == null)
            {
                return NotFound();
            }

            return ipAddress;
        }

        // GET: api/AllowedIpAddress/Location/5
        [HttpGet("Location/{locationId}")]
        public async Task<ActionResult<IEnumerable<AllowedIpAddress>>> GetAllowedIpAddressesByLocation(int locationId)
        {
            return await _context.AllowedIpAddresses
                .Where(ip => ip.LocationId == locationId)
                .ToListAsync();
        }

        // POST: api/AllowedIpAddress
        [HttpPost]
        public async Task<ActionResult<AllowedIpAddress>> CreateAllowedIpAddress(AllowedIpAddress ipAddress)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.AllowedIpAddresses.Add(ipAddress);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAllowedIpAddress), new { id = ipAddress.Id }, ipAddress);
        }

        // PUT: api/AllowedIpAddress/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAllowedIpAddress(int id, AllowedIpAddress ipAddress)
        {
            if (id != ipAddress.Id)
            {
                return BadRequest();
            }

            _context.Entry(ipAddress).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AllowedIpAddressExists(id))
                {
                    return NotFound();
                }
                throw;
            }

            return NoContent();
        }

        // DELETE: api/AllowedIpAddress/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAllowedIpAddress(int id)
        {
            var ipAddress = await _context.AllowedIpAddresses.FindAsync(id);
            if (ipAddress == null)
            {
                return NotFound();
            }

            _context.AllowedIpAddresses.Remove(ipAddress);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AllowedIpAddressExists(int id)
        {
            return _context.AllowedIpAddresses.Any(e => e.Id == id);
        }
    }
} 