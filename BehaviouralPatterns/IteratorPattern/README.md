# Iterator Pattern

If the collection used for data storage is a list, we would have to write code specific to the methods the List class provides for accessing it's elements. Say tomorrow, we need to switch from a list to a fixed size array, this would introduce breaking changes everywhere in our application where the collection was used.

The Iterator pattern helps fix this problem by enabling us decouple from the specific collection class. It does this by providing an Iterator interface which the concrete iterator class would implement and this concrete Iterator class know how to iterate over the specific collection is was implemented for, example ListIterator, ArrayIterator etc.

There are three actors you should now in order to implement the iterator pattern:

- **The Client**: This is the class that needs to provide access to it's private collection by providing an iterator for it's consumers.

- **The Iterator Interface**: The iterator interface declares methods that the concrete collection iterators are required to implement in order to provide access to it's collection elements and traversing them. Fetching the next element, checking if there are any elements left in the collection, and retrieving the current position.

- **The Concrete Collection Iterator class**: The concrete Collection Iterator is the class that implements the iterator interface. This class is specialized in iterating over its specific collection type. The concrete iterator class is responsible for tracking it's own progress while traversing the collection. It holds the collection it would traverse as a private field usually passed via the constructor.
