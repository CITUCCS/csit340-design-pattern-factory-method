using FactoryMethod.Animal.Factories;

namespace FactoryMethod
{
    public class MayorParkGenerator : ParkGenerator
    {
        public MayorParkGenerator() : base(new RandomAnimalFactory())
        {
        }
    }
}
