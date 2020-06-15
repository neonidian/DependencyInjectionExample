namespace DependencyInjectionExample.ConstructorInjection.ServiceComponents
{
    sealed class Dog : IAnimal
    {
        public bool IsPetAnimal() => true;

        public string Sound() => "bark";
    }
}
