using FactoryMethod;
using FactoryMethod.Animal.Factories;

ParkGenerator pg = new MayorParkGenerator();
Console.WriteLine("Mayor---");
pg.Generate();

pg = new ViceMayorParkGenerator();
Console.WriteLine("Vice Mayor---");
pg.Generate();
