using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterThree
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract override String GetDescription();
    }
}
