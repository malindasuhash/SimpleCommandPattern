namespace commandpattern1
{
    /// <summary>
    /// Interface of a command.
    /// </summary>
    public interface ICommand
    {
        void Execute();

        void Undo();
    }
}