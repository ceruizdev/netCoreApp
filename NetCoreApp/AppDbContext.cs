using Microsoft.EntityFrameworkCore;

namespace NetCoreApp
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }
    }
}