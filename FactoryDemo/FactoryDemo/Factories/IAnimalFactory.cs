using FactoryDemo.Animals.Cat;
using FactoryDemo.Animals.Dog;
using FactoryDemo.Animals.SeaUrchin;

namespace FactoryDemo.Factories
{
    public interface IAnimalFactory
    {
        Dog CreateDog(string name, double weight, string appearal);
        Cat CreateCat(string name, double weight, string appearal);
        SeaUrchin CreateSeaUrchin(string name, double weight, string appearal);
    }
}