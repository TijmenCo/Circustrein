using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Train
    {
        private List<Wagon> wagons = new List<Wagon>();
        public List<Animal> animals = new List<Animal>();
        // public List<Animal> carnivors = new List<Animal>();
        // public List<Animal> herbivors = new List<Animal>();
        public List<Wagon> Wagons { get => wagons; set => wagons = value; }
        public Train()
        {
        }
        public void Start()
        {
         //   vleesCheck();
            //  DivideAnimals();

            //  plantenCheck();
        }
        /*   public void DivideAnimals()
           {
               carnivors = animals.Where(p => p._Diet == Animal.Diet.Carnivoor).ToList();
               herbivors = animals.Where(p => p._Diet == Animal.Diet.Herbivoor).ToList();

        
    } */ 
        public void vleesCheck(Animal animal)
        {
            
            //var goodCarnivors = carnivors.Where(z1 => herbivors.Any(z2 => z1._Points < z2._Points));
            // var goodHerbivors = herbivors.Where(y1 => carnivors.Any(y2 => y1._Points > y2._Points));
         //   foreach (Animal animal in animals)
          //  {
              //  if (!Wagons.Any())
              //  {
           //         NewWagon(animal);
              //  }
             
                foreach (Wagon wagon in Wagons)
                {
                    if (wagon.CheckCompatability(animal) && wagon.CheckPoints(animal) == true)
                    {
                        wagon.AnimalsInWagon.Add(animal);
                        animal.Used = true;
                        wagon.capacity -= Convert.ToInt32(animal._Points);
                    } 
                    
                }
                if (!animal.Used)
                {
                    NewWagon(animal);
                 
                }

            
           
        }
     


        public void NewWagon(Animal animal)
        {
            Wagon wagon = new Wagon(10);
            //wagon.AnimalsInWagon.Add(animal);
            Wagons.Add(wagon);
            vleesCheck(animal);
        } 

    }

}
