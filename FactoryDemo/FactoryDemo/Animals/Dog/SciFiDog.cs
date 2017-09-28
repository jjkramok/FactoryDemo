namespace FactoryDemo.Animals.Dog
{
    public class SciFiDog : Dog
    {
        public SciFiDog(string name, double weight, string appearal) : base(name, weight, appearal)
        {
            _cry = "*beep* *boop*";
            Kind = "sci-fi dog";
        }
    }
}