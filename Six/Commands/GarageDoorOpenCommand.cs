using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterSix
{
    public class GarageDoorOpenCommand : ICommand
    {
        GarageDoor _door;
        public GarageDoorOpenCommand(GarageDoor command)
        {
            _door = command;
        }
        public void Execute()
        {
            _door.Up();
        }


        public void Undo()
        {
            _door.Down();
        }
    }
}
