using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterFour.FactoryMethodPattern
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            name = "NY Style Sauce and Cheese Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marianara Sauce";

            toppings.Add("Grated Reggiano Cheese");
        }
    }
}
