using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterFour.AbstractFactory
{
    public interface IPizzaIngredientFactory
    {
        IDough CreateDough();
        ISauce CreateSauce();
        ICheese CreateCheese();
        IVeggies[] CreateVeggies();
        IPepperoni CreatePepperoni();
        IClams CreateClam();
    }
}
