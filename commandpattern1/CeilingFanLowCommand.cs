namespace commandpattern1
{
    /// <summary>
    /// Turns the ceiling fan low.
    /// </summary>
    public class CeilingFanLowCommand : CeilingFanCommandBase
    {
        private readonly CeilingFan _ceilingFan;

        public CeilingFanLowCommand(CeilingFan ceilingFan) : base(ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public override void Execute()
        {
            Previous = _ceilingFan.FanSpeed;
            _ceilingFan.Low();
        }
    }
}