using Microsoft.VisualStudio.TestTools.UnitTesting;
using Circustrein;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein.Tests
{
    [TestClass()]
    public class TrainTests
    {
        [TestMethod()]
        public void DivideAnimalsTest()
        {
            int count = 0;
            Animal leeuw = new Animal("Leeuw", Animal.Diet.Carnivoor, Animal.Points.Middel);
            Animal olifant = new Animal("Olifant", Animal.Diet.Herbivoor, Animal.Points.Groot);
            List<Animal> animals = new List<Animal>();
            animals.Add(leeuw);
            animals.Add(olifant);
            Train train = new Train();
            foreach (Animal animal in animals)
            {
                train.DivideAnimals(animal);
                if (animal.used == true)
                {
                    count++;
                }
                else
                {
                }
            }

            Assert.AreEqual(2, count);

        }

        [TestMethod()]
        public void WagonCheckTest()
        {
            bool succes;
            Animal olifant = new Animal("Olifant", Animal.Diet.Herbivoor, Animal.Points.Groot);
            Train train = new Train();
            train.WagonCheck(olifant);

            if(train.Wagons.Any())
            {
                succes = true;
            }
            {
                succes = false;
            }
            Assert.AreEqual(true, succes);
        }
    }
}