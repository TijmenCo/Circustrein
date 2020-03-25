using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    
    public class Animal
    { 
        public string Name;
        public string Diet;
        public int Points;

        public Animal(string name, string diet, int points)
        {
            this.Name = name;
            this.Diet = diet;
            this.Points = points;
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
