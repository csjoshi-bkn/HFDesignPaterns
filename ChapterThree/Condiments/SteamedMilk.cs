using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterThree
{
    public class SteamedMilk : CondimentDecorator
    {
        Beverage _beverage;

        public SteamedMilk(Beverage beverage)
        {
            this._beverage = beverage;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Steamed Milk";
        }

        public override double Cost()
        {
            return .10 + _beverage.Cost();
        }
    }
}
