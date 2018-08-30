using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterFour.AbstractFactory
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string item)
        {
            Pizza _pizza = null;
            IPizzaIngredientFactory _ingredientFactory = new ChicagoPizzaIngredientFactory();

            if (item.Equals("cheese"))
            {
                _pizza = new CheesePizza(_ingredientFactory);
                _pizza.SetName("Chicago Style Cheese Pizza.");
            }
            else if (item.Equals("clam"))
            {
                _pizza = new ClamPizza(_ingredientFactory);
                _pizza.SetName("Chicago style Clam Pizza.");
            }

            return _pizza;
        }
    }
}
