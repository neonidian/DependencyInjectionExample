using DependencyInjectionExample.ConstructorInjection.ServiceComponents;
using DependencyInjectionExample.ConstructorInjection.ServiceConsumers;

namespace DependencyInjectionExample.ConstructorInjection.Injectors
{
    public class TigerServiceInjector : IAnimalServiceInjector
    {
        public PetOrWildAnimal PetOrWildAnimal() => new PetOrWildAnimal(new Tiger());
        
        public AnimalSound AnimalSound() => new AnimalSound(new Tiger());
    }
}
