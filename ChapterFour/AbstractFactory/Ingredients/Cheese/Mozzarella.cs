using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterFour.AbstractFactory
{
    public class Mozzarella : ICheese
    {
        public Mozzarella()
        {
            Console.WriteLine("Mozzarella cheese added....");
        }
    }
}
