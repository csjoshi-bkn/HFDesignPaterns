using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterFour.FactoryMethodPattern
{
    public class NYStylePepperoniPizza : Pizza
    {
        public NYStylePepperoniPizza()
        {
            name = "NY Style Pepperoni Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marianara Sauce";

            toppings.Add("Grated Reggiano Cheese");
        }
    }
}
