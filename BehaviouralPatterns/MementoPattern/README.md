# Memento Pattern

The Memento Pattern is used to restore the previous state of an object. This pattern is used to implement _undo_ mechanism.

There are three actors in the Memento Design Pattern you should be aware of: the **originator**, the **memento**, and the **caretaker**.

- **The Originator**: This is the class that need it's state to be stored. It calls a method on it's self called `createMemento` or `createState` or whatever else you would like to call it to create the memento and has a dependency on the Memento class.
- **The Memento**: This is a value object that holds the state of the originator. It has the same fields as the originator and is used to take a snapshot of the current state of the originator. Usually, the fields in the Memento are immutable and the data is only past to it through the constructor.
- **The Caretaker**: This is the class that is responsible for holding a history of mementos. It would have a field called `states` or whatever else you might want to call it, I like to use a stack as the data structure as opposed to using a list.

In my implementation, the originator is the `Editor` class, the memento is the `EditorState` class, and the Caretaker is the `History` class.

> 💡 Use the memento pattern when you wish to store snapshots of the object state to be saved and later restored. While we cab use _undo_ to remember this pattern, we can also use it for transactions. We save a snapshot of the objects state and if the transactions fails, we roll back i.e. restore it's previous state.
