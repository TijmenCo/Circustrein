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
        public int capacity;
        public int maxCapacity;
          
      
        public Wagon(int Capacity)
        {
            this.AnimalsInWagon = AnimalsInWagon;
            this.capacity = Capacity;
        }
        public List<Animal> AnimalsInWagon { get => animalsInWagon; set => animalsInWagon = value; }
        public string WagonInfo
        {
            get
            {
                return $"{"Wagon:" + capacity}";
            }
        }
        public Animal CheckCompatability(Animal animal, List<Animal> herbivoren)
        {
            foreach (Animal animalToCheck in herbivoren)
            {
                if (animal._Points < animalToCheck._Points)
                {
                    return animalToCheck;
                }
            }
            return animal;
        }
        public bool CheckPoints(Animal animal)
        {
            if (this.capacity - animal._Points >= 0)
            {
                return true;
            }
            //The animal can't be added
            else
            {
                return false;
            }
        }
    }
}
