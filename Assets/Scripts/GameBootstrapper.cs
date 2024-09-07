using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace CommandPattern
{
    public class GameBootstrapper : MonoBehaviour
    {
        [SerializeField]
        private UIManager _uiManager;

        [SerializeField]
        private CommandManager _commandManager;

        [SerializeField]
        private PlayerMovement _playerMovement;

        private void Awake()
        {
            _uiManager.CommandManager = _commandManager;
            _uiManager.PlayerMovement = _playerMovement;
        }
    }
}