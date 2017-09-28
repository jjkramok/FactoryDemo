namespace FactoryDemo.Animals.Dog
{
    public class EarthDog : Dog
    {
        public EarthDog(string name, double weight, string appearal) : base(name, weight, appearal)
        {
            _cry = "*woof*";
            Kind = "earth dog";
        }
        
        public override string ToString()
        {
            return Name + " is a " + Kind + " and has " + Appearal + " fur";
        }
    }
}