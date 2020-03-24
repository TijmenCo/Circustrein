using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Wagon
    {
       

        public int tijdigePunten;
        private List<Dier> dierenInWagon = new List<Dier>();
        public int capacity = 10;
          
      
        public Wagon(int Capacity)
        {
            this.DierenInWagon = DierenInWagon;
            this.capacity = Capacity;
        }
        public List<Dier> DierenInWagon { get => dierenInWagon; set => dierenInWagon = value; }
        public string WagonInfo
        {
            get
            {
                return $"{"Wagon:" + capacity}";
            }
        }
    }
}
