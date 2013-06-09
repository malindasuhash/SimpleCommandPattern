using System;
using System.Collections.Generic;

namespace commandpattern1
{
    /// <summary>
    /// This is a composite command.
    /// </summary>
    public class CompositeCommand : ICommand
    {
        private readonly ICommand[] _commands;
        private readonly Stack<ICommand> _undoCommands = new Stack<ICommand>();

        public CompositeCommand(ICommand[] commands)
        {
            _commands = commands;
        }

        public void Execute()
        {
            foreach (var command in _commands)
            {
                command.Execute();
                _undoCommands.Push(command);
            }
        }

        public void Undo()
        {
            while (_undoCommands.Count != 0)
            {
                var command = _undoCommands.Pop();
                command.Undo();
            }
        }
    }
}