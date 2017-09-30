namespace FactoryDemo.Animals.Cat
{
    public class SciFiCat : Cat
    {
        public SciFiCat(string name, double weight, string appearal) : base(name, weight, appearal)
        {
            _cry = "*beep* *boop*";
            Kind = "sci-fi cat";
        }
        
        public override string ToString()
        {
            return Name + " is " + GrammarFix(Kind) + Kind + " and has " + Appearal + " plating";
        }
    }
}