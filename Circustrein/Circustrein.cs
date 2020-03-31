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
    public partial class Circustrein : Form
    {

        public Train train = new Train();
        Animal leeuw = new Animal("Leeuw", Animal.Diet.Carnivoor, Animal.Points.Middel);
        Animal olifant = new Animal("Olifant", Animal.Diet.Herbivoor, Animal.Points.Groot);
        Animal aap = new Animal("Aap", Animal.Diet.Herbivoor, Animal.Points.Middel);
        Animal konijn = new Animal("Konijn", Animal.Diet.Herbivoor, Animal.Points.Klein);
        Animal zeehond = new Animal("Zeehond", Animal.Diet.Carnivoor, Animal.Points.Middel);
        Animal parakiet = new Animal("Parakiet", Animal.Diet.Herbivoor, Animal.Points.Klein);
   
        public Circustrein()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Animal animal in train.animals)
            {
                train.vleesCheck(animal);
            }
           
            ShowWagons();
          
        }
      
       
        public void ShowWagons()
        {
            foreach (Wagon wagon in train.Wagons)
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
       
       
        
        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            train.animals.Add(leeuw);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            train.animals.Add(olifant);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            train.animals.Add(aap);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            train.animals.Add(konijn);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            train.animals.Add(zeehond);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            train.animals.Add(parakiet);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBoxAnimals_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
