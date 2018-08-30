using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterFour.AbstractFactory
{
    class CheesePizza : Pizza
    {
        IPizzaIngredientFactory _ingredientFactory;

        public CheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        internal override void Prepare()
        {
            Console.WriteLine("Preparing " + _name);
            _dough = _ingredientFactory.CreateDough();
            _sauce = _ingredientFactory.CreateSauce();
            _cheese = _ingredientFactory.CreateCheese();
        }
    }
}
