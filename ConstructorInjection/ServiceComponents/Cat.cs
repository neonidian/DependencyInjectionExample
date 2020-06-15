namespace DependencyInjectionExample.ConstructorInjection.ServiceComponents
{
    sealed class Cat : IAnimal
    {
        public bool IsPetAnimal() => true;

        public string Sound() => "purr";
    }
}
