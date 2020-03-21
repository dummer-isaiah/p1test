using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Databases;

namespace PizzaBox.Storing.Repository
{

  public class SizeRepository
  {

    private static readonly PizzaBoxDbContext _db =  PizzaBoxDbContext.Instance;

    public List<Size> Get()
    {
      return _db.Size.ToList();
    }

    public Size Get(long id)
    {
      return _db.Size.SingleOrDefault(s => s.SizeId == id);
    }


    public bool Post(Size Size)
    {
      _db.Size.Add(Size);
      return  _db.SaveChanges() == 1;
    }

    public bool Put(Size Size)
    {
      Size s = Get(Size.SizeId);

      s = Size;
      return _db.SaveChanges() == 1;
    }
  }
}