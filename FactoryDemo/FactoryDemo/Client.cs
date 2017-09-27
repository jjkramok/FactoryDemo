using System.Collections.Generic;
using FactoryDemo.Animals;

namespace FactoryDemo
{
    public class Client
    {
        private List<Animal> _animals;

        public Client()
        {
            _animals = new List<Animal>();
            // Randomly generate some animals for the shop
        }
    }
}