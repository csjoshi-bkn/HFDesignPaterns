using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterFour.FactoryMethodPattern
{
    public class ChicagoPizzaStore : PizzaStore
    {
        // Implementing Factory Method as per specification of Chicago store to Create Pizza.
        protected override Pizza CreatePizza(String type)
        {
            if (type.Equals("cheese"))
                return new ChicagoStyleCheesePizza();
            if (type.Equals("Pepperoni"))
                return new ChicagoStylePepperoniPizza();
            else
                return null;
        }
    }
}
