using Microsoft.EntityFrameworkCore;
using WepApp.Models;

namespace WepApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }
        public DbSet<Banner> Banners{ get; set; }
        public DbSet<Service> Services{ get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
    }
}