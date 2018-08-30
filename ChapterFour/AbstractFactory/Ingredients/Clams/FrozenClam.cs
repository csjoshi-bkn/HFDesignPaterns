using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterFour.AbstractFactory
{
    public class FrozenClam : IClams
    {
        public FrozenClam()
        {
            Console.WriteLine("Frozen Clams added....");
        }
    }
}
