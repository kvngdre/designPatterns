# Memento Pattern

The Memento Pattern is used to restore the previous state of an object. This pattern is used to implement _undo_ mechanism.

There are three actors in the Memento Design Pattern you should be aware of:

- **The Originator**: This is the class that need it's state to be stored. It calls a method on it's self called `createMemento` or `createState` or whatever else you would like to call it to create the memento and has a dependency on the Memento class.
- **The Memento**: This is a value object that holds the state of the originator. It has the same fields as the originator and is used to take a snapshot of the current state of the originator. Usually, the fields in the Memento are immutable and the data is only past to it through the constructor.
- **The Caretaker**: This is the class that is responsible for holding a history of mementos. It would have a field called `states` or whatever else you might want to call it, I like to use a stack as the data structure as opposed to using a list.

In my implementation, the originator is the `Editor` class, the memento is the `EditorState` class, and the Caretaker is the `History` class.
