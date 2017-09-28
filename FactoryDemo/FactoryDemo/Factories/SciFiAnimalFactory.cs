using FactoryDemo.Animals.Cat;
using FactoryDemo.Animals.Dog;
using FactoryDemo.Animals.SeaUrchin;

namespace FactoryDemo.Factories
{
    public class SciFiAnimalFactory : IAnimalFactory
    {
        public Dog CreateDog(string name, double weight, string appearal)
        {
            return new SciFiDog(name, weight, appearal);
        }

        public Cat CreateCat(string name, double weight, string appearal)
        {
            return new SciFiCat(name, weight, appearal);
        }

        public SeaUrchin CreateSeaUrchin(string name, double weight, string appearal)
        {
            return new SciFiSeaUrchin(name, weight, appearal);
        }
    }
}