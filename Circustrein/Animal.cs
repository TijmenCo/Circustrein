using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{

    public class Animal
    {
        public enum Points
        {
            Klein = 1,
            Middel = 3,
            Groot = 5
        }
        public enum Diet
        {
            Carnivoor = 1,
            Herbivoor = 2
        }

        public Animal(string name, Diet diet, Points points)
        {
            this.name = name;
            this.diet = diet;
            this.points = points;
        }
        public bool used { get; set; }
        public string name { get; }
        public Points points { get; }
        public Diet diet { get; }



        public string Info
        {
            get
            {
                return $"{name}";
            }
        }
    }
}
