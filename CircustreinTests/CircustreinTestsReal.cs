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
    public class CircustreinTests
    {

        [TestMethod()]
        public void ShowWagonsTest()
        {
            Circustrein circustrein = new Circustrein();
            Train train = new Train();
            Animal leeuw = new Animal("Leeuw", Animal.Diet.Carnivoor, Animal.Points.Middel);
            Animal zeehond = new Animal("Zeehond", Animal.Diet.Carnivoor, Animal.Points.Middel);
            Animal olifant = new Animal("Olifant", Animal.Diet.Herbivoor, Animal.Points.Groot);
            Wagon wagon1 = new Wagon(10);
            wagon1.AnimalsInWagon.Add(leeuw);
            train.Wagons.Add(wagon1);
            Wagon wagon2 = new Wagon(10);
            wagon1.AnimalsInWagon.Add(olifant);
            train.Wagons.Add(wagon2);
            Wagon wagon3 = new Wagon(10);
            wagon1.AnimalsInWagon.Add(zeehond);
            train.Wagons.Add(wagon3);
            circustrein.ShowWagons();
            int wagons = circustrein.listBoxWagons.Items.Count;
            int animals = circustrein.listBoxAnimals.Items.Count;
            Assert.AreEqual(3, wagons);
            Assert.AreEqual(3, animals);
        }

    }
}