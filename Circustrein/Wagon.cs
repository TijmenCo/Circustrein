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
        public List<Dier> dierenInWagon = new List<Dier>();
        public int capacity = 10;
      
        public Wagon()
        {
            
        }
        /*
        public void puntencheck()
        {
            foreach (Dier dier in home.wachtrij)
            {
                tijdigePunten += dier.Points;
            }
            if (capacity >= 10)
            {
                dierenInWagon.AddRange(home.wachtrij);
            }
            else
            {
                var query2 = home.planteters.Where(x1 => home.vleeseters.Any(x2 => x1.Points > x2.Points));
                foreach (Dier x1 in query2)
                {
                    var pdier = x1;
                    home.wachtrij.Add(x1);
                    home.planteters.Remove(x1);
                    break;
                }
                puntencheck();
            }
        }
        */
    }
}
