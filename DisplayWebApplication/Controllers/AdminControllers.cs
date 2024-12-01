using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using ClassLibraryModels.DtoModels.Admin;
using ClassLibraryModels.Models;

namespace TheWebApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly InformationDbContext _context;
        private readonly ILogger<AdminController> _logger;
        private readonly IPasswordHasher<Admin> _passwordHasher;

        public AdminController(InformationDbContext context, ILogger<AdminController> logger, IPasswordHasher<Admin> passwordHasher)
        {
            _context = context;
            _logger = logger;
            _passwordHasher = passwordHasher; // Inject the IPasswordHasher service
        }

        // GET: api/admin
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AdminDto>>> GetAdmins()
        {
            try
            {
                var admins = await _context.Admins
                    .Include(a => a.Agency)
                    .Include(a => a.Department)
                    .Include(a => a.Location)
                    .Include(a => a.Screen)
                    .Select(a => new AdminDto
                    {
                        Id = a.Id,
                        FirstName = a.FirstName,
                        LastName = a.LastName,
                        Email = a.Email,
                        Role = a.Role.ToString(), // Convert Enum to string
                        AgencyName = a.Agency.Name, // Fetch related Agency's Name
                        DepartmentName = a.Department.Name, // Fetch related Department's Name
                        LocationName = a.Location.Name, // Fetch related Location's Name
                        ScreenName = a.Screen.Name, // Fetch related Screen's Name
                        DateCreated = a.DateCreated,
                        LastLogin = a.LastLogin
                    })
                    .ToListAsync();

                return Ok(admins);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error in GetAdmins: {ex.Message}", ex);
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // GET: api/admin/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<AdminDto>> GetAdmin(int id)
        {
            try
            {
                var admin = await _context.Admins
                    .Include(a => a.Agency)
                    .Include(a => a.Department)
                    .Include(a => a.Location)
                    .Include(a => a.Screen)
                    .Where(a => a.Id == id)
                    .Select(a => new AdminDto
                    {
                        Id = a.Id,
                        FirstName = a.FirstName,
                        LastName = a.LastName,
                        Email = a.Email,
                        Role = a.Role.ToString(), // Convert Enum to string
                        DateCreated = a.DateCreated,
                        LastLogin = a.LastLogin
                    })
                    .FirstOrDefaultAsync();

                if (admin == null)
                {
                    return NotFound($"Admin with ID {id} not found.");
                }

                return Ok(admin);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error in GetAdmin: {ex.Message}", ex);
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // POST: api/admin
        [HttpPost]
        public async Task<ActionResult<AdminDto>> CreateAdmin([FromBody] CreateAdminDto createAdminDto)
        {
            // Validate the model
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                // Create a new Admin from the DTO
                var admin = new Admin
                {
                    FirstName = createAdminDto.FirstName,
                    LastName = createAdminDto.LastName,
                    Email = createAdminDto.Email,
                    Role = createAdminDto.Role,
                    DateCreated = DateTime.UtcNow, // Set DateCreated to current UTC time
                    LastLogin = DateTime.UtcNow  // Set LastLogin to current UTC time
                };

                // Secure password hashing
                var passwordHash = _passwordHasher.HashPassword(admin, createAdminDto.PasswordHash); // Hash the password
                admin.PasswordHash = passwordHash;

                // Add the Admin to the database
                _context.Admins.Add(admin);
                await _context.SaveChangesAsync();

                // Map the Admin entity to AdminDto
                var agency = await _context.Agencies.FindAsync(admin.AgencyId);
                var department = await _context.Departments.FindAsync(admin.DepartmentId);
                var location = await _context.Locations.FindAsync(admin.LocationId);
                var screen = await _context.Screens.FindAsync(admin.ScreenId);

                // Map related entities to AdminDto
                var adminDto = new AdminDto
                {
                    Id = admin.Id,
                    FirstName = admin.FirstName,
                    LastName = admin.LastName,
                    Email = admin.Email,
                    Role = admin.Role.ToString(), // Convert Enum to String
                    DateCreated = admin.DateCreated,
                    LastLogin = admin.LastLogin
                };

                // Log the creation of the Admin
                _logger.LogInformation($"Created new admin with ID: {admin.Id}");

                // Return the CreatedAtAction response with the admin's details
                return CreatedAtAction(nameof(GetAdmin), new { id = admin.Id }, adminDto);
            }
            catch (Exception ex)
            {
                // Log the error and return a generic error message
                _logger.LogError($"Error in CreateAdmin: {ex.Message}", ex);
                return StatusCode(500, "Internal server error. Please try again later.");
            }
        }
        // PUT: api/admin/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult<AdminDto>> UpdateAdmin(int id, [FromBody] UpdateAdminDto updateAdminDto)
        {
            // Validate the model
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                // Find the Admin to be updated by ID
                var admin = await _context.Admins.FindAsync(id);
                if (admin == null)
                {
                    return NotFound($"Admin with ID {id} not found.");
                }

                // Update fields only if they are provided in the DTO
                admin.FirstName = updateAdminDto.FirstName;
                admin.LastName = updateAdminDto.LastName;
                admin.Email = updateAdminDto.Email;
                admin.Role = updateAdminDto.Role;

                // If the password is provided, hash and update it
                if (!string.IsNullOrEmpty(updateAdminDto.PasswordHash))
                {
                    var passwordHash = _passwordHasher.HashPassword(admin, updateAdminDto.PasswordHash); // Hash the password
                    admin.PasswordHash = passwordHash;
                }

                // Update the Admin in the database
                _context.Admins.Update(admin);
                await _context.SaveChangesAsync();

                // Fetch related entities to return in the DTO
                var agency = await _context.Agencies.FindAsync(admin.AgencyId);
                var department = await _context.Departments.FindAsync(admin.DepartmentId);
                var location = await _context.Locations.FindAsync(admin.LocationId);
                var screen = await _context.Screens.FindAsync(admin.ScreenId);

                // Map the updated Admin entity to AdminDto
                var adminDto = new AdminDto
                {
                    Id = admin.Id,
                    FirstName = admin.FirstName,
                    LastName = admin.LastName,
                    Email = admin.Email,
                    Role = admin.Role.ToString(), // Convert Enum to String
                    AgencyName = agency?.Name, // Fetch related Agency's Name
                    DepartmentName = department?.Name, // Fetch related Department's Name
                    LocationName = location?.Name, // Fetch related Location's Name
                    ScreenName = screen?.Name, // Fetch related Screen's Name
                    DateCreated = admin.DateCreated,
                    LastLogin = admin.LastLogin
                };

                // Log the update of the Admin
                _logger.LogInformation($"Updated admin with ID: {admin.Id}");

                // Return the updated Admin DTO
                return Ok(adminDto);
            }
            catch (Exception ex)
            {
                // Log the error and return a generic error message
                _logger.LogError($"Error in UpdateAdmin: {ex.Message}", ex);
                return StatusCode(500, "Internal server error. Please try again later.");
            }
        }

        // DELETE: api/admin/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdmin(int id)
        {
            try
            {
                // Find the Admin by ID
                var admin = await _context.Admins.FindAsync(id);
                if (admin == null)
                {
                    // If the Admin is not found, return a 404 Not Found response
                    return NotFound($"Admin with ID {id} not found.");
                }

                // Remove the Admin from the database
                _context.Admins.Remove(admin);
                await _context.SaveChangesAsync();

                // Log the deletion of the Admin
                _logger.LogInformation($"Deleted admin with ID: {id}");

                // Return a 204 No Content response to indicate successful deletion
                return NoContent();
            }
            catch (Exception ex)
            {
                // Log the error and return a generic error message
                _logger.LogError($"Error in DeleteAdmin: {ex.Message}", ex);
                return StatusCode(500, "Internal server error. Please try again later.");
            }
        }



    }
}
