using DependencyInjectionExample.ConstructorInjection.ServiceComponents;

namespace DependencyInjectionExample.ConstructorInjection.ServiceConsumers
{
    public class AnimalSound
    {
        private readonly IAnimal _animal;

        public AnimalSound(IAnimal animal)
        {
            _animal = animal;
        }

        public string SoundFromAnimal() => $"The animal makes a sound - '{_animal.Sound()}'";
    }
}
