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
    public class Form1Tests
    {
        List<Animal> animals;
        [TestInitialize]
        public void TestInitialize()
        {
           animals = new List<Animal>();
           Animal leeuw = new Animal("Leeuw", "Vlees", 3);
           Animal olifant = new Animal("Olifant", "Plant", 5);
           Animal aap = new Animal("Aap", "Plant", 3);
           Animal konijn = new Animal("Konijn", "Plant", 1);
           Animal zeehond = new Animal("Zeehond", "Vlees", 3);
           Animal parakiet = new Animal("Parakiet", "Plant", 1);
            animals.Add(leeuw);
            animals.Add(olifant);
            animals.Add(aap);
            animals.Add(konijn);
            animals.Add(zeehond);
            animals.Add(parakiet);

        }
        [TestMethod()]
        public void DivideAnimalsCorrectlyTest()
        {
              List<Animal> carnivors = new List<Animal>();
              List<Animal> herbivors = new List<Animal>();
              carnivors = animals.Where(p => p.Diet == "Vlees").ToList();
              herbivors = animals.Where(p => p.Diet == "Plant").ToList();
              int countCarnivors = carnivors.Count();
              int countHerbivors = herbivors.Count();
              Assert.AreEqual(2, countCarnivors);
              Assert.AreEqual(3, countHerbivors);


        }
    }
}