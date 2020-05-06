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
        public void HerbivorCheck_HerbivorAndCarnivorInWagon_2()
        {
            //Check als het algoritme werkt door een olifant en leeuw toe te voegen. Dit lukt omdat de olifant een herbivoor en groter is dan de leeuw. Er worden dus 2 dieren in de wagon getelt. 
            int count;
            Train train = new Train();
            Wagon wagon = new Wagon(10);
            Animal leeuw = new Animal("Leeuw", Animal.Diet.Carnivoor, Animal.Points.Middel);
            Animal olifant = new Animal("Olifant", Animal.Diet.Herbivoor, Animal.Points.Groot);
            Animal aap = new Animal("Aap", Animal.Diet.Herbivoor, Animal.Points.Middel);
            Animal konijn = new Animal("Konijn", Animal.Diet.Herbivoor, Animal.Points.Klein);
            Animal zeehond = new Animal("Zeehond", Animal.Diet.Carnivoor, Animal.Points.Middel);
            Animal parakiet = new Animal("Parakiet", Animal.Diet.Herbivoor, Animal.Points.Klein);
            wagon.AddAnimal(leeuw);
            wagon.HerbivorCheck(wagon, olifant);
            count = wagon.AnimalsInWagon.Count();
            Assert.AreEqual(2, count);
        }
        [TestMethod()]
        public void HerbivorCheck_HerbivorAndCarnivor_1()
        {
            //Check als het algoritme fout gaat door een konijn en leeuw toe te voegen. Dit lukt niet omdat . Er wordt dus 1 dier in de wagon getelt.  
            int count;
            Wagon wagon = new Wagon(10);
            Animal leeuw = new Animal("Leeuw", Animal.Diet.Carnivoor, Animal.Points.Middel);
            Animal olifant = new Animal("Olifant", Animal.Diet.Herbivoor, Animal.Points.Groot);
            Animal aap = new Animal("Aap", Animal.Diet.Herbivoor, Animal.Points.Middel);
            Animal konijn = new Animal("Konijn", Animal.Diet.Herbivoor, Animal.Points.Klein);
            Animal zeehond = new Animal("Zeehond", Animal.Diet.Carnivoor, Animal.Points.Middel);
            Animal parakiet = new Animal("Parakiet", Animal.Diet.Herbivoor, Animal.Points.Klein);
            wagon.AddAnimal(leeuw);
            wagon.HerbivorCheck(wagon, konijn);
            count = wagon.AnimalsInWagon.Count();
            Assert.AreEqual(1, count);
        }


        [TestMethod()]
        public void HerbivorCheck_CapacityStaysAtZero_0()
        {
            //Check als de punten goed van de capacity van de wagon worden afgetrokken. (Er zit al een olifant in dus er zijn 5 resterende punten). Er blijven dus 0 punten over.
            int count;
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
            wagon.HerbivorCheck(wagon, olifant);
            count = wagon.capacity;
            Assert.AreEqual(0, count);


        }
        [TestMethod()]
        public void AddAnimal_CapacityGoesUnderZero_2()
        {
            //Check als er alleen dieren worden toegevoegd als er plaats voor is. (Er zit al een olifant en een giraffe in dus er zijn 0 resterende punten). Er blijven dus 2 dieren in de wagon.
            int count;
            Train train = new Train();
            Wagon wagon = new Wagon(10);
            Animal leeuw = new Animal("Leeuw", Animal.Diet.Carnivoor, Animal.Points.Middel);
            Animal olifant = new Animal("Olifant", Animal.Diet.Herbivoor, Animal.Points.Groot);
            Animal aap = new Animal("Aap", Animal.Diet.Herbivoor, Animal.Points.Middel);
            Animal konijn = new Animal("Konijn", Animal.Diet.Herbivoor, Animal.Points.Klein);
            Animal zeehond = new Animal("Zeehond", Animal.Diet.Carnivoor, Animal.Points.Middel);
            Animal parakiet = new Animal("Parakiet", Animal.Diet.Herbivoor, Animal.Points.Klein);
            Animal giraffe = new Animal("giraffe", Animal.Diet.Herbivoor, Animal.Points.Groot);
            //wagon.AddAnimal(aap); //3 punten
            //wagon.AddAnimal(konijn); //1 punt
            //wagon.AddAnimal(leeuw); //3 punten
            wagon.AddAnimal(olifant); //5 punten
            wagon.AddAnimal(giraffe); //5 punten
            wagon.HerbivorCheck(wagon, aap);
            count = wagon.AnimalsInWagon.Count();
            Assert.AreEqual(2, count);


        }
    }
}