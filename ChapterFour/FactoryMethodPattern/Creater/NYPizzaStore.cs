using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterFour.FactoryMethodPattern
{
    public class NYPizzaStore : PizzaStore
    {
        // Implementing Factory Method as per specification of NY store to Create Pizza.
        protected override Pizza CreatePizza(String type)
        {
            if (type.Equals("cheese"))
                return new NYStyleCheesePizza();
            else if(type.Equals("Pepperoni"))
                return new NYStylePepperoniPizza();
            else
                return null;
        }
    }
}
