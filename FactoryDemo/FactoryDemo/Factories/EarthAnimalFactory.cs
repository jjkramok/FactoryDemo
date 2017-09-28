using FactoryDemo.Animals.Cat;
using FactoryDemo.Animals.Dog;
using FactoryDemo.Animals.SeaUrchin;

namespace FactoryDemo.Factories
{
    public class EarthAnimalFactory : IAnimalFactory
    {
        public Dog CreateDog(string name, double weight, string appearal)
        {
            return new EarthDog(name, weight, appearal);
        }

        public Cat CreateCat(string name, double weight, string appearal)
        {
            return new EarthCat(name, weight, appearal);
        }

        public SeaUrchin CreateSeaUrchin(string name, double weight, string appearal)
        {
            return new EarthSeaUrchin(name, weight, appearal);
        }
    }
}