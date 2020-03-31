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
        }
        [TestMethod()]
        public void DivideAnimalsTest()
        {
            Animal leeuw = new Animal("Leeuw", Animal.Diet.Carnivoor, Animal.Points.Middel);
            Animal olifant = new Animal("Olifant", Animal.Diet.Herbivoor, Animal.Points.Groot);
            Animal aap = new Animal("Aap", Animal.Diet.Herbivoor, Animal.Points.Middel);
            Animal konijn = new Animal("Konijn", Animal.Diet.Herbivoor, Animal.Points.Klein);
            Animal zeehond = new Animal("Zeehond", Animal.Diet.Carnivoor, Animal.Points.Middel);
            Animal parakiet = new Animal("Parakiet", Animal.Diet.Herbivoor, Animal.Points.Klein);
            animals.Add(leeuw);
            animals.Add(olifant);
            animals.Add(aap);
            animals.Add(konijn);
            animals.Add(zeehond);
            animals.Add(parakiet);
            List<Animal> carnivors = new List<Animal>();
            List<Animal> herbivors = new List<Animal>();
            carnivors = animals.Where(p => p._Diet == Animal.Diet.Carnivoor).ToList();
            herbivors = animals.Where(p => p._Diet == Animal.Diet.Herbivoor).ToList();
            int countCarnivors = carnivors.Count();
            int countHerbivors = herbivors.Count();
            Assert.AreEqual(2, countCarnivors);
            Assert.AreEqual(4, countHerbivors);
        }
        public void MultibleCarnivors()
        {
            Animal leeuw = new Animal("Leeuw", Animal.Diet.Carnivoor, Animal.Points.Middel);
            Animal zeehond = new Animal("Zeehond", Animal.Diet.Carnivoor, Animal.Points.Middel);
            animals.Add(leeuw);
            animals.Add(leeuw);
            animals.Add(leeuw);
            animals.Add(leeuw);

        }
    }
}