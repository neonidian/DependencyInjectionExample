# Constructor Injection

1. In Constructor injection technique, the dependencies are supplied by [injector classes](Injectors) to the [client](../Program.cs)(Program.cs)
2. The injector classes uses the constructor of [service consumer](ServiceConsumers/) class to decide which [service component](ServiceComponents/) is to be used. So, the 
dependencies are provided which is the dependency injection design pattern.
3. The service consumer class consumes the service component classes to process data from them.
4. An injector class is created for every service component

### Advantages

1. The service component classes are independent and new service component classes can be added without breaking other parts of the code. 
   E.g., Adding a new class, Lion.cs in ServiceComponents directory
2. Multiple service consumer classes can be added that can manipulate data from service components classes
3. Removing or deleting a service component is easier
