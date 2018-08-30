using System;
using One;

namespace ChapterOne
{
    public class NoFly : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine(Resources.StrNoFly);
        }
    }
}
