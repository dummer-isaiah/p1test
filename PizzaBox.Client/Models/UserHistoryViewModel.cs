using System.Collections.Generic;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Repository;

namespace PizzaBox.Client.Models
{

  public class UserHistoryViewModel
  {

    private PizzaRepository _pr = new PizzaRepository();
    private OrderRepository _or = new OrderRepository();

    public List<Order> Orders {get; set;} 

    public List<Pizza> Pizzas {get; set;}

    public UserHistoryViewModel()
    {
     Orders = _or.Get();
     Pizzas = _pr.Get();
    }
  }
}