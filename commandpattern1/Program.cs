using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace commandpattern1
{
    /// <summary>
    /// This is the client.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // This is the invoker.
            var invoker = new SimpleRemoteControl();

            // This is receiver of the command.
            var light = new Light("Blue"); 
            var lightOnCommand = new LightOnCommand(light);

            invoker.SetCommand(lightOnCommand);
            invoker.ButtonPress();

            var garage = new Garage();
            var openGarageDoor = new GarageDoorOpenCommand(garage);
            invoker.SetCommand(openGarageDoor);
            invoker.ButtonPress();

            invoker.UndoButtonPressed();

            // Celing fan
            var ceilingFan = new CeilingFan("Bedroom");

            var ceilingFanHighCommand = new CeilingFanHighCommand(ceilingFan);
            invoker.SetCommand(ceilingFanHighCommand);
            invoker.ButtonPress();

            var celingFanLowCommand = new CeilingFanLowCommand(ceilingFan);
            invoker.SetCommand(celingFanLowCommand);
            invoker.ButtonPress();

            invoker.UndoButtonPressed();

            Console.Read(); 
        }
    }
}
