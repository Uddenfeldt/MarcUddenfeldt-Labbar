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
    }

    }
}
