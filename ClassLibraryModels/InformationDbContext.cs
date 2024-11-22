using ClassLibraryModels.Models;
using Microsoft.EntityFrameworkCore;

public class InformationDbContext : DbContext
{
    public InformationDbContext(DbContextOptions<InformationDbContext> options)
        : base(options)
    { }

    public DbSet<Admin> Admins { get; set; }
    public DbSet<Agency> Agencies { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Screen> Screens { get; set; }
    public DbSet<AllowedIpAddress> AllowedIpAddresses { get; set; }

    // Any additional configurations, such as relationships, if necessary
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // You may configure any relationships here if needed
        modelBuilder.Entity<Admin>()
            .HasOne(a => a.Agency)
            .WithMany()
            .HasForeignKey(a => a.AgencyId);

        modelBuilder.Entity<Admin>()
            .HasOne(a => a.Department)
            .WithMany()
            .HasForeignKey(a => a.DepartmentId);

        modelBuilder.Entity<Admin>()
            .HasOne(a => a.Location)
            .WithMany()
            .HasForeignKey(a => a.LocationId);

        modelBuilder.Entity<Admin>()
            .HasOne(a => a.Screen)
            .WithMany()
            .HasForeignKey(a => a.ScreenId);

        modelBuilder.Entity<AllowedIpAddress>()
            .HasOne(ip => ip.Location)
            .WithMany(l => l.AllowedIpAddresses)
            .HasForeignKey(ip => ip.LocationId);
    }
}
