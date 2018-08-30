using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterThree
{
    public class Mocha : CondimentDecorator
    {
        Beverage _beverage;
        public Mocha(Beverage beverage)
        {
            this._beverage = beverage;
        }

        public override String GetDescription()
        {
            return _beverage.GetDescription() + ", Mocha";
        }

        public override double Cost()
        {
            return .20 + _beverage.Cost();
        }
    }
}
