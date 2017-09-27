namespace FactoryDemo
{
    public class EarthAnimalFactory : IAnimalFactory
    {
        public IDog CreateDog()
        {
            return null;
        }

        public ICat CreateCat()
        {
            return null;
        }

        public ISeaUrchin CreateSeaUrchin()
        {
            return null;
        }
    }
}