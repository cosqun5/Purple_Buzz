using Microsoft.EntityFrameworkCore;
using Purple_Buzz.Models;

namespace Purple_Buzz.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {
            
        }
        public DbSet<Slider> Sliders { get; set; }  
        public DbSet<Service> Services { get; set; }  
        public DbSet<Category> Categories { get; set; }  
        public DbSet<ServiceImage> ServiceImages { get; set; }
        public DbSet<WorkServiceImage> WorkServiceImages { get; set; }
        public DbSet<WorkCategory> WorkCategories { get; set; }
        public DbSet<WorkService> WorkServices { get; set; }
    }
}
