namespace FactoryDemo
{
    public class SciFiAnimalFactory : IAnimalFactory
    {
        public Dog CreateDog()
        {
            throw new System.NotImplementedException();
        }

        public Cat CreateCat()
        {
            throw new System.NotImplementedException();
        }

        public SeaUrchin CreateSeaUrchin()
        {
            throw new System.NotImplementedException();
        }
    }
}