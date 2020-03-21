using System.Collections.Generic;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Repository;

namespace PizzaBox.Client.Models
{

  public class PizzaViewModels
  {

    private PizzaRepository _pr;
    private CrustRepository _cr;

    private SizeRepository _sr;

    private ToppingRepository _tr;
  

    public PizzaViewModels(PizzaRepository prepository,CrustRepository crustRepository,SizeRepository sizeRepository,ToppingRepository trepository)
    {
      _pr = prepository;
      _cr = crustRepository;
      _sr = sizeRepository;
      _tr = trepository;
    }

    public List<Crust> CrustList { get; set; }
    public List<Size> SizeList { get; set; }
    public List<Topping> ToppingList { get; set; }

    public Crust Crust { get; set; }
    public Size Size { get; set; }
    public List<Topping> Toppings { get; set; }

    public PizzaViewModels()
    {
      CrustList = _cr.Get();
      SizeList = _sr.Get();
      ToppingList = _tr.Get();
    }


  }
}