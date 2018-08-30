using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterSix
{
    public class GarageDoorCloseCommand : ICommand
    {
        GarageDoor _door;
        public GarageDoorCloseCommand(GarageDoor command)
        {
            _door = command;
        }
        public void Execute()
        {
            _door.Down();
        }


        public void Undo()
        {
            _door.Up();
        }
    }
}
