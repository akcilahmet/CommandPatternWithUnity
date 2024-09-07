using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern
{
    /// <summary>
    /// Manages the execution, undo, and redo of commands using the Command Pattern.
    /// </summary>
    public class CommandManager : MonoBehaviour
    {
        private Stack<ICommand> _commandStack = new Stack<ICommand>();
        private Stack<ICommand> _redoStack = new Stack<ICommand>();

        /// <summary>
        /// Executes a command and pushes it onto the command stack.
        /// </summary>
        /// <param name="command">The command to execute.</param>
        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _commandStack.Push(command);
            _redoStack.Clear();
        }

        /// <summary>
        /// Undoes the most recent command and pushes it onto the redo stack.
        /// </summary>
        public void Undo()
        {
            if (_commandStack.Count > 0)
            {
                ICommand commandToUndo = _commandStack.Pop();
                commandToUndo.Undo();
                _redoStack.Push(commandToUndo);
            }
        }

        /// <summary>
        /// Redoes the most recent undone command and pushes it back onto the command stack.
        /// </summary>
        public void Redo()
        {
            if (_redoStack.Count > 0)
            {
                ICommand commandToRedo = _redoStack.Pop();
                commandToRedo.Execute();
                _commandStack.Push(commandToRedo);
            }
        }
    }
}