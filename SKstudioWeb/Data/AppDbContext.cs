using Microsoft.EntityFrameworkCore;
using SKstudioWeb.Models;

namespace SKstudioWeb.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Appointments> Appointments { get; set; }

    }
}
