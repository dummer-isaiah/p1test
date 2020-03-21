using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{

  public class Order
  {
    public long OrderId {get; set;}


    #region NAVIGATIONAL PROPERTIES
    public string UUName { get; set; }
    public User User { get; set; }
    public string SUName { get; set; }

    public Store Store { get; set; }

    public List<Pizza> Pizzas { get; set; }
    #endregion

    public void veiw()
    {
      
    }
  }
}