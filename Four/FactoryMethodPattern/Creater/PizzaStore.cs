using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterFour.FactoryMethodPattern
{
    public abstract class PizzaStore
    {
        // Factory Method, responsibility of Instantiating Pizzas is moved to this method.
        protected abstract Pizza CreatePizza(String type);

        public Pizza OrderPizza(String type)
        {
            Pizza pizza;

            pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
