namespace FactoryDemo.Animals.SeaUrchin
{
    public abstract class SeaUrchin : Animal
    {
        public new string Name = "Unnamed Sea Urchin";
        public new string Kind = "sea urchin";

        protected SeaUrchin(string name, double weight, string appearal) : base(name, weight, appearal)
        {
            Name = name;
            Weight = weight;
            Appearal = appearal.Equals("") ? "nondescript" : appearal;
        }
        
        public override string ToString()
        {
            return Name + " is " + GrammarFix(Kind) + Kind + " and has " + Appearal + " spines";
        }
    }
}