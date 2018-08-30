using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterFour.AbstractFactory
{
    public class Spinach : IVeggies
    {
        public Spinach()
        {
            Console.WriteLine("Spinach added....");
        }
    }
}
