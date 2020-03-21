using System.Collections.Generic;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Repository;

namespace PizzaBox.Client.Models
{

  public class PizzaViewModels
  {

    
    private CrustRepository _cr = new CrustRepository();

    private SizeRepository _sr = new SizeRepository();

    private ToppingRepository _tr = new ToppingRepository();
  


    public List<Crust> CrustList { get; set; }
    public List<Size> SizeList { get; set; }
    public List<Topping> ToppingList { get; set; }

    public string Crust { get; set; }
    public string Size { get; set; }
    public List<Topping> Toppings { get; set; }

    public PizzaViewModels()
    {
      CrustList = _cr.Get();
      SizeList = _sr.Get();
      ToppingList = _tr.Get();
    }


  }
}