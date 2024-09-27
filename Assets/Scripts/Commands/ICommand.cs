namespace CommandPattern
{
    public interface ICommand
    {
        /// <summary>
        /// Executes the command.
        /// </summary>
        void Execute();

        /// <summary>
        /// Undoes the command.
        /// </summary>
        void Undo();
    }
}