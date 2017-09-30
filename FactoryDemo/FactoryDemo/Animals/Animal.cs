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

        // Returns correct article based on the first letter of given string
        public static string GrammarFix(string kind)
        {
            return "aeiouAEIOU".IndexOf(kind[0]) >= 0 ? "an " : "a ";
        }
        
        public override string ToString()
        {
            return Name + " is " + GrammarFix(Kind) + Kind + " and has " + Appearal + " fur";
        }
    }
}