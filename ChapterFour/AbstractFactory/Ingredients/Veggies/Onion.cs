using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterFour.AbstractFactory
{
    public class Onion : IVeggies
    {
        public Onion()
        {
            Console.WriteLine("Onion added .....");
        }
    }
}
