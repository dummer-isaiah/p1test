using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Repository;

namespace PizzaBox.Client.Controllers
{

  public class OrderController : Controller
  {

     private PizzaRepository _pr = new PizzaRepository();
    private OrderRepository _or = new OrderRepository();
    private UserRepository _ur = new UserRepository();
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
      o.UUName = TempData["user"].ToString();
      TempData.Keep("user");
      o.SUName = OrderViewModel.store;
      _or.Post(o);
      foreach(var item in OrderViewModel.Pizzas)
      {
        item.Order = o;
        item.HasOrder = true;
        _pr.Put(item);
      }
      return View("Navigate");
    }


    [HttpGet]
    public IActionResult UserHistory()
    {
      User u = _ur.Get(TempData["user"].ToString());
      TempData.Keep("user");
      UserHistoryViewModel uhvm = new UserHistoryViewModel();
      uhvm.Orders.RemoveAll(item => item.UUName != u.UName);
      return View(uhvm);
    }

    [HttpGet]
    public IActionResult gonav()
    {
      return View("Navigate");
    }
  }

  
}