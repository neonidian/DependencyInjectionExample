using DependencyInjectionExample.ConstructorInjection.ServiceConsumers;

namespace DependencyInjectionExample.ConstructorInjection.Injectors
{
    public interface IAnimalServiceInjector
    {
        IAnimalConsumer GetAnimalConsumer();
    }
}
