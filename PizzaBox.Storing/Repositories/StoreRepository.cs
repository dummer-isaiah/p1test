using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Databases;

namespace PizzaBox.Storing.Repository
{

  public class StoreRepostitory
  {

    private static readonly PizzaBoxDbContext _db = PizzaBoxDbContext.Instance;

    public List<Store> Get()
    {
      return _db.Store.ToList();
    }

    public Store Get(string UName)
    {
      return _db.Store.SingleOrDefault(u => u.UName == UName);
    }

    public bool Post(Store store)
    {
      _db.Store.Add(store);
      return _db.SaveChanges() == 1;
    }

    public bool Put(Store store)
    {
      Store s = Get(store.UName);

      s = store;
      return _db.SaveChanges() == 1;
    }
  }
}