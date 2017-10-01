﻿namespace FactoryDemo.Animals.Dog
{
    public abstract class Dog : Animal
    {
        public new string Name = "Unnamed Dog";
        public new string Kind = "dog";

        protected Dog(string name, double weight, string appearal) : base(name, weight, appearal)
        {
            Name = name;
            Weight = weight;
            Appearal = appearal.Equals("") ? "nondescript" : appearal;
        }
    }
}