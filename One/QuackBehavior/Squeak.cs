using System;
using One;

namespace ChapterOne
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine(Resources.StrSqueak);
        }
    }
}
