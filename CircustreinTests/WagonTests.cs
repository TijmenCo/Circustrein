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

        [TestInitialize]
        public void TestInitialize()
        {
        }

        [TestMethod()]
        public void CheckRulesHerbivorCheck()
        {
            //Check als het algoritme werkt door een olifant en leeuw toe te voegen. Dit lukt omdat de olifant een herbivoor en groter is dan de leeuw. 
            Wagon wagon = new Wagon(10);
            Animal leeuw = new Animal("Leeuw", Animal.Diet.Carnivoor, Animal.Points.Middel);
            Animal olifant = new Animal("Olifant", Animal.Diet.Herbivoor, Animal.Points.Groot);
            Animal aap = new Animal("Aap", Animal.Diet.Herbivoor, Animal.Points.Middel);
            Animal konijn = new Animal("Konijn", Animal.Diet.Herbivoor, Animal.Points.Klein);
            Animal zeehond = new Animal("Zeehond", Animal.Diet.Carnivoor, Animal.Points.Middel);
            Animal parakiet = new Animal("Parakiet", Animal.Diet.Herbivoor, Animal.Points.Klein);
            wagon.AddAnimal(leeuw);
            succes = wagon.CheckRulesHerbivor(olifant);
            Assert.AreEqual(true, succes);
        }


        [TestMethod()]
        public void CheckPointsTest()
        {
            //Check als de punten goed van de capacity van de wagon worden afgetrokken. (Er zit al een olifant in dus er zijn 5 resterende punten).
            Wagon wagon = new Wagon(10);
            Animal leeuw = new Animal("Leeuw", Animal.Diet.Carnivoor, Animal.Points.Middel);
            Animal olifant = new Animal("Olifant", Animal.Diet.Herbivoor, Animal.Points.Groot);
            Animal aap = new Animal("Aap", Animal.Diet.Herbivoor, Animal.Points.Middel);
            Animal konijn = new Animal("Konijn", Animal.Diet.Herbivoor, Animal.Points.Klein);
            Animal zeehond = new Animal("Zeehond", Animal.Diet.Carnivoor, Animal.Points.Middel);
            Animal parakiet = new Animal("Parakiet", Animal.Diet.Herbivoor, Animal.Points.Klein);
            //wagon.AddAnimal(aap); //3 punten
            //wagon.AddAnimal(konijn); //1 punt
            //wagon.AddAnimal(leeuw); //3 punten
            wagon.AddAnimal(olifant); //5 punten
            succes = wagon.CheckPointsHerbivor(olifant);
            Assert.AreEqual(true, succes);


        }
    }
}