using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterFour.AbstractFactory
{
    public class MarinaraSauce : ISauce
    {
        public MarinaraSauce()
        {
            Console.WriteLine("Marinara Sauce added...");
        }
    }
}
