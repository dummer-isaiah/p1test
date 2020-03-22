using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Repository;

namespace PizzaBox.Client.Controllers
{

  public class PizzaController : Controller
  {


    private PizzaRepository _pr = new PizzaRepository();
     private CrustRepository _cr = new CrustRepository();

    private SizeRepository _sr = new SizeRepository();
    [HttpGet]
    public IActionResult Get()
    {
      return View();
    }

    [HttpGet]
    public IActionResult Create()
    {
      return View(new PizzaViewModels());
    }

    [HttpPost]
    public IActionResult Create(PizzaViewModels pizzaViewModels)
    {
      Pizza p = new Pizza();
      p.HasOrder = false;
      List<Crust> CrustList = _cr.Get();
      List<Size> SizeList = _sr.Get();
      foreach(var item in CrustList)
      {
        if(item.Name == pizzaViewModels.Crust)
        {
          p.Crust = item;
          p.Name += item.Name;
          p.Price += item.Price;
        }
      }

      foreach(var item in SizeList)
      {
        if(item.Name == pizzaViewModels.Size)
        {
          p.Size = item;
          p.Name += item.Name;
          p.Price += item.Price;
        }
      }

      // List<PizzaTopping> ptl = new List<PizzaTopping>();
      // foreach(var item in pizzaViewModels.Toppings)
      // {
      //   ptl.Add(new PizzaTopping(){Topping = item});
      // }
      // p.PizzaToppings = ptl;
      _pr.Post(p);
      return View("ConfirmPizza");
    }
  }
}