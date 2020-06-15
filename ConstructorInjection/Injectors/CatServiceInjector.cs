using DependencyInjectionExample.ConstructorInjection.ServiceComponents;
using DependencyInjectionExample.ConstructorInjection.ServiceConsumers;

namespace DependencyInjectionExample.ConstructorInjection.Injectors
{
    public class CatServiceInjector : IAnimalServiceInjector
    {
        public PetOrWildAnimal AnimalConsumer() => new PetOrWildAnimal(new Cat());
    }
}
