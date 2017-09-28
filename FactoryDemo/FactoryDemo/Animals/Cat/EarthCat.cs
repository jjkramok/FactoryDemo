namespace FactoryDemo.Animals.Cat
{
    public class EarthCat : Cat
    {
        public EarthCat(string name, double weight, string appearal) : base(name, weight, appearal)
        {
            _cry = "*meow*";
            Kind = "earth cat";
        }
        
        public override string ToString()
        {
            return Name + " is a " + Kind + " and has " + Appearal + " fur";
        }
    }
}