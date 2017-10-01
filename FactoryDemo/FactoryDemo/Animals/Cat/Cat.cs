namespace FactoryDemo.Animals.Cat
{
    public abstract class Cat : Animal
    {
        public new string Name = "Unnamed Cat";
        public new string Kind = "cat";

        protected Cat(string name, double weight, string appearal) : base(name, weight, appearal)
        {
            Name = name;
            Weight = weight;
            Appearal = appearal.Equals("") ? "nondescript" : appearal;
        }
    }
}