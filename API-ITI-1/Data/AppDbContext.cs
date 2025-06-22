using API_ITI_1.Models;
using Microsoft.EntityFrameworkCore;

namespace API_ITI_1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Courses> Courses { get; set; }
    }
}
