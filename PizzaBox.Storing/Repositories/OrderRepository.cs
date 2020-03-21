using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Databases;

namespace PizzaBox.Storing.Repository
{

  public class OrderRepository
  {

    private static readonly PizzaBoxDbContext _db = PizzaBoxDbContext.Instance;

    public List<Order> Get()
    {
      return _db.Order.ToList();
    }

    public Order Get(long id)
    {
      return _db.Order.SingleOrDefault(o => o.OrderId == id);
    }

    public bool Post(Order Order)
    {
      _db.Order.Add(Order);
      return _db.SaveChanges() == 1;
    }

    public bool Put(Order Order)
    {
      Order u = Get(Order.OrderId);

      u = Order;
      return _db.SaveChanges() == 1;
    }
  }
}