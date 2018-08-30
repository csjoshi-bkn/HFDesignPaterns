using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterSix
{
    public class Stereo
    {
        public void On()
        {
            Console.WriteLine("Stereo is On .... ");
        }

        public void Off()
        {
            Console.WriteLine("Stereo is Off .... ");
        }

        public void SetCD()
        {
            Console.WriteLine("Stereo is Set for CD .... ");
        }

        public void SetDVD()
        {
            Console.WriteLine("Stereo is Set for DVD .... ");
        }

        public void SetRadio()
        {
            Console.WriteLine("Stereo is Set for Radio .... ");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine("Stereo Volume is set to " + volume.ToString());
        }
    }
}
