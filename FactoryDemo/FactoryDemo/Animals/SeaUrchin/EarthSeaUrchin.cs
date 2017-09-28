namespace FactoryDemo.Animals.SeaUrchin
{
    public class EarthSeaUrchin : SeaUrchin
    {
        public EarthSeaUrchin(string name, double weight, string appearal) : base(name, weight, appearal)
        {
            _cry = "* *";
            Kind = "earth sea urchin";
        }
        
        public override string ToString()
        {
            return Name + " is a " + Kind + " and has " + Appearal + " spines";
        }
    }
}