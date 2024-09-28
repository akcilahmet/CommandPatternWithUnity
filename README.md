# Command Pattern With Unity

This project demonstrates the use of the Command Pattern in Unity. The Command Pattern encapsulates requests as objects, allowing for parameterization of clients with queues, requests, and operations. It also supports undo and redo operations. This example showcases how to manage player movements and their undo functionality using this pattern.

## Watch
![Command_Pattern](https://github.com/user-attachments/assets/ae363de2-3f12-454a-a432-c6cfd720df03)

## UML Diagram
![Command_Pattern_UML](https://github.com/user-attachments/assets/165317a3-df80-42dc-ae4b-5588f5f9a04e)

## What is the Command Pattern?
The Command Pattern is a behavioral design pattern that turns a request into a stand-alone object, allowing the system to decouple the invoker of the request from the object that handles it. This pattern encapsulates actions or operations in separate command objects, which can then be executed, undone, or redone. The key benefit of the Command Pattern is its ability to manage actions in a flexible, reusable way, especially when commands need to be undone, queued, or logged.


## Benefits 
- **Undo/Redo Functionality:** The Command Pattern provides a built-in mechanism for undoing and redoing operations. By maintaining a stack of commands, it is easy to reverse or reapply actions.

- **Separation of Concerns:** The pattern decouples the object that sends a command from the object that performs the command. This allows for more modular code and makes it easier to maintain and extend.

- **Scalability:** New commands can be easily added without changing existing code, providing a highly scalable solution for handling different types of actions in a system.

- **Extensibility:** It allows us to implement complex functionalities like queuing, logging, or scheduling commands.
- 
## Project Structure
     
      
      ├── Scripts/
      │   ├── CommandManager.cs          # Manages command execution, undo, and redo.
      │   ├── GameBootstrapper.cs        # Initializes necessary components (UIManager, CommandManager).
      │   ├── PlayerMovement.cs          # Controls player movement.
      │   ├── UIManager.cs               # Handles UI interactions and binds commands to buttons.
      │   ├── Commands/
      │   │   ├── ICommand.cs            # Interface for command objects.
      │   │   ├── MoveBackwardCommand.cs # Command for moving the player backward.
      │   │   ├── MoveForwardCommand.cs  # Command for moving the player forward.
      │   │   ├── MoveLeftCommand.cs     # Command for moving the player left.
      │   │   └── MoveRightCommand.cs    # Command for moving the player right.

## Requirements
- Unity 2020.3 or later

## How to Use

1. Clone or Download the Unity Project:
   ```bash
   git clone https://github.com/your_username/your-repository.git

2. Open the project in Unity.
 
