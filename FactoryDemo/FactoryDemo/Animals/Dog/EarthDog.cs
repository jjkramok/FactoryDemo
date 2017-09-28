namespace FactoryDemo.Animals.Dog
{
    public class EarthDog : Dog
    {
        public EarthDog(string name, double weight, string appearal) : base(name, weight, appearal)
        {
            _cry = "*woof*"; // TODO set Cry;
            Kind = "earth dog";
        }
    }
}