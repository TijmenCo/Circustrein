using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    
    public class Dier
    { 
        public enum Size
        {
            Klein = 1,
            Gemiddeld = 3,
            Groot = 5
        }
        public string Name;
        public string Diet;
        public Size Points;
        public Dier(string name, string diet, Size points)
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
