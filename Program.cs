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
            PetOrWildAnimal petOrWildAnimal;
            AnimalSound animalSound;
            
            Console.WriteLine("------------CONSTRUCTOR INJECTION------------");
            // Dog
            animalServiceInjector = new DogServiceInjector();
            petOrWildAnimal = animalServiceInjector.PetOrWildAnimal();
            animalSound = animalServiceInjector.AnimalSound();
            Console.WriteLine(petOrWildAnimal.PrintPetOrWildAnimal() + " " + animalSound.SoundFromAnimal());

            // Tiger
            animalServiceInjector = new TigerServiceInjector();
            petOrWildAnimal = animalServiceInjector.PetOrWildAnimal();
            animalSound = animalServiceInjector.AnimalSound();
            Console.WriteLine(petOrWildAnimal.PrintPetOrWildAnimal() + " " + animalSound.SoundFromAnimal());

            // Cat
            animalServiceInjector = new CatServiceInjector();
            petOrWildAnimal = animalServiceInjector.PetOrWildAnimal();
            animalSound = animalServiceInjector.AnimalSound();
            Console.WriteLine(petOrWildAnimal.PrintPetOrWildAnimal() + " " + animalSound.SoundFromAnimal());
            
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();
        }
    }
}
