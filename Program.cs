using Microsoft.EntityFrameworkCore;
using ClassLibraryModels;  // Adjust this to match your actual namespace

var builder = WebApplication.CreateBuilder(args);

// Add this before other service configurations
builder.Services.AddDbContext<InformationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// ... rest of your Program.cs configuration ... 