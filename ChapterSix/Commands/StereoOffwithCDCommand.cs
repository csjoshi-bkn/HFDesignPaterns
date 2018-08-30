using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterSix
{
    public class StereoOffwithCDCommand : ICommand
    {
        Stereo _stereo;
        public StereoOffwithCDCommand(Stereo stereo)
        {
            _stereo = stereo;
        }
        public void Execute()
        {
            _stereo.Off();
        }


        public void Undo()
        {
            _stereo.On();
        }
    }
}
