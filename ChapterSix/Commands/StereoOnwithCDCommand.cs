using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterSix
{
    public class StereoOnwithCDCommand : ICommand
    {
        Stereo _stereo;
        public StereoOnwithCDCommand(Stereo stereo)
        {
            _stereo = stereo;
        }
        public void Execute()
        {
            _stereo.On();
            _stereo.SetCD();
            _stereo.SetVolume(14);
        }


        public void Undo()
        {
            _stereo.Off();
        }
    }
}
