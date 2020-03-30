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
        public bool CheckCompatability(Animal animal)
        {
           foreach(Animal checkAnimal in this.animalsInWagon)
            {
                //ZELF //animal._Diet == Animal.Diet.Carnivoor && checkAnimal._Diet == Animal.Diet.Carnivoor || animal._Diet == Animal.Diet.Carnivoor && checkAnimal._Points <= animal._Points
                //GIT  //checkAnimal._Points <= animal._Points && animal._Diet == Animal.Diet.Carnivoor || checkAnimal._Diet == Animal.Diet.Carnivoor && checkAnimal._Points >= animal._Points
                if (checkAnimal._Points <= animal._Points && animal._Diet == Animal.Diet.Carnivoor || checkAnimal._Diet == Animal.Diet.Carnivoor && checkAnimal._Points >= animal._Points)
                {
                    return false;
                }
            }
            return true;
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
