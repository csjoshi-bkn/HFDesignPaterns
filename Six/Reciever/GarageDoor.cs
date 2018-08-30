using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterSix
{
    public class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("Door is Open .... ");
        }

        public void Down()
        {
            Console.WriteLine("Door is Closed .... ");
        }

        public void Stop()
        {
            Console.WriteLine("Stopped .... ");
        }

        public void LightOn()
        {
            Console.WriteLine("Door Light is On .... ");
        }

        public void LightOff()
        {
            Console.WriteLine("Door Light is Off .... ");
        }
    }
}
