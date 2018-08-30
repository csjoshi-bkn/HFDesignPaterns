using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterFour.AbstractFactory
{
    public class Garlic : IVeggies
    {
        public Garlic()
        {
            Console.WriteLine("Garlic Added....");
        }
    }
}
