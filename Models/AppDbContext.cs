using Microsoft.EntityFrameworkCore;
using Odev.Models;


namespace Odev.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

      

        public DbSet<Car>Cars { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
