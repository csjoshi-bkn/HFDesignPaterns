using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterThree
{
    public abstract class Beverage
    {
        internal String description = "Unknown Beverage";

        public virtual String GetDescription()
        {
            return description;
        }

        public abstract double Cost();
    }
}
