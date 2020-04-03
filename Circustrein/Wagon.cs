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
       public void HerbivorCheck(Wagon wagon, Animal animal)
        {
            if (wagon.CheckRulesHerbivor(animal) && wagon.CheckPointsHerbivor(animal))
            {
                AddAnimal(animal);
            }
          
        }
        public bool CheckRulesHerbivor(Animal animal)
        {
           
            foreach (Animal animalToCheck in AnimalsInWagon)
            {
               
                if (animalToCheck.diet == Animal.Diet.Carnivoor && animal.diet == Animal.Diet.Carnivoor || animalToCheck.diet == Animal.Diet.Carnivoor && animal.points <= animalToCheck.points)
                {
                    return false;
                }
            }
            return true;
        }

        public bool CheckPointsHerbivor(Animal animal)
        {
            if (capacity - animal.points >= 0)
            { 
                return true;
            }
            else
            {
                return false;
            }
        }
        public void AddAnimal(Animal animal)
        {
                animalsInWagon.Add(animal);
                capacity -= Convert.ToInt32(animal.points);
                animal.used = true;     
        }
    }
}
