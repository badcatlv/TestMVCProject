using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EComMVCProject.Data
{
    public class EComDbContext : IdentityDbContext
    {
        public EComDbContext(DbContextOptions<EComDbContext> options) : base(options)
        {
        }

        
    }
}
