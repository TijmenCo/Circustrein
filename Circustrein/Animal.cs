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
            Carnivoor = 0,
            Herbivoor = 1
        }
<<<<<<< HEAD
        private bool Used;
        private Points _points;
        private string Name;
        private Diet _diet;
=======
        public bool Used;
        public Points _Points;
        public string Name;
        public Diet _Diet;
>>>>>>> parent of 666d1f1... Encapsulation werkt nu met oude Algoritme


        public Animal(string name, Diet diet, Points points)
        {
            this.used = Used;
            this.Name = name;
            this._Diet = diet;
            this._Points = points;
        }
<<<<<<< HEAD
        public bool used { get; set; }
        public string name { get => Name; }
        public Points points { get => _points; }
        public Diet diet { get => _diet; }
=======

>>>>>>> parent of 666d1f1... Encapsulation werkt nu met oude Algoritme


        public string Info
        {
            get
            {
                return $"{Name}";
            }
        }
    }
}
