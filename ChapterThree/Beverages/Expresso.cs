using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterThree
{
    public class Expresso : Beverage
    {
        public Expresso()
        {
            description = "Expresso Coffee";
        }
        public override double Cost()
        {
            return 1.99;
        }
    }
}
