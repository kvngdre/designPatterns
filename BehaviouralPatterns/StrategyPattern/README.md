# Strategy Pattern

The strategy pattern is used to create different classes which are a family of algorithms and make these objects interchangeable.

There are three actors in the strategy pattern you should be aware of:

- **The Context**: The context is the object that does the work but in different ways (strategies). The context object must have a field to store a reference to one of the strategies. The context is not responsible for selecting the most appropriate strategy, it simply accepts a strategy and calls a single method through a generic interface for triggering the algorithm execution.

- **The Strategy**: The strategy is an interface or abstract class that the concrete strategies must implement. it declares a method the context uses to execute a strategy.

- **The Concrete Strategy**: The concrete strategy implements the strategy interface or abstract class and defines it's own algorithm for the strategy execution.

> The strategy pattern looks very similar to the state pattern, both can be used to modify the state of an object. However, the key difference between the strategy pattern and the state pattern is **the state pattern changes the behaviour of the object by it's internal state, while the strategy pattern offers different algorithms for achieving the same task. The behaviour might not change but the way about achieving the task might.**.
