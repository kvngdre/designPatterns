# Template Method Pattern

This is a behavioural design pattern that defines tha skeleton of an algorithm in the superclass and allows the subclasses to change some steps in the algorithm without changing the structure.

There are two actors in the template method pattern you should be aware of:

- **The Super class**: This is an abstract class that declares an execute method for the algorithm but also calls an abstract method called _primitive operation_. The primitive operation will be implemented by the subclasses.

- **The Sub Classes**: The subclasses extend the abstract super class and implement the primitive operation methods which would be called in the execute method of defined in the abstract class. This allows each subclass to tweak the execute method by supplying different implementations of the primitive operation.
