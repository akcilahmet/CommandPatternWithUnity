using UnityEngine;

namespace CommandPattern
{
    public class MoveBackwardCommand : ICommand
    {
        private PlayerMovement _playerMovement;
        private Vector3 _previousPosition;

        /// <summary>
        /// Initializes a new instance of the <see cref="MoveBackwardCommand"/> class.
        /// </summary>
        public MoveBackwardCommand(PlayerMovement movement)
        {
            _playerMovement = movement;
        }

        public void Execute()
        {
            _previousPosition = _playerMovement.GetCurrentPosition();
            _playerMovement.MoveBackward();
        }

        public void Undo()
        {
            _playerMovement.UndoMove(_previousPosition);
        }
    }
}