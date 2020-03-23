using System.Collections.Generic;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Repository;

namespace PizzaBox.Client.Models
{

  public class OrderViewModel
  {

    private PizzaRepository _pr = new PizzaRepository();

    private StoreRepostitory _sr = new StoreRepostitory();

    public List<Pizza> Pizzas { get; set; }

    public List<Store> Stores {get; set;}

    public string store { get; set; }

    public OrderViewModel()
    {
      Stores = _sr.Get();
      List<Pizza> temp = _pr.Get();
      this.Pizzas =  new List<Pizza>(); 
      foreach(var item in temp)
      {
        if(item.HasOrder == false)
        {
          this.Pizzas.Add(item); 
        }
      }
      
    }
  }
}