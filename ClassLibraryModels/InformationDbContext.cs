using ClassLibraryModels.Models;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Crypto.Generators;
using System;
using static ClassLibraryModels.Models.NewsItem;

namespace ClassLibraryModels
{
    public class InformationDbContext : DbContext
    {
        public InformationDbContext(DbContextOptions<InformationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Agency> Agencies { get; set; }
        public DbSet<Screen> Screens { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ErrorLog> ErrorLogs { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<MenuItems> MenuItems { get; set; }
        public DbSet<NewsItem> NewsItems { get; set; }

        // Adding DbSet for the join table (NewsItemAgency)
        public DbSet<NewsItemAgency> NewsItemAgencies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Admin - Agency relationship (optional)
            modelBuilder.Entity<Admin>()
                .HasOne(a => a.Agency)
                .WithMany(b => b.Admins)
                .HasForeignKey(a => a.AgencyId)
                .OnDelete(DeleteBehavior.SetNull);

            // Admin - Department relationship (optional)
            modelBuilder.Entity<Admin>()
                .HasOne(a => a.Department)
                .WithMany(b => b.Admins)
                .HasForeignKey(a => a.DepartmentId)
                .OnDelete(DeleteBehavior.SetNull);

            // Admin - Location relationship (optional)
            modelBuilder.Entity<Admin>()
                .HasOne(a => a.Location)
                .WithMany(b => b.Admins)
                .HasForeignKey(a => a.LocationId)
                .OnDelete(DeleteBehavior.SetNull);

            // Admin - Screen relationship (optional)
            modelBuilder.Entity<Admin>()
                .HasOne(a => a.Screen)
                .WithMany(b => b.Admins)
                .HasForeignKey(a => a.ScreenId)
                .OnDelete(DeleteBehavior.SetNull);

            // Agency - Department relationship
            modelBuilder.Entity<Agency>()
                .HasMany(a => a.Departments)
                .WithOne(b => b.Agency)
                .HasForeignKey(b => b.AgencyId)
                .OnDelete(DeleteBehavior.Restrict);

            // Department - Screen relationship
            modelBuilder.Entity<Department>()
                .HasMany(d => d.Screens)
                .WithOne(s => s.Department)
                .HasForeignKey(s => s.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Department - Location relationship
            modelBuilder.Entity<Department>()
                .HasOne(d => d.Locations)
                .WithMany(l => l.Departments)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.Restrict);

            // Location - Screen relationship
            modelBuilder.Entity<Location>()
                .HasMany(l => l.Screens)
                .WithOne(s => s.Location)
                .HasForeignKey(s => s.LocationId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configuring the NewsItemAgency as keyless (for a join table)
            modelBuilder.Entity<NewsItemAgency>()
                .HasNoKey();  // This marks it as a keyless entity

            // Define the many-to-many relationship between NewsItem and Agency using the join table
            modelBuilder.Entity<NewsItemAgency>()
                .HasOne(na => na.NewsItem)
                .WithMany(n => n.NewsItemAgencies)  // Navigation property on NewsItem
                .HasForeignKey(na => na.NewsItemId);

           // modelBuilder.Entity<NewsItemAgency>()
           //     .HasOne(na => na.Agency)
            //    .WithMany(a => a.NewsItemAgencies)  // Navigation property on Agency
              //  .HasForeignKey(na => na.AgencyId);

            // Adding constraints and indexes
            modelBuilder.Entity<Admin>()
                .Property(a => a.Email)
                .IsRequired()
                .HasMaxLength(150);

            modelBuilder.Entity<Admin>()
                .HasIndex(a => a.Email)
                .IsUnique();

            modelBuilder.Entity<Location>()
                .Property(l => l.Name)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Location>()
                .HasIndex(l => l.Name);

            // NewsItem configurations
            modelBuilder.Entity<NewsItem>()
                .Property(n => n.Title)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<NewsItem>()
                .Property(n => n.NewsItemBody)
                .IsRequired()
                .HasMaxLength(1000);

            modelBuilder.Entity<NewsItem>()
                .Property(n => n.MoreInformationUrl)
                .HasMaxLength(200);

            modelBuilder.Entity<NewsItem>()
                .Property(n => n.TimeOutDate)
                .IsRequired();

            modelBuilder.Entity<NewsItem>()
                .Property(n => n.Importance)
                .IsRequired();

            // Seed data for Agencies, Departments, Locations, Screens, Admins, and NewsItems
            modelBuilder.Entity<Agency>().HasData(
                new Agency { Id = 1, Name = "Agency1", Description = "Description for Agency1", DateCreated = DateTime.UtcNow },
                new Agency { Id = 2, Name = "Agency2", Description = "Description for Agency2", DateCreated = DateTime.UtcNow }
            );

            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "Finance", Description = "Finance Department", DateCreated = DateTime.UtcNow, AgencyId = 1, LocationId = 1 },
                new Department { Id = 2, Name = "HR", Description = "Human Resources Department", DateCreated = DateTime.UtcNow, AgencyId = 2, LocationId = 2 }
            );

            modelBuilder.Entity<Location>().HasData(
                new Location { Id = 1, Name = "Foothill (Finance)", Address = "123 Finance St", DateCreated = DateTime.UtcNow },
                new Location { Id = 2, Name = "Main Office (HR)", Address = "456 HR Ave", DateCreated = DateTime.UtcNow }
            );

            modelBuilder.Entity<Screen>().HasData(
                new Screen { Id = 1, Name = "DM001", LocationId = 1, DepartmentId = 1, DateCreated = DateTime.UtcNow, ScreenType = "LED", LastUpdated = DateTime.UtcNow, LastCheckedIn = DateTime.UtcNow, IsOnline = true, StatusMessage = "Active" },
                new Screen { Id = 2, Name = "LH002", LocationId = 2, DepartmentId = 2, DateCreated = DateTime.UtcNow, ScreenType = "LCD", LastUpdated = DateTime.UtcNow, LastCheckedIn = DateTime.UtcNow, IsOnline = true, StatusMessage = "Active" }
            );

            modelBuilder.Entity<Admin>().HasData(
                new Admin
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                   // PasswordHash = BCrypt.Net.BCrypt.HashPassword("ade123"),//
                    Email = "johndoe@agency.com",
                    DateCreated = DateTime.UtcNow,
                    LastLogin = DateTime.UtcNow,
                    Role = Role.Admin
                },
                new Admin
                {
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                 //   PasswordHash = BCrypt.Net.BCrypt.HashPassword("ade123"),//
                    Email = "janesmith@agency.com",
                    DateCreated = DateTime.UtcNow,
                    LastLogin = DateTime.UtcNow,
                    Role = Role.SuperAdmin
                }
            );

            modelBuilder.Entity<NewsItem>().HasData(
                new NewsItem
                {
                    Id = 1,
                    Title = "Important Update",
                    NewsItemBody = "System maintenance scheduled. Please be aware of the downtime during this period.",
                    DateCreated = DateTime.UtcNow,
                    Importance = ImportanceLevel.VeryImportant,
                    TimeOutDate = DateTime.UtcNow.AddMonths(1),
                    LastUpdated = DateTime.UtcNow,
                    MoreInformationUrl = "http://example.com/maintenance"
                },
                new NewsItem
                {
                    Id = 2,
                    Title = "New Policy",
                    NewsItemBody = "A new company policy is now in effect. Please familiarize yourself with the changes.",
                    DateCreated = DateTime.UtcNow,
                    Importance = ImportanceLevel.SomewhatImportant,
                    TimeOutDate = DateTime.UtcNow.AddMonths(1),
                    LastUpdated = DateTime.UtcNow,
                    MoreInformationUrl = "http://example.com/new-policy"
                },
                new NewsItem
                {
                    Id = 3,
                    Title = "Upcoming Event",
                    NewsItemBody = "Don't miss our upcoming team-building event scheduled for next month.",
                    DateCreated = DateTime.UtcNow,
                    Importance = ImportanceLevel.VeryImportant,
                    TimeOutDate = DateTime.UtcNow.AddMonths(1),
                    LastUpdated = DateTime.UtcNow,
                    MoreInformationUrl = "http://example.com/event"
                }
            );

            modelBuilder.Entity<NewsItemAgency>().HasData(
                new NewsItemAgency { NewsItemId = 1, AgencyId = 1 },
                new NewsItemAgency { NewsItemId = 2, AgencyId = 2 },
                new NewsItemAgency { NewsItemId = 3, AgencyId = 1 }
            );
        }
    }
}
