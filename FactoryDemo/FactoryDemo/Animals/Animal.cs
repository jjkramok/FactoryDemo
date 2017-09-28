namespace FactoryDemo.Animals
{
    public abstract class Animal
    {
        public string Name = "Unnamed Animal";
        public double Weight;
        public string Appearal;
        protected string _cry { get; set; }
        public string Kind;
        
        protected Animal(string name, double weight, string appearal)
        {
            Name = name;
            Weight = weight;
            Appearal = appearal;
        }
        
        public string Cry()
        {
            return _cry;
        }
        
        public override string ToString()
        {
            return Name + " is a " + Kind + " and has " + Appearal + " fur";
        }
    }
}