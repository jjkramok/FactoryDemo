namespace FactoryDemo
{
    public interface IAnimalFactory
    {
        IDog CreateDog();
        ICat CreateCat();
        ISeaUrchin CreateSeaUrchin();
    }
}