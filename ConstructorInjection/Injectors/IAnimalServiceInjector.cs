using DependencyInjectionExample.ConstructorInjection.ServiceConsumers;

namespace DependencyInjectionExample.ConstructorInjection.Injectors
{
    public interface IAnimalServiceInjector
    {
        PetOrWildAnimal AnimalConsumer();
    }
}
