using UnityEngine;
using UnityEngine.UI;

namespace CommandPattern
{
    public class UIManager : MonoBehaviour
    {
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

        public CommandManager CommandManager { get; set; }
        public PlayerMovement PlayerMovement { get; set; }

        private void Start()
        {
            _forwardButton.onClick.AddListener(() => CommandManager.ExecuteCommand(new MoveForwardCommand(PlayerMovement)));
            _backwardButton.onClick.AddListener(() => CommandManager.ExecuteCommand(new MoveBackwardCommand(PlayerMovement)));

            _rightButton.onClick.AddListener(() => CommandManager.ExecuteCommand(new MoveRightCommand(PlayerMovement)));
            _leftButton.onClick.AddListener(() => CommandManager.ExecuteCommand(new MoveLeftCommand(PlayerMovement)));

            _undoButton.onClick.AddListener(CommandManager.Undo);
            _redoButton.onClick.AddListener(CommandManager.Redo);
        }
    }
}