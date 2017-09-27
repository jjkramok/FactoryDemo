namespace FactoryDemo
{
    public class EarthAnimalFactory : IAnimalFactory
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