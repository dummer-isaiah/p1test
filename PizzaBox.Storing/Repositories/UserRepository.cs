using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Databases;

namespace PizzaBox.Storing.Repository
{

  public class UserRepository
  {

    private static readonly PizzaBoxDbContext _db = PizzaBoxDbContext.Instance;
     public List<User> Get()
    {
      return _db.User.ToList();
    }

    public User Get(string UName)
    {
      return _db.User.SingleOrDefault(u => u.UName == UName);
    }

    public bool Post(User user)
    {
      _db.User.Add(user);
      return _db.SaveChanges() == 1;
    }

    public bool Put(User user)
    {
      User u = Get(user.UName);

      u = user;
      return _db.SaveChanges() == 1;
    }
  }
}