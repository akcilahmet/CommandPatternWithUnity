using UnityEngine;
using UnityEngine.UI;

namespace CommandPattern
{
    public class UIManager : MonoBehaviour
    {
        private CommandManager _commandManager;
        private PlayerMovement _playerMovement;
        
        [SerializeField]
        private Button _forwardButton;

        [SerializeField]
        private Button _backwardButton;

        [SerializeField]
        private Button _rightButton;

        [SerializeField]
        private Button _leftButton;

        [SerializeField]
        private Button _undoButton;

        [SerializeField]
        private Button _redoButton;
        

        public void Initialize(CommandManager commandManager, PlayerMovement playerMovement)
        {
            _commandManager = commandManager;
            _playerMovement = playerMovement;
        }
        private void Start()
        {
            _forwardButton.onClick.AddListener(() =>
                _commandManager.ExecuteCommand(new MoveForwardCommand(_playerMovement)));
            _backwardButton.onClick.AddListener(() =>
                _commandManager.ExecuteCommand(new MoveBackwardCommand(_playerMovement)));

            _rightButton.onClick.AddListener(() => _commandManager.ExecuteCommand(new MoveRightCommand(_playerMovement)));
            _leftButton.onClick.AddListener(() => _commandManager.ExecuteCommand(new MoveLeftCommand(_playerMovement)));

            _undoButton.onClick.AddListener(_commandManager.Undo);
            _redoButton.onClick.AddListener(_commandManager.Redo);
        }
    }
}