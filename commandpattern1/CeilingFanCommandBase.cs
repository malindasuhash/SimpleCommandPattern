using System;

namespace commandpattern1
{
    /// <summary>
    /// This is the base class for all the celing fan commands.
    /// </summary>
    public abstract class CeilingFanCommandBase : ICommand
    {
        private readonly CeilingFan _ceilingFan;

        protected CeilingFanCommandBase(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public CeilingFanSpeed Previous { get; protected set; }

        public abstract void Execute();

        public void Undo()
        {
            switch (Previous)
            {
                case CeilingFanSpeed.Off:
                    _ceilingFan.Off();
                    break;

                case CeilingFanSpeed.High:
                    _ceilingFan.High();
                    break;

                case CeilingFanSpeed.Low:
                    _ceilingFan.Low();
                    break;

                case CeilingFanSpeed.Medium:
                    _ceilingFan.Medium();
                    break;

                default:
                    throw new NotImplementedException("Um....");
            }
        }
    }
}