using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterFour.AbstractFactory
{
    public class ThinCrustDough :IDough
    {
        public ThinCrustDough()
        {
            Console.WriteLine("Thin Crust Dough added...");
        }
    }
}
