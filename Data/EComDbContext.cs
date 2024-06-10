using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EComMVCProject.Models;

namespace EComMVCProject.Data
{
    public class EComDbContext : IdentityDbContext
    {
        public DbSet<Product> Products { get; set; }
        
        public EComDbContext(DbContextOptions<EComDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


        }
        public DbSet<EComMVCProject.Models.Test> Test { get; set; } = default!;


    }
}
