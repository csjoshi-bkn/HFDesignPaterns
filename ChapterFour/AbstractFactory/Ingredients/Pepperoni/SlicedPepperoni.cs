using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterFour.AbstractFactory
{
    public class SlicedPepperoni :IPepperoni
    {
        public SlicedPepperoni()
        {
            Console.WriteLine("Sliced Pepperoni added....");
        }
    }
}
