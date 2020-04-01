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
        public int capacity { get => Capacity; }
    
        public IEnumerable<Animal> AnimalsInWagon { get; }
        public string WagonInfo
        {
            get
            {
                return $"{"Wagon:" + capacity}";
            }
        }
        public bool CheckCompatability(Animal animal)
        {
            foreach (Animal checkAnimal in this.animalsInWagon)
            {

                if (checkAnimal.points >= animal.points)
                {
                    return false;
                }
                
            }
          
                animal.used = true;
                this.animalsInWagon.Add(animal);
                this.Capacity = Capacity - Convert.ToInt32(animal.points);
                return true;
      
          
        }
        public void AddCarnivor(Animal animal)
        {
            this.animalsInWagon.Add(animal);
            this.Capacity = Capacity - Convert.ToInt32(animal.points);
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
