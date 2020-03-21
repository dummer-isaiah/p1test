using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{

  public class Pizza 
  {
    public long PizzaId { get; set;}
    
    public string Name { get; set; }

    public decimal Price{get; set;}

    #region NAVIGATIONAL PROPERTIES
    public Crust Crust { get; set; }

    public Size Size { get; set; }

    public Order Order {get; set;}

    public List<PizzaTopping> PizzaToppings { get; set; }
    #endregion

    public Pizza()
    {
      
    }

    public override string ToString()
    {
      return $"{PizzaId} {Name ?? "N/A"} {Price} {Crust.Name ?? "N/A"} {Size.Name ?? "N/A"} {PizzaToppings.Count}";
    }


  }


}