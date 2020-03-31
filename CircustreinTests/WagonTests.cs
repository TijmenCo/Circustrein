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
            bool succes;
            Animal leeuw = new Animal("Leeuw", Animal.Diet.Carnivoor, Animal.Points.Middel);
            Animal olifant = new Animal("Olifant", Animal.Diet.Herbivoor, Animal.Points.Groot);
            Animal aap = new Animal("Aap", Animal.Diet.Herbivoor, Animal.Points.Middel);
            Animal konijn = new Animal("Konijn", Animal.Diet.Herbivoor, Animal.Points.Klein);
            Animal zeehond = new Animal("Zeehond", Animal.Diet.Carnivoor, Animal.Points.Middel);
            Animal parakiet = new Animal("Parakiet", Animal.Diet.Herbivoor, Animal.Points.Klein);
            animals.Add(leeuw);
            animalsInWagon.Add(olifant);
            foreach (Animal animal in animals)
            {


                foreach (Animal checkAnimal in this.animalsInWagon)
                {

                    if (checkAnimal._Points <= animal._Points && animal._Diet == Animal.Diet.Carnivoor || checkAnimal._Diet == Animal.Diet.Carnivoor && checkAnimal._Points >= animal._Points)
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
      

        [TestMethod()]
        public void CheckPointsTest()
        {
            Assert.Fail();
        }
    }
}