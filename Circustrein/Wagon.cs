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
            this.AnimalsInWagon = animalsInWagon;
            this.capacity = Capacity;
        }
      //  public List<Animal> AnimalsInWagon { get => animalsInWagon; set => animalsInWagon = value; }
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

                if (checkAnimal.points <= animal.points && animal.diet == Animal.Diet.Carnivoor || checkAnimal.diet == Animal.Diet.Carnivoor && checkAnimal.points >= animal.points)
                {
                    return false;
                }
            }
            this.animalsInWagon.Add(animal);
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
