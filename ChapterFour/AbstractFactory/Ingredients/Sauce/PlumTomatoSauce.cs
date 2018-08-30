using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterFour.AbstractFactory
{
    public class PlumTomatoSauce : ISauce
    {
        public PlumTomatoSauce()
        {
            Console.WriteLine("Plum Tomato Sauce added....");
        }
    }
}
