using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Databases;

namespace PizzaBox.Storing.Repository
{

  public class CrustRepository
  {

    private static readonly PizzaBoxDbContext _db =  PizzaBoxDbContext.Instance;

    public List<Crust> Get()
    {
      return _db.Crust.ToList();
    }

    public Crust Get(long id)
    {
      return _db.Crust.SingleOrDefault(c => c.CrustId == id);
    }


    public bool Post(Crust crust)
    {
      _db.Crust.Add(crust);
      return  _db.SaveChanges() == 1;
    }

    public bool Put(Crust crust)
    {
      Crust c = Get(crust.CrustId);

      c = crust;
      return _db.SaveChanges() == 1;
    }
  }
}