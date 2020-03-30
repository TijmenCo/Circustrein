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
        public enum Diet
        {
           Carnivoor = 0,
           Herbivoor = 1
        }
        public bool Used;
        public Points _Points;
        public string Name;
        public Diet _Diet;
     
      
        public Animal(string name, Diet diet, Points points)
        {
            this.Name = name;
            this._Diet = diet;
            this._Points = points;
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
