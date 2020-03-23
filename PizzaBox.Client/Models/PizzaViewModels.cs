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

    public int Count { get; set; }

    public string[] Toppings { get; private set; }

    
    public bool Topping1 { get; set; }

    public bool Topping2 { get; set; }

    public bool Topping3 { get; set; }

    public PizzaViewModels()
    {
      CrustList = _cr.Get();
      SizeList = _sr.Get();
      ToppingList = _tr.Get();
      Toppings = new string[ToppingList.Count];
      
      Count = ToppingList.Count;
      int count = 0;
      foreach(var item in ToppingList)
      {
        Toppings[count] = item.Name;
        
        count++;
      }
    }


  }
}