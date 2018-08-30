using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChanpterOne.Properties;

namespace ChapterOne
{
    public class MallardDuck : Duck
    {
        public MallardDuck() { }

        public override void Display()
        {
            Console.WriteLine(Resources.StrMallardDisplay);
        }
    }
}
