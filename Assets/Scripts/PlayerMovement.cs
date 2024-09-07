using System;
using UnityEngine;

namespace CommandPattern
{
    public class PlayerMovement : MonoBehaviour
    {
        public float _moveDistance = 5f;
        private Vector3 _startPosition;

        private void Start()
        {
            _startPosition = transform.position;
        }

        public void MoveForward()
        {
            transform.position += transform.forward * _moveDistance;
            Debug.Log("Moved Forward");
        }

        public void MoveBackward()
        {
            transform.position -= transform.forward * _moveDistance;
            Debug.Log("Moved Backward");
        }

        public void MoveRight()
        {
            transform.position += transform.right * _moveDistance;
            Debug.Log("Moved Right");
        }

        public void MoveLeft()
        {
            transform.position -= transform.right * _moveDistance;
            Debug.Log("Moved Left");
        }

        public void UndoMove(Vector3 previousPosition)
        {
            transform.position = previousPosition;
            Debug.Log("Movement undone");
        }

        public Vector3 GetCurrentPosition()
        {
            return transform.position;
        }

        public void ResetPosition()
        {
            transform.position = _startPosition;
        }
    }
}