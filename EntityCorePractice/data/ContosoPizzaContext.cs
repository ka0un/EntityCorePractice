using EntityCorePractice.models;
using Microsoft.EntityFrameworkCore;

namespace EntityCorePractice.data;

// This class will represent the database context
// It will be used to query and save instances of the entities
// this is same as JPARepository in Java

public class ContosoPizzaContext :  DbContext
{
    
    public DbSet<Customer> Customers { get; set; } = null!;
    public DbSet<Order> Orders { get; set; } = null!;
    public DbSet<OrderDetail> OrderDetails { get; set; } = null!;
    public DbSet<Product> Products { get; set; } = null!;
    
    // This method is called when the context is configured
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=contosoPizza.db");
    }
    
}