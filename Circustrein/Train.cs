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
            carnivors = animals.Where(p => p._Diet == Animal.Diet.Carnivoor).ToList();
            herbivors = animals.Where(p => p._Diet == Animal.Diet.Herbivoor).ToList();

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
               
                
                foreach (Animal animal2 in goodCarnivors.ToList())
                {
                    //Check als er al een wagon bestaat
                    if (!wagons.Any())
                    {
                        NewWagon(animal2);
                    }
                    foreach(Wagon wagon in wagons)
                    {
                        var ani = wagon.CheckCompatability(animal2, goodHerbivors.ToList());
                        wagon.AnimalsInWagon.Add(ani);
                        wagon.capacity -= Convert.ToInt32(ani._Points);
                        animals.Remove(ani);
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
        public void NewWagon(Animal animal)
        {
            Wagon wagon = new Wagon(10);
            wagon.AnimalsInWagon.Add(animal);
            wagons.Add(wagon);
            animals.Remove(animal);
        } 

    }

}
