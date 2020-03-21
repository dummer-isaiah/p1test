using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Databases;

namespace PizzaBox.Storing.Repository
{

  public class PizzaRepository
  {

    private static readonly PizzaBoxDbContext _db = PizzaBoxDbContext.Instance;
    
    public List<Pizza> Get()
    {
      
      return _db.Pizza.ToList();
    }

    public Pizza Get(long id)
    {
      return _db.Pizza.SingleOrDefault(p => p.PizzaId == id);
    }


    public bool Post(Pizza pizza)
    {
      
     _db.Pizza.Add(pizza);
      return  _db.SaveChanges() == 1;
    }

    public bool Put(Pizza pizza)
    {
     Pizza p = Get(pizza.PizzaId);

      p = pizza;
      return _db.SaveChanges() == 1;
      
    }

   

   

     

     
  }
}