using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterSix
{
    class RemoteControlTest
    {
        static void Main(string[] args)
        {
            //SimpleRemoteControl remote = new SimpleRemoteControl();
            //Light light = new Light();
            //LightOnCommand lightOn = new LightOnCommand(light);
            //GarageDoor door = new GarageDoor();
            //GarageDoorOpenCommand doorOpen = new GarageDoorOpenCommand(door);

            //remote.SetCommand(lightOn);
            //remote.ButtonPressed();
            //remote.SetCommand(doorOpen);
            //remote.ButtonPressed();

            RemoteControl remoteControl = new RemoteControl();

            Light light = new Light();
            GarageDoor door = new GarageDoor();
            Stereo stereo = new Stereo();

            LightOnCommand lightOn = new LightOnCommand(light);
            LightOffCommand lightOff = new LightOffCommand(light);

            GarageDoorOpenCommand doorOpen = new GarageDoorOpenCommand(door);
            GarageDoorCloseCommand doorClose = new GarageDoorCloseCommand(door);

            StereoOnwithCDCommand stereoOn = new StereoOnwithCDCommand(stereo);
            StereoOffwithCDCommand stereoOff = new StereoOffwithCDCommand(stereo);

            remoteControl.SetCommand(0, lightOn, lightOff);
            remoteControl.SetCommand(1, doorOpen, doorClose);
            remoteControl.SetCommand(2, stereoOn, stereoOff);

            Console.WriteLine(remoteControl);

            remoteControl.OnButtonPushed(0);
            remoteControl.OnButtonPushed(1);
            remoteControl.OnButtonPushed(2);

            Console.WriteLine();
            Console.WriteLine("TEST : Undoing History....");
            remoteControl.UndoButtonPushed();
            remoteControl.UndoButtonPushed();
            remoteControl.UndoButtonPushed();
            Console.WriteLine("Undoing History Finished....");
            Console.WriteLine();

            remoteControl.OnButtonPushed(0);
            remoteControl.OffButtonPushed(0);
 
            remoteControl.OnButtonPushed(1);
            remoteControl.OffButtonPushed(1);

            remoteControl.OnButtonPushed(2);
            remoteControl.OffButtonPushed(2);

            // call Execute on No Command Object
            remoteControl.OnButtonPushed(3);
            remoteControl.OffButtonPushed(3);
        }
    }
}
