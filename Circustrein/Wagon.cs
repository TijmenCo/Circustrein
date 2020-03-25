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
        public int capacity = 10;
          
      
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
    }
}
