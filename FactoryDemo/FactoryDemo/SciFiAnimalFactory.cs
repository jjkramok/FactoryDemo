﻿namespace FactoryDemo
{
    public class SciFiAnimalFactory : IAnimalFactory
    {
        public IDog CreateDog()
        {
            throw new System.NotImplementedException();
        }

        public ICat CreateCat()
        {
            throw new System.NotImplementedException();
        }

        public ISeaUrchin CreateSeaUrchin()
        {
            throw new System.NotImplementedException();
        }
    }
}