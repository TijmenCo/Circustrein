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
        public int count;
        public bool succes;
        [TestInitialize]
        public void TestInitialize()
        {
        }
        [TestMethod()]
        public void DivideAnimals_BothAnimalsGetUsed_2()
        {
            //Check of beide dieren worden gebruikt ondanks dat herbivoor/carnivoor zijn.
            Animal leeuw = new Animal("Leeuw", Animal.Diet.Carnivoor, Animal.Points.Middel);
            Animal olifant = new Animal("Olifant", Animal.Diet.Herbivoor, Animal.Points.Groot);
            Train train = new Train();
            train.Animals.Add(leeuw);
            train.Animals.Add(olifant);
            foreach (Animal animal in train.Animals)
            {
                train.DivideAnimals(animal);
                if (animal.used)
                {
                    count++;
                }
            }
            Assert.AreEqual(2, count);
        }

        [TestMethod()]
        public void WagonCheck_AnimalAndWagonGetAdded_True()
        {
        //Check als het dier wordt geparsed en er een nieuwe wagon wordt aangemaakt. 
            Animal olifant = new Animal("Olifant", Animal.Diet.Herbivoor, Animal.Points.Groot);
            Train train = new Train();
            train.DivideAnimals(olifant);
            succes = train.Wagons.Any();
            Assert.AreEqual(true, succes);
        }
        [TestMethod()]
        public void NewWagon_WagonGetsMadeIfCarnivor_1()
        {
            int count;
            //Checkt als er een carnivoor is dat er een gelijk eeen nieuwe wagon wordt aangemaakt en dat er geen herbivorcheck wordt gebruikt. 
            Animal leeuw = new Animal("Leeuw", Animal.Diet.Carnivoor, Animal.Points.Middel);
            Train train = new Train();
            train.DivideAnimals(leeuw);
            count = train.Wagons.Count();
            Assert.AreEqual(1, count);
        }
    }
}