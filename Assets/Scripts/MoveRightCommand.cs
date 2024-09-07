﻿using UnityEngine;

namespace CommandPattern
{
    public class MoveRightCommand : ICommand
    {
        private PlayerMovement _playerMovement;
        private Vector3 _previousPosition;

        public MoveRightCommand(PlayerMovement movement)
        {
            _playerMovement = movement;
        }

        public void Execute()
        {
            _previousPosition = _playerMovement.GetCurrentPosition();
            _playerMovement.MoveRight();
        }

        public void Undo()
        {
            _playerMovement.UndoMove(_previousPosition);
        }
    }
}