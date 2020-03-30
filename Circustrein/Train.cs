using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Train
    {
        public List<Wagon> wagons = new List<Wagon>();
        public List<Animal> animals = new List<Animal>();
        public List<Animal> carnivors = new List<Animal>();
        public List<Animal> herbivors = new List<Animal>();

        public Train()
        {
            Start();
        }
        public void Start()
        {
            DivideAnimals();
            vleesCheck();
            plantenCheck();
        }
        public void DivideAnimals()
        {
            carnivors = animals.Where(p => p.Diet == "Vlees").ToList();
            herbivors = animals.Where(p => p.Diet == "Plant").ToList();

        }
        public void vleesCheck()
        {

            var goodCarnivors = carnivors.Where(z1 => herbivors.Any(z2 => z1._Points < z2._Points));
            var goodHerbivors = herbivors.Where(y1 => carnivors.Any(y2 => y1._Points > y2._Points));
            if (!goodHerbivors.Any())
            {
                foreach (Animal animal in goodCarnivors.ToList())
                {
                    Wagon wagon = new Wagon(10);
                    wagons.Add(wagon);
                    wagon.AnimalsInWagon.Add(animal);
                    wagon.capacity -= Convert.ToInt32(animal._Points);
                    carnivors.Remove(animal);
                }
            }
            else
            {
                foreach (Animal animal in goodCarnivors.ToList())
                {
                    Wagon wagon = new Wagon(10);
                    wagons.Add(wagon);
                    wagon.AnimalsInWagon.Add(animal);
                    wagon.capacity -= Convert.ToInt32(animal._Points);
                    carnivors.Remove(animal);
                    if (goodHerbivors.Any())
                    {
                        foreach (Animal animal2 in goodHerbivors.ToList())
                        {
                            if (wagon.capacity >= 0)
                            {
                                wagon.AnimalsInWagon.Add(animal2);
                                wagon.capacity -= Convert.ToInt32(animal._Points);
                                goodHerbivors.ToList().Remove(animal2);
                                herbivors.Remove(animal2);
                            }
                        }
                    }
                }

            }
        }
        public void plantenCheck()
        {
            Wagon wagon = new Wagon(10);
            wagons.Add(wagon);
            foreach (Animal animal in herbivors.ToList())
            {
                if (wagon.capacity > 0)
                {
                    if (herbivors.Any())
                    {
                        wagon.AnimalsInWagon.Add(animal);
                        wagon.capacity -= Convert.ToInt32(animal._Points);
                        herbivors.Remove(animal);

                    }

                }
                else
                {
                    if (herbivors.Any())
                    {
                        Wagon wagon2 = new Wagon(10);
                        wagons.Add(wagon);
                    }
                }
            }
        }

    }

}
