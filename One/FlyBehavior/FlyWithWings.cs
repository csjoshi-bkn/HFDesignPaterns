using System;
using One;

namespace ChapterOne
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine(Resources.StrNormalFly);
        }
    }
}
