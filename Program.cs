using System;
using System.Collections.Generic;

namespace AnimalSounds
{
    class Program
    {
        static void Main(string[] args)
        {
            //Codul pune mai multe animale într-o listă, toate mostenind clasa animal si putand sa scoata sunete.
            //Arată cum un leu vânează, obosește și își schimbă sunetul, iar la final, toate animalele se odihnesc și își schimbă sunetul după ce se odihnesc.
            var animals = new List<Animal>
            {
                new Dog(),
                new Cat(),
                new Cow(),
                new Sheep(),
                new Duck(),
                new Lion() // Demonstrates method overriding
            };

            var lion = new Lion();
            Console.WriteLine("Initial lion sound:");
            Console.WriteLine($"{lion.GetName()} says: {lion.GetSound()}");

            Console.WriteLine("\nLion hunts and rests:");
            lion.Hunt();
            Console.WriteLine($"{lion.GetName()} says: {lion.GetSound()}");
            lion.Rest();
            Console.WriteLine($"{lion.GetName()} rested and now says: {lion.GetSound()}");

            Console.WriteLine("\nMaking animals tired:");
            foreach (var animal in animals)
            {
                Console.WriteLine($"\n{animal.GetName()}:");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Sound {i + 1}: {animal.GetSound()}");//string interpolation, incepe numaratoarea de la 1
                }
                
                animal.Rest();
                Console.WriteLine($"After resting: {animal.GetSound()}");
            }
        }
    }
}