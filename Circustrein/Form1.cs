using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circustrein
{
    public partial class Form1 : Form
    {
      public static Form1 form1Ref;
      public List<Wagon> wagons = new List<Wagon>(); 
      public List<Animal> animals = new List<Animal>();
      public  List<Animal> carnivors = new List<Animal>();
      public  List<Animal> herbivors = new List<Animal>();
        Animal leeuw = new Animal("Leeuw", "Vlees", 3);
        Animal olifant = new Animal("Olifant", "Plant", 5);
        Animal aap = new Animal("Aap", "Plant", 3);
        Animal konijn = new Animal("Konijn", "Plant", 1);
        Animal zeehond = new Animal("Zeehond", "Vlees", 3);
        Animal parakiet = new Animal("Parakiet", "Plant", 1);
   
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {

            carnivors = animals.Where(p => p.Diet == "Vlees").ToList();
            herbivors = animals.Where(p => p.Diet == "Plant").ToList();
            vleesCheck();
            plantenCheck();
            ShowWagons();
            



        }
        public void ShowWagons()
        {
            foreach (Wagon wagon in wagons)
            {
                listBoxWagons.Items.Add(wagon);
                foreach (Animal animal in wagon.AnimalsInWagon.ToList())
                {
                    listBoxAnimals.Items.Add(animal);
                }
            }
            listBoxAnimals.DisplayMember = "Info";
            listBoxWagons.DisplayMember = "WagonInfo";
        }
        public void vleesCheck()
        {
        
            var goodCarnivors = carnivors.Where(z1 => herbivors.Any(z2 => z1.Points < z2.Points));
            var goodHerbivors = herbivors.Where(y1 => carnivors.Any(y2 => y1.Points > y2.Points));
            if (!goodHerbivors.Any())
            {
                foreach (Animal animal in goodCarnivors.ToList())
                {
                    Wagon wagon = new Wagon(10);
                    wagons.Add(wagon);
                    wagon.AnimalsInWagon.Add(animal);
                    wagon.capacity -= animal.Points;
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
                    wagon.capacity -= animal.Points;
                    carnivors.Remove(animal);
                    if (goodHerbivors.Any())
                    {
                        foreach (Animal animal2 in goodHerbivors.ToList())
                        {
                            if (wagon.capacity >= 0)
                            {
                                wagon.AnimalsInWagon.Add(animal2);
                                wagon.capacity -= animal2.Points;
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
                        wagon.capacity -= animal.Points;
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
     
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            animals.Add(leeuw);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            animals.Add(olifant);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            animals.Add(aap);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            animals.Add(konijn);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            animals.Add(zeehond);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            animals.Add(parakiet);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBoxAnimals_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
