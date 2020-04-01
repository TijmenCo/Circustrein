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
        // public List<Animal> carnivors = new List<Animal>();
        // public List<Animal> herbivors = new List<Animal>();
        public IEnumerable<Wagon> Wagons { get => wagons; }
        //  public List<Wagon> Wagons { get => wagons; set => wagons = value; }
        public List<Animal> Animals { get => animals;  set => animals = value; }
        public Train()
        {
        }
        public void animalCheck(Animal animal)
        {

          
            foreach (Wagon wagon in Wagons)
            {
                if (wagon.CheckCompatability(animal) && wagon.CheckPoints(animal) == true)
                {
                    
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
            wagons.Add(wagon);
            animalCheck(animal);
        }

    }

}
