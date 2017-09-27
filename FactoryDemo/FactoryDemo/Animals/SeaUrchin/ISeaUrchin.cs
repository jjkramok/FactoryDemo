namespace FactoryDemo
{
    public abstract class SeaUrchin
    {
        public string Name = "Unnamed Sea Urchin";
        public double Weight;
        public string Appearal;
        public string Cry;
        public string Kind = "sea urchin";

        public override string ToString()
        {
            return Name + " is a " + Kind + " and has " + " spines";
        }
    }
}