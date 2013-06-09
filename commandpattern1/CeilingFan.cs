using System;

namespace commandpattern1
{
    /// <summary>
    /// Represent a ceiling fan.
    /// </summary>
    public class CeilingFan
    {
        private readonly string _location;

        private CeilingFanSpeed _speed = CeilingFanSpeed.Off;

        public CeilingFanSpeed FanSpeed { get { return _speed; } }

        public CeilingFan(string location)
        {
            _location = location;
        }

        public void High()
        {
            _speed = CeilingFanSpeed.High;
            Console.WriteLine("Ceiling fan HIGH.");
        }

        public void Low()
        {
            _speed = CeilingFanSpeed.Low;
            Console.WriteLine("Ceiling fan LOW.");
        }

        public void Medium()
        {
            _speed = CeilingFanSpeed.Medium;
            Console.WriteLine("Ceiling fan MEDIUM.");
        }

        public void Off()
        {
            _speed = CeilingFanSpeed.Off;
            Console.WriteLine("Ceiling fan OFF.");
        }
    }

    /// <summary>
    /// Speeds of the ceiling fan.
    /// </summary>
    public enum CeilingFanSpeed
    {
        Low,

        Medium,

        High,

        Off
    }
}