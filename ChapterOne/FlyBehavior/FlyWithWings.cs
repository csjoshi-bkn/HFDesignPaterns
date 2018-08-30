using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChanpterOne.Properties;

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
