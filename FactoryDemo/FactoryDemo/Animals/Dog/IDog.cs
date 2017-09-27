namespace FactoryDemo
{
    public abstract class Dog
    {
        public string Name = "Unnamed Dog";
        public double Weight;
        public string Appearal;
        public string Cry;
        public string Kind = "dog";

        public override string ToString()
        {
            return Name + " is a " + Kind + " and has " + " fur";
        }
    }
}