using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Repository;

namespace PizzaBox.Client.Controllers
{

  public class OrderController : Controller
  {

    PizzaRepository _pr = new PizzaRepository();
    OrderRepository _or = new OrderRepository();
    [HttpGet]
    public IActionResult Get()
    {
      return View();
    }

    [HttpGet]
    public IActionResult Checkout()
    {
      return View(new OrderViewModel());
    }

    [HttpPost]
    public IActionResult Checkout(OrderViewModel OrderViewModel)
    {
      Order o = new Order();
      _or.Post(o);
      foreach(var item in OrderViewModel.Pizzas)
      {
        item.Order = o;
        item.HasOrder = true;
        _pr.Put(item);
      }
      return View("Navigate");
    }
  }

  
}