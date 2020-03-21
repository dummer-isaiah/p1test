using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Databases
{

  public class PizzaBoxDbContext : DbContext
  {

   

    private static readonly PizzaBoxDbContext _dbc = new PizzaBoxDbContext();

     public PizzaBoxDbContext() {}

    public static PizzaBoxDbContext Instance
    {
      get{
        return _dbc;
      }
        
    }

    public DbSet<Pizza> Pizza {get; set; }
    public DbSet<Size> Size {get; set; }

    public DbSet<Crust> Crust {get; set; }

    public DbSet<Topping> Topping {get; set; }

    public DbSet<User> User {get; set;}

    public DbSet<Store> Store {get; set;}

    public DbSet<Order> Order {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
      builder.UseSqlServer("Server=localhost;database=pizzaboxdb;user id =sa;password=Password12345;");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
     builder.Entity<Crust>().HasKey(c => c.CrustId);
      builder.Entity<Pizza>().HasKey(p => p.PizzaId);
      builder.Entity<PizzaTopping>().HasKey(pt => new { pt.PizzaId, pt.ToppingId });
      builder.Entity<Size>().HasKey(s => s.SizeId);
      builder.Entity<Topping>().HasKey(t => t.ToppingId);
      builder.Entity<User>().HasKey(u => u.UName);
      builder.Entity<Store>().HasKey(s => s.UName);
      builder.Entity<Order>().HasKey(o => o.OrderId);

      builder.Entity<Crust>().HasMany(c => c.Pizzas).WithOne(p => p.Crust);
      builder.Entity<Pizza>().HasMany(p => p.PizzaToppings).WithOne(pt => pt.Pizza).HasForeignKey(pt => pt.PizzaId);
      builder.Entity<Size>().HasMany(s => s.Pizzas).WithOne(p => p.Size);
      builder.Entity<Topping>().HasMany(t => t.PizzaToppings).WithOne(pt => pt.Topping).HasForeignKey(pt => pt.ToppingId);
      builder.Entity<User>().HasMany( u => u.Orders).WithOne(o => o.User);
      builder.Entity<Store>().HasMany(s => s.Orders).WithOne(o => o.Store);
      builder.Entity<Order>().HasMany(o => o.Pizzas).WithOne(p => p.Order);



      
      builder.Entity<Crust>().HasData(new Crust[]
      {
        new Crust() {Name = "Thin Crust",Price = 2.00M},
        new Crust() {Name = "Deep Dish",Price = 4.00M},
        new Crust() {Name = "New York Style",Price = 3.00M}
      });
      builder.Entity<Size>().HasData(new Size[]
      {
        new Size() {Name = "Large", Price = 12.00M},
        new Size() {Name = "Medium", Price = 10.00M},
        new Size() {Name = "Small", Price = 8.00M}
      });
      builder.Entity<Topping>().HasData(new Topping[]
      {
        new Topping() {Name = "Cheese",Price = 0.25M},
        new Topping() {Name = "Pepperoni",Price = 0.50M},
        new Topping() {Name = "Tomato Sauce",Price = 0.75M}
      });

      builder.Entity<User>().HasData( new User[]
      {
        new User() {UName = "User1", Password = "User1"}
      });
      builder.Entity<Store>().HasData( new Store[]
      {
        new Store() {UName = "Store1",Password = "Store1"},
        new Store() {UName = "Store2",Password = "Store2"}
      });
      
    }
  }
}