using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Databases;

namespace PizzaBox.Storing.Repository
{

  public class ToppingRepository
  {

    private static readonly PizzaBoxDbContext _db = PizzaBoxDbContext.Instance;

    public List<Topping> Get()
    {
      return _db.Topping.ToList();
    }

    public Topping Get(long id)
    {
      return _db.Topping.SingleOrDefault(c => c.ToppingId == id);
    }


    public bool Post(Topping Topping)
    {
      _db.Topping.Add(Topping);
      return  _db.SaveChanges() == 1;
    }

    public bool Put(Topping Topping)
    {
      Topping t = Get(Topping.ToppingId);

      t = Topping;
      return _db.SaveChanges() == 1;
    }
  }
}