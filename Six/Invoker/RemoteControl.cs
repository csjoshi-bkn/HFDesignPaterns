using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterSix
{
    public class RemoteControl
    {
        ICommand[] onCommands;
        ICommand[] offCommands;
        //ICommand undoCommand;
        Stack<ICommand> unCommandStack = new Stack<ICommand>();

        internal RemoteControl()
        {
            onCommands = new ICommand[7];
            offCommands = new ICommand[7];

            ICommand noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
            //undoCommand = noCommand;
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void OnButtonPushed(int slot)
        {
            onCommands[slot].Execute();
            //undoCommand = onCommands[slot];
            unCommandStack.Push(onCommands[slot]);
        }

        public void OffButtonPushed(int slot)
        {
            offCommands[slot].Execute();
            //undoCommand = offCommands[slot];
            unCommandStack.Push(offCommands[slot]);
        }

        public void UndoButtonPushed()
        {
            //undoCommand.Undo();
            unCommandStack.Pop().Undo();
        }

        public override string ToString()
        {
            StringBuilder stringBuffer = new StringBuilder();
            stringBuffer.Append("\n------------- Remote Control -------------\n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                stringBuffer.Append("[Slot " + i + "] " + onCommands[i].GetType().ToString() +
                    "   " + offCommands[i].GetType().ToString() + "\n");
            }
            //stringBuffer.Append("[Undo] " + undoCommand.GetType().ToString() + "\n");
            stringBuffer.Append("[Undo] " + unCommandStack.GetType().ToString() + "\n");
            return stringBuffer.ToString();
        }
    }
}
