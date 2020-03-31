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
        public List<Animal> animals = new List<Animal>();
        // public List<Animal> carnivors = new List<Animal>();
        // public List<Animal> herbivors = new List<Animal>();
        public List<Wagon> Wagons { get => wagons; set => wagons = value; }
        public Train()
        {
        }
        public void animalCheck(Animal animal)
        {

          
            foreach (Wagon wagon in Wagons)
            {
                if (wagon.CheckCompatability(animal) && wagon.CheckPoints(animal) == true)
                {
                    wagon.AnimalsInWagon.Add(animal);
                    animal.Used = true;
                    wagon.capacity -= Convert.ToInt32(animal._Points);
                }

            }
            if (!animal.Used)
            {
                NewWagon(animal);

            }



        }



        public void NewWagon(Animal animal)
        {
            Wagon wagon = new Wagon(10);
            Wagons.Add(wagon);
            animalCheck(animal);
        }

    }

}
