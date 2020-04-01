using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Wagon
    {

        private List<Animal> animalsInWagon = new List<Animal>();
        private int Capacity;
 


        public Wagon(int Capacity)
        {
            this.AnimalsInWagon = animalsInWagon;
            this.Capacity = Capacity;
        }


        public int capacity { get => Capacity; set => Capacity = value; }
    

        public IEnumerable<Animal> AnimalsInWagon { get; }
        public string WagonInfo
        {
            get
            {
                return $"{"Wagon:" + capacity}";
            }
        }
       
        public bool CheckCompatibility(Animal animal)
        {
           
            foreach (Animal animalToCheck in this.AnimalsInWagon)
            {
               
                if (animalToCheck.points <= animal.points && animal.diet == Animal.Diet.Carnivoor || animalToCheck.diet == Animal.Diet.Carnivoor && animalToCheck.points >= animal.points)
                {
                    return false;
                }
            }
            animalsInWagon.Add(animal);
            animal.used = true;
            capacity -= Convert.ToInt32(animal.points);
            return true;
        }

        public bool CheckPoints(Animal animal)
        {
            if (this.capacity - animal.points >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
