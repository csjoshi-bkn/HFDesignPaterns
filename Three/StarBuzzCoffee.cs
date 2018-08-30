using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterThree
{
    class StarBuzzCoffee
    {
        static void Main(/*string[] args*/)
        {
            Beverage beverage = new Expresso();
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.Cost());

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.GetDescription() + " $" + beverage2.Cost());

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.GetDescription() + " $" + beverage3.Cost());

            Beverage beverage4 = new Decaf();
            beverage4 = new SteamedMilk(beverage4);
            beverage4 = new Mocha(beverage4);
            Console.WriteLine(beverage4.GetDescription() + " $" + beverage4.Cost());
        }
    }
}
