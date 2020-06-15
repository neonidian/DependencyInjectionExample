using DependencyInjectionExample.ConstructorInjection.ServiceComponents;

namespace DependencyInjectionExample.ConstructorInjection.ServiceConsumers
{
    public class PetOrWildAnimal : IAnimalConsumer
    {
        private readonly IAnimal _animal;

        public PetOrWildAnimal(IAnimal animal)
        {
            _animal = animal;
        }

        public string AnimalCharacteristics()
        {
            string nameOfAnimal = _animal.NameOfAnimal();
            string sound = _animal.Sound();
            string isPetOrWildAnimal = _animal.IsPetAnimal() ? "pet" : "wild";

            return ($"The '{nameOfAnimal}' is a {isPetOrWildAnimal} animal and makes a sound - {sound}");
        }
    }
}
