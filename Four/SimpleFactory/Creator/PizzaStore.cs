using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterFour.SimpleFactory
{
    public class PizzaStore
    {
        private SimplePizzaFactory factory;
        public SimplePizzaFactory Factory
        {
            get
            {
                return factory;
            }
            set
            {
                factory = value;
            }
        }
    
        public Pizza OrderPizza(String type)
        {
            Pizza pizza;
            pizza = factory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
