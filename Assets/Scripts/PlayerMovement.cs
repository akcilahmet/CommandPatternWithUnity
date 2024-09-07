using System;
using UnityEngine;

namespace CommandPattern
{
    public class PlayerMovement : MonoBehaviour
    {
        private Vector3 _startPosition;

        [SerializeField]
        private float _moveDistance = 1f;

        private void Start()
        {
            _startPosition = transform.position;
        }

        /// <summary>
        /// Moves the player forward by a specified distance.
        /// </summary>
        public void MoveForward()
        {
            transform.position += transform.forward * _moveDistance;
            Debug.Log("Moved Forward");
        }

        /// <summary>
        /// Moves the player backward by a specified distance.
        /// </summary>
        public void MoveBackward()
        {
            transform.position -= transform.forward * _moveDistance;
            Debug.Log("Moved Backward");
        }

        /// <summary>
        /// Moves the player to the right by a specified distance.
        /// </summary>
        public void MoveRight()
        {
            transform.position += transform.right * _moveDistance;
            Debug.Log("Moved Right");
        }

        /// <summary>
        /// Moves the player to the left by a specified distance.
        /// </summary>
        public void MoveLeft()
        {
            transform.position -= transform.right * _moveDistance;
            Debug.Log("Moved Left");
        }

        /// <summary>
        /// Undoes the last movement by resetting the player's position to the given previous position.
        /// </summary>
        public void UndoMove(Vector3 previousPosition)
        {
            transform.position = previousPosition;
            Debug.Log("Movement undone");
        }

        /// <summary>
        /// Gets the current position of the player.
        /// </summary>
        public Vector3 GetCurrentPosition()
        {
            return transform.position;
        }

        /// <summary>
        /// Resets the player's position to the starting position.
        /// </summary>
        public void ResetPosition()
        {
            transform.position = _startPosition;
        }
    }
}