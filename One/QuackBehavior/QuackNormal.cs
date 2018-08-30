using System;
using One;

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
