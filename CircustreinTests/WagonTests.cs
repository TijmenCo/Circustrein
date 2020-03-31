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
    public class WagonTests
    {
        public bool succes;
        List<Animal> animals;
        List<Animal> animalsInWagon;
        [TestInitialize]
        public void TestInitialize()
        {
            animals = new List<Animal>();
            animalsInWagon = new List<Animal>();
        }

        [TestMethod()]
        public void CheckCompatabilityTest()
        {
            Wagon wagon = new Wagon(10);
            bool succes;
            Animal leeuw = new Animal("Leeuw", Animal.Diet.Carnivoor, Animal.Points.Middel);
            Animal olifant = new Animal("Olifant", Animal.Diet.Herbivoor, Animal.Points.Groot);
            Animal aap = new Animal("Aap", Animal.Diet.Herbivoor, Animal.Points.Middel);
            Animal konijn = new Animal("Konijn", Animal.Diet.Herbivoor, Animal.Points.Klein);
            Animal zeehond = new Animal("Zeehond", Animal.Diet.Carnivoor, Animal.Points.Middel);
            Animal parakiet = new Animal("Parakiet", Animal.Diet.Herbivoor, Animal.Points.Klein);
            animals.Add(leeuw);
            animalsInWagon.Add(olifant);

            if (wagon.CheckCompatability(leeuw) == true)
            {
                succes = true;
            }
            else
            {
                succes = false;
            }

            Assert.AreEqual(true, succes);


        }


        [TestMethod()]
        public void CheckPointsTest()
        {

            bool succes;
            Wagon wagon = new Wagon(10);
            Animal leeuw = new Animal("Leeuw", Animal.Diet.Carnivoor, Animal.Points.Middel);
            Animal olifant = new Animal("Olifant", Animal.Diet.Herbivoor, Animal.Points.Groot);
            Animal aap = new Animal("Aap", Animal.Diet.Herbivoor, Animal.Points.Middel);
            Animal konijn = new Animal("Konijn", Animal.Diet.Herbivoor, Animal.Points.Klein);
            Animal zeehond = new Animal("Zeehond", Animal.Diet.Carnivoor, Animal.Points.Middel);
            Animal parakiet = new Animal("Parakiet", Animal.Diet.Herbivoor, Animal.Points.Klein);
            animalsInWagon.Add(aap);
            animalsInWagon.Add(konijn);
            animalsInWagon.Add(leeuw);
            animalsInWagon.Add(olifant);
            wagon.capacity -= Convert.ToInt32(olifant._Points);
            if (wagon.CheckCompatability(olifant) == true)
            {
                succes = true;

            }
            else
            {
                succes = false;
            }
            Assert.AreEqual(true, succes);


        }
    }
}