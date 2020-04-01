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
            if (animal.diet == Animal.Diet.Carnivoor)
            {
                NewWagon(animal);
            }
            else
            {
                foreach (Wagon wagon in Wagons)
                {  
                    if (wagon.fullCheck(animal) == true)
                    {
                       
                    }
                        NewWagon(animal);
             
                }
              
                  
            }
          //  if (!animal.used)
          //  {
           //     NewWagon(animal);

         //   }

        }



        public void NewWagon(Animal animal)
        {
            if (animal.diet == Animal.Diet.Carnivoor)
            {
                Wagon wagon = new Wagon(10);
                wagons.Add(wagon);
                wagon.AddCarnivor(animal);
                //animals.Remove(animal);
            }
            else
            {
                Wagon wagon2 = new Wagon(10);
                wagons.Add(wagon2);
                animal.used = true;
                animalCheck(animal);
            }
        }

    }

}
