using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterFour.AbstractFactory
{
    public class FreshClams : IClams
    {
        public FreshClams()
        {
            Console.WriteLine("Fresh Clams added ....");
        }
    }
}
