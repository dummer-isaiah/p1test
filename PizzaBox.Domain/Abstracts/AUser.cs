using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{

  public abstract class AUser
  {
    public string UName { get; set; }

    public string Password { get; set; }

    public List<Order> Orders { get; set; }
  }
}