using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChanpterOne.Properties;

namespace ChapterOne
{
    public class QuackNormal : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine(Resources.StrNormalQuack);
        }
    }
}
