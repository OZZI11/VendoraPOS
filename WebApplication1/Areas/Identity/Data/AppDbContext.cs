using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Areas.Identity.Data;

namespace WebApplication1.Areas.Identity.Data;

public class AppDbContext : IdentityDbContext<AppUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

    public DbSet<AppUser> AppUser { get; set; }
    public DbSet<Models.OnhandProducts> OnhandProducts { get; set; }
    public DbSet<Models.SoldProduct> SoldProduct { get; set; }
    public DbSet<Models.Accounts> Accounts { get; set; }
    public DbSet<Models.Brands> Brands { get; set; }
    public DbSet<Models.CancelledProducts> CancelledProducts { get; set; }
    public DbSet<Models.Categories> Categories { get; set; }
    public DbSet<Models.VendorList> VendorList { get; set; }
}
