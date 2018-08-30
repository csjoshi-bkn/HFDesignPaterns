using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterSix
{
    class NoCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("No Command :  NULL Object");
        }


        public void Undo()
        {
            Console.WriteLine("No Command :  NULL Object");
        }
    }
}
