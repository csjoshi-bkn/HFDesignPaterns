using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterFour.AbstractFactory
{
    public class Mushroom : IVeggies
    {
        public Mushroom()
        {
            Console.WriteLine("Mushroom added...");
        }
    }
}
