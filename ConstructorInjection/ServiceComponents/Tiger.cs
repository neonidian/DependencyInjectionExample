namespace DependencyInjectionExample.ConstructorInjection.ServiceComponents
{
    sealed class Tiger : IAnimal
    {
        public bool IsPetAnimal() => false;

        public string Sound() => "growl";
    }
}
