using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterFour.AbstractFactory
{
    public abstract class PizzaStore
    {
        protected abstract Pizza CreatePizza(String item);

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
