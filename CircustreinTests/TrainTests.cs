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
        public void NewAnimalCheckTest()
        {
            bool succes;
            Animal leeuw = new Animal("Leeuw", Animal.Diet.Carnivoor, Animal.Points.Middel);
            Train train = new Train();
            Wagon wagon = new Wagon(10);
            train.NewWagon(leeuw);
            train.animalCheck(leeuw);
            if (leeuw.Used == true)
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