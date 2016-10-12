using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1Del1
{
    class Runtime
    {
        public void Start()
        {
            Dog dog1 = new Dog
            {
                Name = "göran",
                Age = 10,
                Breed = "Labrador"
            };
            Dog dog2 = new Dog
            {
                Name = "spartacus",
                Age = 2,
                Breed = "Chihuahua"
            };
            Dog dog3 = new Dog
            {
                Name = "Kexet",
                Age = 3,
                Breed = "mastiff"
            };
            List<Dog> dogs = new List<Dog>()
            {
                dog1,
                dog2,
                dog3
            };
            foreach (var dog in dogs)
            {
                Console.WriteLine(dog.Name + " " + dog.Age + " " + dog.Breed);
            }
            bool loop = false;
            do
            {
                loop = false;
                Console.WriteLine("Welcome to our dogcollection");
                Console.WriteLine("----------------------------");
                Console.WriteLine("1. Add new dog");
                Console.WriteLine("2. Remove dog");
                Console.WriteLine("3. Show info");
                Console.WriteLine("4. Exit");
                var input = Console.ReadKey();

                switch (input)
                {
                    case 1:
                        Console.WriteLine("Dogs Name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Dogs Age");
                        int Age = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dogs breed");
                        string breed = Console.ReadLine();

                    default:
                        break;
                }
                case ConsoleKey.Y:
                Console.WriteLine(newDog.Introduction());

                

            } while (true);
        }

    }
}
