using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterFour.SimpleFactory
{
    public class SimplePizzaFactory
    {
        private Pizza pizza;
        public Pizza Pizza
        {
            get
            {
                return pizza;
            }
            set
            {
                pizza = value;
            }
        }
    
        public Pizza CreatePizza(String type)
        {
            if (type.Equals("cheese"))
                return new CheesePizza();
            else if (type.Equals("ClamPizza"))
                return new ClamPizza();
            else if (type.Equals("Pepperoni"))
                return new PepperoniPizza();
            else if (type.Equals("Veggie"))
                return new VeggiePizza();
            else
                return null;
        }
    }
}
