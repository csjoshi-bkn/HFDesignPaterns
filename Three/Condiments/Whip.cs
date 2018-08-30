using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterThree
{
    public class Whip : CondimentDecorator
    {
        Beverage _beverage;

        public Whip(Beverage beverage)
        {
            this._beverage = beverage;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Whip";
        }

        public override double Cost()
        {
            return .10 + _beverage.Cost();
        }
    }
}
