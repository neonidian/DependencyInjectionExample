using DependencyInjectionExample.ConstructorInjection.ServiceComponents;

namespace DependencyInjectionExample.ConstructorInjection.ServiceConsumers
{
    public class PetOrWildAnimal
    {
        private readonly IAnimal _animal;

        public PetOrWildAnimal(IAnimal animal)
        {
            _animal = animal;
        }

        public string PrintPetOrWildAnimal()
        {
            string nameOfAnimal = _animal.NameOfAnimal();
            string petOrWildAnimal = _animal.IsPetAnimal() ? "pet" : "wild";

            return ($"The '{nameOfAnimal}' is a {petOrWildAnimal} animal.");
        }
    }
}
