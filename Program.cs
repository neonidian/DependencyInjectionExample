using System;
using DependencyInjectionExample.ConstructorInjection.Injectors;
using DependencyInjectionExample.ConstructorInjection.ServiceConsumers;

namespace DependencyInjectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ConstructorInjection();
        }

        private static void ConstructorInjection()
        {
            IAnimalServiceInjector animalServiceInjector;
            IAnimalConsumer animalConsumer;

            // Dog
            animalServiceInjector = new DogServiceInjector();
            animalConsumer = animalServiceInjector.GetAnimalConsumer();
            Console.WriteLine(animalConsumer.AnimalCharacteristics());

            // Tiger
            animalServiceInjector = new TigerServiceInjector();
            animalConsumer = animalServiceInjector.GetAnimalConsumer();
            Console.WriteLine(animalConsumer.AnimalCharacteristics());

            // Cat
            animalServiceInjector = new CatServiceInjector();
            animalConsumer = animalServiceInjector.GetAnimalConsumer();
            Console.WriteLine(animalConsumer.AnimalCharacteristics());
        }
    }
}
