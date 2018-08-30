using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChanpterOne.Properties;

namespace ChapterOne
{
    class MiniDuckSimulator
    {
        static void Main()
        {
            Duck Mallard = new MallardDuck();
            Mallard.Kill += new EventHandler(Mallard_Kill);
            
            ShowDuck(Mallard, false,null,null);
            Console.WriteLine();

            Console.WriteLine(Resources.StrRTCB);
            
            ShowDuck(Mallard,true,new FlyRocketPowered(),new Squeak());
            Console.ReadLine();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="duck">Duck Object</param>
        /// <param name="setBehavior">Pass true if you want to set Duck Behavior</param>
        /// <param name="fb">Pass IFlybehavior if setBehavior is true else pass null</param>
        /// <param name="qb">Pass IQuackBehavior if setBehavior is true else pass null</param>
        static void ShowDuck(Duck duck,bool setBehavior,IFlyBehavior fb,IQuackBehavior qb)
        {
            if (setBehavior)
            {
                if(fb != null)
                    duck.SetFlyBehavior(fb);
                if(qb != null)
                    duck.SetQuackBehavior(qb);
            }
            duck.Display();
            duck.PerformQuack();
            duck.PerformFly();
            Duck.Swim();
        }

        /// <summary>
        /// Cleanup Event, clean all objects here if required.
        /// </summary>
        /// <param name="sender">Duck Class</param>
        /// <param name="e"></param>
        static void Mallard_Kill(object sender, EventArgs e)
        {
            Console.WriteLine(Resources.StrCleaningMSG);
            Console.WriteLine();
        }
    }
}
