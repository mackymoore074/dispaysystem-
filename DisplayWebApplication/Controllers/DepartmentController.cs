using ClassLibraryModels;
using ClassLibraryModels.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DisplayAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly InformationDbContext _context;

        public DepartmentController(InformationDbContext context)
        {
            _context = context;
        }

        // GET: api/Department
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            // Original DB query (commented)
            // var departments = await _context.Departments
            //     .Include(d => d.Agency)
            //     .Include(d => d.Location)
            //     .Include(d => d.Screens)
            //     .ToListAsync();

            // Mock data for testing
            var departments = new List<Department>
            {
                new Department 
                { 
                    Id = 1, 
                    Name = "IT Department",
                    Description = "Information Technology",
                    Location = new Location { Id = 1, Name = "Main Office" },
                    Agency = new Agency { Id = 1, Name = "Main Agency" },
                    Screens = new List<Screen> 
                    { 
                        new Screen { Id = 1, Name = "Screen 1" } 
                    }
                },
                new Department 
                { 
                    Id = 2, 
                    Name = "HR Department",
                    Description = "Human Resources",
                    Location = new Location { Id = 1, Name = "Main Office" },
                    Agency = new Agency { Id = 1, Name = "Main Agency" },
                    Screens = new List<Screen> 
                    { 
                        new Screen { Id = 2, Name = "Screen 2" } 
                    }
                }
            };

            return Ok(departments);
        }

        // GET: api/Department/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            // Original DB query (commented)
            // var department = await _context.Departments
            //     .Include(d => d.Agency)
            //     .Include(d => d.Location)
            //     .Include(d => d.Screens)
            //     .FirstOrDefaultAsync(d => d.Id == id);
            
            // if (department == null)
            //     return NotFound();

            var department = new Department
            {
                Id = id,
                Name = "Test Department",
                Description = "Test Description",
                Location = new Location { Id = 1, Name = "Main Office" },
                Agency = new Agency { Id = 1, Name = "Main Agency" },
                Screens = new List<Screen> 
                { 
                    new Screen { Id = 1, Name = "Screen 1" } 
                }
            };

            return Ok(department);
        }

        // POST: api/Department
        [HttpPost]
        public IActionResult Create([FromBody] DepartmentDTO departmentDto)
        {
            // Convert DTO to Department for demonstration
            var department = new Department
            {
                Name = departmentDto.Name,
                Description = departmentDto.Description,
                // Mock the related entities for now
                Agency = new Agency { Id = departmentDto.AgencyId ?? 1, Name = "Mock Agency" },
                Location = new Location { Id = departmentDto.LocationId ?? 1, Name = "Mock Location" }
            };

            // Return the created department
            return Ok(department);

             // Original DB query (commented)
            // _context.Departments.Add(department);
            // await _context.SaveChangesAsync();
            // return CreatedAtAction(nameof(GetById), new { id = department.Id }, department);

            // Mock response
            // department.Id = 3; // Simulate auto-generated ID
            // return CreatedAtAction(nameof(GetById), new { id = department.Id }, department);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Department department)
        {
            // Original DB query (commented)
            // var existingDepartment = await _context.Departments.FindAsync(id);
            // if (existingDepartment == null)
            //     return NotFound();
            
            // existingDepartment.Name = department.Name;
            // existingDepartment.Description = department.Description;
            // await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            // Original DB query (commented)
            // var department = await _context.Departments.FindAsync(id);
            // if (department == null)
            //     return NotFound();
            
            // _context.Departments.Remove(department);
            // await _context.SaveChangesAsync();

            return NoContent();
        }
    }
} 