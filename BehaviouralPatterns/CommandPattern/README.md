# Command Pattern

Command pattern allows us to make an object a request, encapsulating all it requires to perform a task. It helps decouple the invoker of a request (command) from the receiver of a request.

There are five actors you need to be aware of in the command pattern:

- **`The Invoker`**: This is the sender of the request (command). It has a field that holds the reference of the command, and triggers that command by calling an execute method on it. The invoker is not responsible for creating these commands it simple triggers them.

- **`The Command`**: This is an interface which usually declares a single method for executing the command.

- **`The Concrete Command`**: The concrete command is an object that implements the command interface. Usually this takes in the receiver via the constructor and delegates the task of executing the command to the receiver. Parameters required to execute the command are stored as private fields and the concrete command can be made immutable by passing the receiver and any other parameters that may be required via the constructor.

- **`The Receiver`**: This is the object that would receive the command. I like to this of it as the object that the command would act upon. Some commands only handle the details of how the request is passed to the receiver while the receiver does the actual work. The receiver usually contains the business logic for fulfilling that command.

- **`The Client`**: This is the orchestrator, it is responsible for creating the commands and passing it unto the invoker/sender. It is passes all the command would require including the receiver and any other parameters.

❗Bonus is the **_The History_**: This is an object that stores all commands that have been executed. It is useful if you wish to implement an undo or redo mechanism. it holds a field for the list of commands executed and exposes two methods **push** and **pop**.
