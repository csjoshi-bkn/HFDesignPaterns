using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterFour.AbstractFactory
{
    public class EggPlant : IVeggies
    {
        public EggPlant()
        {
            Console.WriteLine("Eggplants added....");
        }
    }
}
