using System;

namespace commandpattern1
{
    /// <summary>
    /// Command to turn a light on.
    /// </summary>
    public class LightOnCommand : ICommand
    {
        private readonly Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.On();
            Console.WriteLine("Light {0} is turned on.", _light.Description);
        }

        public void Undo()
        {
            _light.Off();
            Console.WriteLine("Light {0} is turned off.", _light.Description);
        }
    }
}