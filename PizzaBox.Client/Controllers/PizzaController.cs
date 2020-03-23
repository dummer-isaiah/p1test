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

    private ToppingRepository _tr = new ToppingRepository();
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
          p.Name += item.Name + " ";
          p.Price += item.Price;
        }
      }

      foreach(var item in SizeList)
      {
        if(item.Name == pizzaViewModels.Size)
        {
          p.Size = item;
          p.Name += item.Name + " ";
          p.Price += item.Price;
        }
      }

      for (int i = 0; i < pizzaViewModels.Count; i++)
      {
        if(i == 0)
        {
          if(!pizzaViewModels.Topping1)
        {
          pizzaViewModels.ToppingList.Remove(_tr.Get(pizzaViewModels.Toppings[i]));
        }
        }
        else if(i ==1)
        {
          if(!pizzaViewModels.Topping2)
        {
          pizzaViewModels.ToppingList.Remove(_tr.Get(pizzaViewModels.Toppings[i]));
        }
        }
        else
        {
          if(!pizzaViewModels.Topping3)
        {
          pizzaViewModels.ToppingList.Remove(_tr.Get(pizzaViewModels.Toppings[i]));
        }
        }
          
      }
      List<PizzaTopping> lpt = new List<PizzaTopping>();
      foreach (var item in pizzaViewModels.ToppingList)
      {
          p.Price += item.Price;
          p.Name += item.Name + " ";
           lpt.Add(new PizzaTopping(){Topping = item});
      }
      p.PizzaToppings = lpt;
      _pr.Post(p);
      return View("ConfirmPizza");
    }
  }
}