using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Storing.Repository;

namespace PizzaBox.Client.Controllers
{

  public class PizzaController : Controller
  {

    [HttpGet]
    public IActionResult Get()
    {
      return View();
    }

    [HttpGet]
    public IActionResult Create()
    {
      return View(new PizzaViewModels(new PizzaRepository(),new CrustRepository(),new SizeRepository(),new ToppingRepository()));
    }

    [HttpPost]
    public IActionResult Create(PizzaViewModels pizzaViewModels)
    {
      return View();
    }
  }
}