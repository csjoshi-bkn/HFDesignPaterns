using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterSix
{
    public class LightOnCommand : ICommand
    {
        Light _light;
        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.On();
        }


        public void Undo()
        {
            _light.Off();
        }
    }
}
