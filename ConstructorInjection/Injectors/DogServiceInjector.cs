using DependencyInjectionExample.ConstructorInjection.ServiceComponents;
using DependencyInjectionExample.ConstructorInjection.ServiceConsumers;

namespace DependencyInjectionExample.ConstructorInjection.Injectors
{
    public class DogServiceInjector : IAnimalServiceInjector
    {
        public PetOrWildAnimal PetOrWildAnimal() => new PetOrWildAnimal(new Dog());
        
        public AnimalSound AnimalSound() => new AnimalSound(new Dog());
    }
}
