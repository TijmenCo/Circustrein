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
        private bool Used;
        private Points _points;
        private string Name;
        private Diet _diet;


        public Animal(string name, Diet diet, Points points)
        {
            this.used = Used;
            this.Name = name;
            this._diet = diet;
            this._points = points;
        }
        public bool used { get; set; }
        public string name { get => Name; }
        public Points points { get => _points; }
        public Diet diet { get => _diet; }


        public string Info
        {
            get
            {
                return $"{Name}";
            }
        }
    }
}
