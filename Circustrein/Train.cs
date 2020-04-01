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
        public void animalCheck(Animal animal)
        {
            foreach (Wagon wagon in Wagons)
            {

                if (wagon.CheckRules(animal) && wagon.CheckPoints(animal))
                {
                }
            }
            if (!animal.used)
            {
                NewWagon(animal);
            }
        }


        public void NewWagon(Animal animal)
        {
            Wagon wagon = new Wagon(10);
            animalCheck(animal);
            wagons.Add(wagon);
        }

    }
}
