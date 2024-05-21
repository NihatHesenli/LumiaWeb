using LUMIA_WEBSITE.Models;
using Microsoft.EntityFrameworkCore;

namespace LUMIA_WEBSITE.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options)
        {
        }

        public DbSet<Team> Teams { get; set; }
    }
}
