using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ChapterFour.AbstractFactory;
//using ChapterFour.FactoryMethodPattern;

namespace ChapterFour
{
    class PizzaTestDrive
    {
        static void Main(/*string[] args*/)
        {
            //Two Pizza Store, more can be opened without changing the base classes.
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine("Ethan ordered a " + pizza.GetName());

            Console.WriteLine();

            pizza = chStore.OrderPizza("clam");
            Console.WriteLine("Joe ordered a " + pizza.GetName());
        }
    }
}
