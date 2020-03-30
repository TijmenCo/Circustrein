using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    
    public class Animal
    { 
     public enum Points {
            Klein = 1,
            Middel = 3,
            Groot = 5
        }

        public string Name;
        public string Diet;
      //  public int Points;
      
        public Animal(string name, string diet, Points points)
        {
            this.Name = name;
            this.Diet = diet;
            this.Animal.Points = points;
        }
      
     

        public string Info
        {
            get
            {
                return $"{Name}";
            }
        }
    }
}
