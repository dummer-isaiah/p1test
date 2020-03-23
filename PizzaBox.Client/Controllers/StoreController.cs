using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Repository;

namespace PizzaBox.Client.Controllers
{

  public class StoreController : Controller
  {

    private StoreRepostitory _sr = new StoreRepostitory();

   [HttpGet]
    public IActionResult StoreHistory()
    {
      Store s = _sr.Get(TempData["store"].ToString());
      TempData.Keep("store");
      StoreModel sm = new StoreModel();
      sm.Orders.RemoveAll(item => item.SUName != s.UName);
      return View(sm);
    }

    [HttpGet]
    public IActionResult StoreSales()
    {
       Store s = _sr.Get(TempData["store"].ToString());
      TempData.Keep("store");
      StoreModel sm = new StoreModel();
      sm.Orders.RemoveAll(item => item.SUName != s.UName);
      foreach(var item in sm.Orders)
      {
        foreach(var i in sm.Pizzas)
        {
          if(i.Order == item)
          {
            sm.Sales += i.Price;
          }
        }
      }
      return View(sm);
    }

    [HttpGet]
    public IActionResult gonav2()
    {
      return View("Navigate2");
    } 
  }
}