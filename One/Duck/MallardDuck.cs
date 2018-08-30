using System;
using One;

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
