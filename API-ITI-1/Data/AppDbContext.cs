using Microsoft.EntityFrameworkCore;

namespace API_ITI_1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
      
   
    }
}
