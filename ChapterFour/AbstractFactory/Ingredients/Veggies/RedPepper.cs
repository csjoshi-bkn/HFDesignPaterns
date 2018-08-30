using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterFour.AbstractFactory
{
    public class RedPepper : IVeggies
    {
        public RedPepper()
        {
            Console.WriteLine("RedPepper added.....");
        }
    }
}
