using DependencyInjectionExample.ConstructorInjection.ServiceComponents;
using DependencyInjectionExample.ConstructorInjection.ServiceConsumers;

namespace DependencyInjectionExample.ConstructorInjection.Injectors
{
    public class CatServiceInjector : IAnimalServiceInjector
    {
        public PetOrWildAnimal PetOrWildAnimal() => new PetOrWildAnimal(new Cat());
        public AnimalSound AnimalSound() => new AnimalSound(new Cat());
    }
}
