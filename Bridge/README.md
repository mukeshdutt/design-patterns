
***Abstraction***
This is an abstract class and containing members that define an abstract business object and its functionality. It contains a reference to an object of type Bridge. It can also acts as the base class for other abstractions.

***Redefined Abstraction***
This is a class which inherits from the Abstraction class. It extends the interface defined by Abstraction class.

***Bridge***
This is an interface which acts as a bridge between the abstraction class and implementer classes and also makes the functionality of implementer class independent from the abstraction class.

***ImplementationA & ImplementationB***
These are classes which implement the Bridge interface and also provide the implementation details for the associated Abstraction class.

***Defination***
1. In the bridge pattern there are 2 parts - first is an abstraction, and second is implementation. The bridge design pattern allows the abstraction and implementation to be developed independently, and the client code can access only the abstraction part without being concerned about the implementation part.

2. Bridge pattern separates the abstraction hierarchy and implementation hierarchy in two different layers so that change in one hierarchy will not affect the development or functionality of the other hierarchy.