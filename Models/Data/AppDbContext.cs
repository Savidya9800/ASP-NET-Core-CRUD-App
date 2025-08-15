using AspnetCoreCRUDApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AspnetCoreCRUDApp.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Product> Products => Set<Product>();
    }
}
