using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterFour.AbstractFactory
{
    public class ThickCrustDough : IDough
    {
        public ThickCrustDough()
        {
            Console.WriteLine("Thick Crust Dough added....");
        }
    }
}
