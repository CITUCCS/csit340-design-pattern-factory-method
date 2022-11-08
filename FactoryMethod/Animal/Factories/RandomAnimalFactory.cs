using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Animal.Factories
{
    public class RandomAnimalFactory : IAnimalFactory
    {
        private readonly Random _random = new Random();
        public IAnimal GenerateAnimal()
        {
            IAnimal animal;

            var rInt = _random.Next(0, 3);

            switch (rInt)
            {
                case 0:
                    animal = new Cow();
                    break;
                case 1:
                    animal = new Bird();
                    break;
                case 2:
                    animal = new Snake();
                    break;
                default:
                    animal = new Cow();
                    break;
            }

            return animal;
        }
    }
}
