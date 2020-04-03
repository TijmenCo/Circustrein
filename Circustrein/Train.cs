using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Train
    {
        private List<Wagon> wagons = new List<Wagon>();

        public IEnumerable<Wagon> Wagons { get => wagons; }
        public List<Animal> Animals { get; set; } = new List<Animal>();


        public Train()
        {

        }
        public void DivideAnimals(Animal animal)
        {
            if(animal.diet == Animal.Diet.Carnivoor)
            {
                NewWagon(animal);
            }
            else
            {
                 WagonCheck(animal);
            }
           
        }
        public void WagonCheck(Animal animal)
        {
            foreach (Wagon wagon in Wagons)
            {
                wagon.HerbivorCheck(wagon, animal);
                 
            }
            if (!animal.used)
            {
                NewWagon(animal);
            }
        }

        public void NewWagon(Animal animal)
        {
            if(animal.diet == Animal.Diet.Carnivoor)
            {
                Wagon wagon = new Wagon(10);
                wagon.AddAnimal(animal);
                wagons.Add(wagon);
            }
            else
            {
                Wagon wagon = new Wagon(10);
                wagons.Add(wagon);
                WagonCheck(animal);
            }
        }

    }
}
