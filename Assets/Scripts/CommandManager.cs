using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern
{
    public class CommandManager : MonoBehaviour
    {
        private Stack<ICommand> _commandStack = new Stack<ICommand>();
        private Stack<ICommand> _redoStack = new Stack<ICommand>();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _commandStack.Push(command);
            _redoStack.Clear();
        }

        public void Undo()
        {
            if (_commandStack.Count > 0)
            {
                ICommand commandToUndo = _commandStack.Pop();
                commandToUndo.Undo();
                _redoStack.Push(commandToUndo);
            }
        }

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