using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterFour.FactoryMethodPattern
{
    public class ChicagoStylePepperoniPizza : Pizza
    {
        public ChicagoStylePepperoniPizza()
        {
            name = "Chicago Style Pepperoni Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";

            toppings.Add("Shreded Mozzarella Cheese");
        }

        internal override void Cut()
        {
            Console.WriteLine("Cutting Pizza into Square Slices.");
        }
    }
}
