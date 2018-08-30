using System;
using One;

namespace ChapterOne
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine(Resources.StrMuteQuack);
        }
    }
}
