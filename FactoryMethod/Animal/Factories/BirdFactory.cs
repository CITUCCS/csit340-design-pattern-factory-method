using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Animal.Factories
{
    public class BirdFactory : IAnimalFactory
    {
        public IAnimal GenerateAnimal() => new Bird();
    }
}
