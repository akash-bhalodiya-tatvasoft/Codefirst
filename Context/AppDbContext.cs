using CodeFirstApi.Models;
using Inventory.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstApi.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<UserProfile> UserProfiles { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<UserProfile>().HasData(new UserProfile
        {
            Id = 1,
            FirstName = "John",
            LastName = "Doe",
            Email = "john.doe@example.com",
            IsActive = true
        });

        modelBuilder.Entity<Category>().HasData(new Category
        {
            Id = 1,
            Name = "Electronics",
            Description = "Electronic gadgets and devices",
            IsActive = true
        });

        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 1,
            Name = "Smartphone",
            Description = "Latest model smartphone",
            Price = 699.99m,
            DiscountedPrice = 649.99m,
            Quantity = 50,
            CategoryId = 1,
            ProductImage = null,
            ProductImageUrl = null
        });

        modelBuilder.Entity<Order>().HasData(new Order
        {
            Id = 1,
            UserId = 1,
            Status = 1,
            TotalAmount = 649.99m
        });

        modelBuilder.Entity<OrderItem>().HasData(new OrderItem
        {
            Id = 1,
            OrderId = 1,
            ProductId = 1,
            Quantity = 1,
            UnitPrice = 649.99m,
            TotalPrice = 649.99m
        });
    }
}
