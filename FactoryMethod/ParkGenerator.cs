using FactoryMethod.Animal.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class ParkGenerator
    {
        protected readonly IAnimalFactory _animalFactory;
        protected const int ParkAnimalLimit = 10;
        protected ParkGenerator(IAnimalFactory animalFactory)
        {
            _animalFactory = animalFactory;
        }

        public void Generate()
        {
            Console.WriteLine("Generating park...");

            var numAnimals = 0;
            while (numAnimals < ParkAnimalLimit)
            {
                var animal = _animalFactory.GenerateAnimal();
                Console.WriteLine(animal.Render());

                numAnimals++;
            }
        }
    }
}
