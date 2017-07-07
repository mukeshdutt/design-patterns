**Adapter Design Pattern**
Adapter pattern has four main key component those are Target, Adapter, Adaptee and Client.

**Target**
This is an interface which is used by the client to achieve its functionality/request.

**Adapter**
This is a class which implements the ITarget interface and inherits the Adaptee class. It is responsible for communication between Client and Adaptee.

**Adaptee**
This is a class which have the functionality, required by the client. However, its interface is not compatible with the client.

**Client**
This is a class which interact with a type that implements the ITarget interface. However, the communication class called adaptee, is not compatible with the client

**When to use Adapter Pattern**
When you have a third-party code that cannot interact with the client code. For example, you might want to use a third-party logger service, but your code is having incompatibility issues, you can use this pattern.
When you want to use an existing code with extended functionality but not without changing it, as it is being used in other components, you can extend it using the adapter pattern.

**Example**
When we talk about this pattern we can take an example of logging in application there are lots of frameworks so now you choose one of them and in future you may use another (for more features) then you have to change all code what previously written so for that what we do, In that case, we can use adapter pattern. Logging frameworks will be implemented by adapter class and that will be used by the main layer of your application so if in future if you want to use another logging framework you just change in adapter class.