using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterSix
{
    public class SimpleRemoteControl
    {
        ICommand slot;

        public void SetCommand(ICommand command)
        {
            slot = command;
        }

        public void ButtonPressed()
        {
            slot.Execute();
        }
    }
}
