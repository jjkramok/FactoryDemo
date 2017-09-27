namespace FactoryDemo
{
    public interface IAnimalFactory
    {
        Dog CreateDog();
        Cat CreateCat();
        SeaUrchin CreateSeaUrchin();
    }
}