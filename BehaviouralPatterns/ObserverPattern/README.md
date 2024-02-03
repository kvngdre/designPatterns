# Observer Pattern

Also known as the **Publisher/Subscriber Pattern**. The observer pattern is a software design pattern where we have multiple objects (observers/subscribers) that are interested and need to be notified whenever their is a change in the state of a concrete subject (publisher) class or in simpler terms, a change in the interested state of the object they are observing.

It’s crucial that all subscribers implement the same interface and that the publisher communicates with them only via that interface. This interface should declare the notification method along with a set of parameters that the publisher can use to pass some contextual data along with the notification.

There are **four** actors you need to be aware of in the observer pattern:

- **`The Subject`**: This is a class where we handle the business of attaching, detaching, and notifying observers of changes. It exposes methods for new subscribers to join, old subscribers to join and a mechanism to notify subscribers of a particular event.

- **`The Concrete Subject`**: Also known as the Publisher, is a class that extends the abstract subject class and has field(s) that the observers are interested to know about. The publisher publishes an event when there is a change in it's state or executes some behaviour.

- **`The Observer`**: This is an interface or abstract class with a method for handling the action when change in the subject has been received. The method is usually called _update_ which might have other parameters about the event that occurred as passed by the publisher.

- **`The Concrete Observer`**: This is a class that implements/extends the observer. The business logic for handling the event of a subject value's change is defined in the implemented method.
