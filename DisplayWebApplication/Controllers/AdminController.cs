using ClassLibraryModels;
using ClassLibraryModels.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisplayAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly InformationDbContext _context;

        public AdminController(InformationDbContext context)
        {
            _context = context;
        }

        // GET: api/Admin
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Admin>>> GetAdmins()
        {
            var admins = await _context.Admins
                .Include(a => a.Agency)
                .Include(a => a.Department)
                .Include(a => a.Location)
                .Include(a => a.Screen)
                .ToListAsync();

            if (admins == null || !admins.Any())
            {
                return NotFound();
            }

            return Ok(admins);
        }

        // GET: api/Admin/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Admin>> GetAdmin(int id)
        {
            var admin = await _context.Admins
                .Include(a => a.Agency)
                .Include(a => a.Department)
                .Include(a => a.Location)
                .Include(a => a.Screen)
                .FirstOrDefaultAsync(a => a.Id == id);

            if (admin == null)
            {
                return NotFound();
            }

            return Ok(admin);
        }

        // POST: api/Admin
        [HttpPost]
        public async Task<ActionResult<Admin>> PostAdmin(Admin admin)
        {
            // Ensure the model is valid before adding it to the context
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Set the DateCreated and LastLogin properties to the current time
            admin.DateCreated = DateTime.UtcNow;
            admin.LastLogin = DateTime.UtcNow;

            _context.Admins.Add(admin);
            await _context.SaveChangesAsync();

            // Return the created Admin with a link to the newly created resource
            return CreatedAtAction("GetAdmin", new { id = admin.Id }, admin);
        }
    }
}
