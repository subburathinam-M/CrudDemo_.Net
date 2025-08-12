using Microsoft.EntityFrameworkCore;
using CrudDemo.Models; // Change to your actual namespace

namespace CrudDemo.Data // Change to your actual namespace
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
