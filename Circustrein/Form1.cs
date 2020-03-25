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
      public List<Dier> animals = new List<Dier>();
      public  List<Dier> carnivors = new List<Dier>();
      public  List<Dier> herbivors = new List<Dier>();
        Dier leeuw = new Dier("Leeuw", "Vlees", 3);
        Dier olifant = new Dier("Olifant", "Plant", 5);
        Dier aap = new Dier("Aap", "Plant", 3);
        Dier konijn = new Dier("Konijn", "Plant", 1);
        Dier zeehond = new Dier("Zeehond", "Vlees", 3);
        Dier parakiet = new Dier("Parakiet", "Plant", 1);
   
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
                foreach (Dier dier in wagon.AnimalsInWagon.ToList())
                {
                    listBoxAnimals.Items.Add(dier);
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
                foreach (Dier dier in goodCarnivors.ToList())
                {
                    Wagon wagon = new Wagon(10);
                    wagons.Add(wagon);
                    wagon.AnimalsInWagon.Add(dier);
                    wagon.capacity -= dier.Points;
                    carnivors.Remove(dier);
                }
            }
            else
            {
                foreach (Dier dier in goodCarnivors.ToList())
                {
                    Wagon wagon = new Wagon(10);
                    wagons.Add(wagon);
                    wagon.AnimalsInWagon.Add(dier);
                    wagon.capacity -= dier.Points;
                    carnivors.Remove(dier);
                    if (goodHerbivors.Any())
                    {
                        foreach (Dier dier2 in goodHerbivors.ToList())
                        {
                            if (wagon.capacity >= 0)
                            {
                                wagon.AnimalsInWagon.Add(dier2);
                                wagon.capacity -= dier2.Points;
                                goodHerbivors.ToList().Remove(dier2);
                                herbivors.Remove(dier2);
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
            foreach (Dier dier in herbivors.ToList())
            {
                if (wagon.capacity > 0)
                {
                    if (herbivors.Any())
                    {
                        wagon.AnimalsInWagon.Add(dier);
                        wagon.capacity -= dier.Points;
                        herbivors.Remove(dier);

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
