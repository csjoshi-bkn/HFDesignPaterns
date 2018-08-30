using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ChapterFour.FactoryMethodPattern
{
    public abstract class Pizza
    {
        internal String name;
        internal String dough;
        internal String sauce;
        internal ArrayList toppings = new ArrayList();

        internal virtual void Prepare()
        {
            Console.WriteLine("Preparing " + name);
            Console.WriteLine("Tossing dough ..... ");
            Console.WriteLine("Adding Sauce ....");
            Console.WriteLine("Adding toppings :");
            foreach (var temp in toppings)
            {
                Console.WriteLine("  " + temp);
            }
        }

        internal virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350.");
        }

        internal virtual void Cut()
        {
            Console.WriteLine("Cutting the Pizza into Diagonal slices.");
        }

        internal virtual void Box()
        {
            Console.WriteLine("Placing the pizza in official Pizza Store Box.");
        }

        internal String GetName()
        {
            return name;
        }
    }
}
