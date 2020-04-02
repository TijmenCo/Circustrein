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
        private List<Animal> animals = new List<Animal>();
        public IEnumerable<Wagon> Wagons { get => wagons; }
        public List<Animal> Animals { get => animals; set => animals = value; }


        public Train()
        {

        }
        public void DivideAnimals(Animal animal)
        {
            if(animal.diet == Animal.Diet.Carnivoor)
            {
                NewWagonCarnivor(animal);
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
                if(wagon.HerbivorCheck(wagon, animal) == true)
                {
                }   
            }
            if (!animal.used)
            {
                NewWagonHerbivor(animal);
            }
        }

        public void NewWagonCarnivor(Animal animal)
        {
            Wagon wagon = new Wagon(10);
            wagon.AddCarnivors(animal);
            wagons.Add(wagon);
        }
        public void NewWagonHerbivor(Animal animal)
        {
            Wagon wagon = new Wagon(10);
            wagons.Add(wagon);
            WagonCheck(animal);
        }

    }
}
