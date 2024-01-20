# State Pattern

The state pattern allows an object to behave differently when it's internal state changes. The state pattern suggests you create new classes for all possible states of an object and extract all state specific behaviour to those classes.

There are three actors you should remember in the state pattern: the **context**, the **state** and the **concrete state** objects.

- **Context**: The Context is the class which should behave differently when it's internal state changes. Instead of the Context class implementing all the state behaviours, it holds a reference to a concrete state object that represents it's current state and delegates all state-related tasks to this object. The Context class interacts with the concrete state object via the state interface. The context exposes a setter for passing it a new concrete state object.

- **State**: The State class is an abstract class or interface with an abstract method(s) handle. The Concrete State class(es) will implement this abstract method(s). The methods in the state object should make sense for all possible states of the context as we would not want the concrete state objects to have to implement useless method(s) that would never be called or are not relevant to that state.

- **Concrete State**: The Concrete State class is a class that extends the State abstract class and implements the handle method(s). The Concrete State class represents a valid state that the context object can be in and would cause the context object to behave differently when it's handle method(s) is/are called in the context object.
