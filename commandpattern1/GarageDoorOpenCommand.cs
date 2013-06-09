using System;

namespace commandpattern1
{
    /// <summary>
    /// Opening the garage door command.
    /// </summary>
    public class GarageDoorOpenCommand : ICommand
    {
        private readonly Garage _garage;

        public GarageDoorOpenCommand(Garage garage)
        {
            _garage = garage;
        }

        public void Execute()
        {
            Console.WriteLine("Opening the Garage door!");
            _garage.OpenDoor();
        }

        public void Undo()
        {
            Console.WriteLine("Closing the Garage door.");
        }
    }
}