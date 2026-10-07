using Microsoft.EntityFrameworkCore;
using MyFirstApi.Models;

namespace MyFirstApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<GreetingItem> GreetingItems { get; set; }
   // Product API 
    public DbSet<Product> Products { get; set; }  

    //  Cars API
    public DbSet<Car> Cars { get; set; }  
    // ADD MORE WHEN NEEDED 
}
