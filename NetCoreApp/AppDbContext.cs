using Microsoft.EntityFrameworkCore;
using Models;

namespace NetCoreApp
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Users> Usuarios { get; set; }
    }
}