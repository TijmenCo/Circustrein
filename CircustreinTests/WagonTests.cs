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
            //Check als het algoritme werkt door een olifant en leeuw toe te voegen. Dit lukt omdat de olifant een herbivoor en groter is dan de leeuw. 
            Wagon wagon = new Wagon(10);
            bool succes;
            Animal leeuw = new Animal("Leeuw", Animal.Diet.Carnivoor, Animal.Points.Middel);
            Animal olifant = new Animal("Olifant", Animal.Diet.Herbivoor, Animal.Points.Groot);
            Animal aap = new Animal("Aap", Animal.Diet.Herbivoor, Animal.Points.Middel);
            Animal konijn = new Animal("Konijn", Animal.Diet.Herbivoor, Animal.Points.Klein);
            Animal zeehond = new Animal("Zeehond", Animal.Diet.Carnivoor, Animal.Points.Middel);
            Animal parakiet = new Animal("Parakiet", Animal.Diet.Herbivoor, Animal.Points.Klein);
            animals.Add(olifant);
            animalsInWagon.Add(leeuw);
            succes = wagon.CheckRulesHerbivor(olifant);
            Assert.AreEqual(true, succes);


        }


        [TestMethod()]
        public void CheckPointsTest()
        {
            //Check als de punten goed van de capacity van de wagon worden afgetrokken. (Er zit al een olifant in dus er zijn 5 resterende punten).
            bool succes;
            Wagon wagon = new Wagon(10);
            Animal leeuw = new Animal("Leeuw", Animal.Diet.Carnivoor, Animal.Points.Middel);
            Animal olifant = new Animal("Olifant", Animal.Diet.Herbivoor, Animal.Points.Groot);
            Animal aap = new Animal("Aap", Animal.Diet.Herbivoor, Animal.Points.Middel);
            Animal konijn = new Animal("Konijn", Animal.Diet.Herbivoor, Animal.Points.Klein);
            Animal zeehond = new Animal("Zeehond", Animal.Diet.Carnivoor, Animal.Points.Middel);
            Animal parakiet = new Animal("Parakiet", Animal.Diet.Herbivoor, Animal.Points.Klein);
            animalsInWagon.Add(aap); //3
            animalsInWagon.Add(konijn); //1
            animalsInWagon.Add(leeuw); //3
            animalsInWagon.Add(olifant); //5
            wagon.capacity -= Convert.ToInt32(olifant.points);
            succes = wagon.CheckPointsHerbivor(olifant);
            Assert.AreEqual(true, succes);


        }
    }
}