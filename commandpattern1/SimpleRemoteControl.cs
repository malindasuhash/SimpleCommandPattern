namespace commandpattern1
{
    /// <summary>
    /// This is the invoker that is responsible for invoking 
    /// the command.
    /// </summary>
    public class SimpleRemoteControl
    {
        private ICommand _command;
        private ICommand _lastCommand;

        public void SetCommand(ICommand command)
        {
            _command = command;
            _lastCommand = command;
        }

        public void ButtonPress()
        {
            _command.Execute();
        }

        public void UndoButtonPressed()
        {
            _lastCommand.Undo();
        }
    }
}