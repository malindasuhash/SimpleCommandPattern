using System;

namespace commandpattern1
{
    /// <summary>
    /// Represent a light bulb.
    /// </summary>
    public class Light
    {
        public Light(string description)
        {
            Description = description;
        }

        public string Description { get; private set; }

        public void On()
        {
            Console.WriteLine("Turning on the light.");
        }

        public void Off()
        {
            Console.WriteLine("Turning off the light.");
        }
    }
}