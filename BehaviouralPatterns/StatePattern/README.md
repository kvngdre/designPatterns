# State Pattern

The state pattern allows an object to behave differently when it's internal state changes.

There are three actors you should remember in the state pattern:

- **Context**: The Context is the class which should behave differently when it's internal state changes. The Context class usually has a method called request that behaves differently when called depending on the state of the class.

- **State**: The State class is an abstract class with an abstract method handle. Child class will implement this abstract method.

- **Concrete State**: The Concrete State class is a class that extends the State abstract class and implements the handle method. The Concrete State class represents a valid state that the context object can be in and would cause the context object to behave differently when it's handle method is called in the request method of the context class.
