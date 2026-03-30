using CoffeeRecordsIdentity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace CoffeeRecordsIdentity.Data;

public class CoffeeRecordsIdentityContext : IdentityDbContext<ApplicationUser>
{
    public CoffeeRecordsIdentityContext(DbContextOptions<CoffeeRecordsIdentityContext> options)
        : base(options)
    {
    }

    public DbSet<CoffeeCup> Cups { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.ConfigureWarnings(warnings =>
            warnings.Ignore(Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.PendingModelChangesWarning));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var hasher = new PasswordHasher<ApplicationUser>();

        modelBuilder.Entity<IdentityRole>(entity =>
        {
            entity.HasData(new IdentityRole
            {
                Id = "00000000-0000-0000-0000-000000000001",
                Name = "Admin",
                NormalizedName = "ADMIN"
            });
        });
        modelBuilder.Entity<ApplicationUser>(entity =>
        {
            entity.HasData(new ApplicationUser
            {
                Id = "00000000-0000-0000-0001-000000000001",
                UserName = "admin@test.com",
                NormalizedUserName = "ADMIN@TEST.COM",
                Email = "admin@test.com",
                NormalizedEmail = "ADMIN@TEST.COM",
                PasswordHash = hasher.HashPassword(null, "Admin123"),
                EmailConfirmed = true
            });
        });
        modelBuilder.Entity<IdentityUserRole<string>>(entity =>
        {
            entity.HasData(new IdentityUserRole<string>
            {
                UserId = "00000000-0000-0000-0001-000000000001",
                RoleId = "00000000-0000-0000-0000-000000000001"
            });
        });
    }
}
