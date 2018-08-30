using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterFour.AbstractFactory
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThickCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public ICheese CreateCheese()
        {
            return new Mozzarella();
        }

        public IVeggies[] CreateVeggies()
        {
            IVeggies[] veggies = {new EggPlant(), new Spinach(), new BlackOlives()};
            return veggies;
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public IClams CreateClam()
        {
            return new FrozenClam();
        }
    }
}
