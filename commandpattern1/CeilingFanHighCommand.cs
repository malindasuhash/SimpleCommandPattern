using System;

namespace commandpattern1
{
    /// <summary>
    /// Command to make the ceiling fan high.
    /// </summary>
    public class CeilingFanHighCommand : CeilingFanCommandBase
    {
        private readonly CeilingFan _ceilingFan;

        public CeilingFanHighCommand(CeilingFan ceilingFan) 
            : base(ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public override void Execute()
        {
            Previous = _ceilingFan.FanSpeed;
            _ceilingFan.High();
        }
    }
}