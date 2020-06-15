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
            PetOrWildAnimal animalConsumer;

            Console.WriteLine("------------CONSTRUCTOR INJECTION------------");
            // Dog
            animalServiceInjector = new DogServiceInjector();
            animalConsumer = animalServiceInjector.AnimalConsumer();
            Console.WriteLine(animalConsumer.AnimalCharacteristics());

            // Tiger
            animalServiceInjector = new TigerServiceInjector();
            animalConsumer = animalServiceInjector.AnimalConsumer();
            Console.WriteLine(animalConsumer.AnimalCharacteristics());

            // Cat
            animalServiceInjector = new CatServiceInjector();
            animalConsumer = animalServiceInjector.AnimalConsumer();
            Console.WriteLine(animalConsumer.AnimalCharacteristics());
            
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();
        }
    }
}
