using One;
using System;

namespace ChapterOne
{
  public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine(Resources.StrRocketFly);
        }
    }
}
