namespace FactoryDemo
{
    public abstract class Cat
    {
        public string Name = "Unnamed Cat";
        public double Weight;
        public string Appearal;
        public string Cry;
        public string Kind = "cat";

        public override string ToString()
        {
            return Name + " is a " + Kind + " and has " + " fur";
        }
    }
}