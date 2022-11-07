using Microsoft.EntityFrameworkCore;
using TheMovingCompanyAPI.Entities;

namespace TheMovingCompanyAPI.Helpers
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration _configuration;

        public DataContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseInMemoryDatabase("TheMovingCompanyDatabase");
            options.EnableSensitiveDataLogging();
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}