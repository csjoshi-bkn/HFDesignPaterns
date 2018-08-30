using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterFour.AbstractFactory
{
    public abstract class Pizza
    {
        internal String _name;
        internal IDough _dough;
        internal ISauce _sauce;
        internal IVeggies[] _veggies;
        internal IPepperoni _pepperoni;
        internal IClams _clam;
        internal ICheese _cheese;

        internal abstract void Prepare();

        internal void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350.");
        }

        internal void Cut()
        {
            Console.WriteLine("Cut the Pizza into diagonal slices.");
        }

        internal void Box()
        {
            Console.WriteLine("Place Pizza in official Pizza Store Box.");
        }

        internal void SetName(String name)
        {
            _name = name;
        }

        internal String GetName()
        {
            return _name;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}