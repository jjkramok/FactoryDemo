namespace FactoryDemo.Animals.Cat
{
    public class EarthCat : Cat
    {
        public EarthCat(string name, double weight, string appearal) : base(name, weight, appearal)
        {
            _cry = "*meow*"; // TODO set Cry;
            Kind = "earth cat";
        }
    }
}