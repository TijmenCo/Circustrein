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
<<<<<<< HEAD

        public int capacity { get => Capacity; set => Capacity = value; }
    
=======
      //  public List<Animal> AnimalsInWagon { get => animalsInWagon; set => animalsInWagon = value; }
>>>>>>> parent of 666d1f1... Encapsulation werkt nu met oude Algoritme
        public IEnumerable<Animal> AnimalsInWagon { get; }
        public string WagonInfo
        {
            get
            {
                return $"{"Wagon:" + capacity}";
            }
        }
        public bool fullCheck(Animal animal)
        {
            if (CheckPoints(animal) && CheckCompatability(animal))
            {
                animalsInWagon.Add(animal);
                Capacity = Capacity - Convert.ToInt32(animal.points);
                return true;
            }
            return false;
        }
        public bool CheckCompatability(Animal animal)
        {
            foreach (Animal checkAnimal in this.animalsInWagon)
            {
                if (animal.points <= checkAnimal.points)
                {
                    return false;
                }
            }
<<<<<<< HEAD
            return true;



        }
        public void AddCarnivor(Animal animal)
        {
            animalsInWagon.Add(animal);
            Capacity = Capacity - Convert.ToInt32(animal.points);
=======
            this.animalsInWagon.Add(animal);
            return true;
>>>>>>> parent of 666d1f1... Encapsulation werkt nu met oude Algoritme
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
