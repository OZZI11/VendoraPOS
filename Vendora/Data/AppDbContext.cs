using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendora.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
                
        }

        public AppDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-AEJ6B24K\\SQLEXPRESS;User ID=VENDORA_SQLEXPRESS;Password=********;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
            // Mark OnhandProducts as keyless
            builder.Entity<DomainLayer.Models.OnhandProducts>().HasNoKey();

        }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<DomainLayer.Models.OnhandProducts> OnhandProducts { get; set; }
    }
}
