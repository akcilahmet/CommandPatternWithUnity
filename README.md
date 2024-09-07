# CommandPatternWithUnity

This project demonstrates the use of the Command Pattern in Unity. The Command Pattern encapsulates requests as objects, allowing for parameterization of clients with queues, requests, and operations. It also supports undo and redo operations. This example showcases how to manage player movements and their undo functionality using this pattern.

## Features

- **Command Execution**: Commands to move the player forward, backward, right, and left.
- **Undo and Redo**: Functionality to undo and redo executed commands.
- **UI Integration**: Trigger commands using UI buttons.

## Project Structure

- **CommandManager**: Manages command execution, undo, and redo operations.
- **ICommand**: An interface for command implementations.
- **MoveForwardCommand**, **MoveBackwardCommand**, **MoveLeftCommand**, **MoveRightCommand**: Commands to control player movements.
- **PlayerMovement**: Handles player movement logic.
- **UIManager**: Connects UI buttons to commands and communicates with `CommandManager`.
- **GameBootstrapper**: Initializes and links components.

## How to Use

1. Clone or Download the Unity Project:
   ```bash
   git clone https://github.com/your_username/command-pattern-example.git

2. Open the project in Unity.
 
