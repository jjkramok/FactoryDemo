using System;
using FactoryDemo.Animals;
using FactoryDemo.Factories;

namespace FactoryDemo
{
    public class TestAnimals
    {
        public static void Test()
        {
            IAnimalFactory earthBreeder = new EarthAnimalFactory();
            IAnimalFactory plutoBreeder = new SciFiAnimalFactory();
            Animal hond = earthBreeder.CreateDog("Brutus", 25, "brown with white spotted");
            Animal k9 = plutoBreeder.CreateDog("K-9", 250, "glinstering metal");
            Console.WriteLine(hond);
            Console.WriteLine(hond.Cry());
            Console.WriteLine(k9);
            Console.WriteLine(k9.Cry());
			
            Animal kat = earthBreeder.CreateCat("Reinier", 10, "red with dark brown spotted");
            Animal eKat = plutoBreeder.CreateCat("KC-94F", 180, "sparkling metal");
            Console.WriteLine(kat);
            Console.WriteLine(kat.Cry());
            Console.WriteLine(eKat);
            Console.WriteLine(eKat.Cry());
			
            Animal zeeEgel = earthBreeder.CreateSeaUrchin("Stekel", 3, "purple");
            Animal eZeeEgel = plutoBreeder.CreateSeaUrchin("1928-I", 24, "dark metal");
            Console.WriteLine(zeeEgel);
            Console.WriteLine(zeeEgel.Cry());
            Console.WriteLine(eZeeEgel);
            Console.WriteLine(eZeeEgel.Cry());
        }
    }
}