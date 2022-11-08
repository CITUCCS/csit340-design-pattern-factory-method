using FactoryMethod.Animal.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class ViceMayorParkGenerator : ParkGenerator
    {
        public ViceMayorParkGenerator() : base(new BirdFactory())
        {
        }
    }
}
