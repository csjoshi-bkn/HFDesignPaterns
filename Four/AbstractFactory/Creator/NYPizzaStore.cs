using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterFour.AbstractFactory
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(String item)
        {
            Pizza _pizza = null;
            IPizzaIngredientFactory _ingredientFactory = new NYPizzaIngredientFactory();

            if (item.Equals("cheese"))
            {
                _pizza = new CheesePizza(_ingredientFactory);
                _pizza.SetName("New York Style Cheese Pizza.");
            }
            else if (item.Equals("clam"))
            {
                _pizza = new ClamPizza(_ingredientFactory);
                _pizza.SetName("New York style Clam Pizza.");
            }

            return _pizza;
        }
    }
}
