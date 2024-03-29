# Template Method Pattern

This is a behavioural design pattern that defines tha skeleton of an algorithm in the superclass and allows the subclasses to change some steps in the algorithm without changing the structure.

> 🤔 At some point, you noticed that some classes have a lot of similar code. While the code for dealing with various data formats was entirely different in all classes, the code for data processing and analysis is almost identical. Wouldn’t it be great to get rid of the code duplication, leaving the algorithm structure intact?

The Template Method pattern suggests that you break down an algorithm into a series of steps, turn these steps into methods, and put a series of calls to these methods inside a single template method.

There are two actors in the template method pattern you should be aware of:

- **The Super class**: This is an abstract class that declares an execute method for the algorithm but also calls an abstract method called _primitive operation_. The primitive operation will be implemented by the subclasses. In my implementation, the super class is the Task class.

- **The Sub Classes**: The subclasses extend the abstract super class and implement the primitive operation methods which would be called in the execute method of defined in the abstract class. This allows each subclass to tweak the execute method by supplying different implementations of the primitive operation. In my implementation, the sub class is the TransferMoney Class and the PrintReport class.

> 💡There’s another type of step, called `hooks`. A hook is an optional step with an empty body. A template method would work even if a hook isn’t overridden. Usually, hooks are placed before and after crucial steps of algorithms, providing subclasses with additional extension points for an algorithm..
