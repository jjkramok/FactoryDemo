namespace FactoryDemo.Animals.SeaUrchin
{
    public class SciFiSeaUrchin : SeaUrchin
    {
        public SciFiSeaUrchin(string name, double weight, string appearal) : base(name, weight, appearal)
        {
            _cry = "*beep* *boop*";
            Kind = "sci-fi sea urchin";
        }
        
        public override string ToString()
        {
            return Name + " is a " + Kind + " and has " + Appearal + " plated spines";
        }
    }
}