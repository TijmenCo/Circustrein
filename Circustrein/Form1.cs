﻿using System;
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
        
      public List<Wagon> wagons = new List<Wagon>();
      public List<Dier> wachtrij = new List<Dier>();
      public List<Dier> dieren = new List<Dier>();
      public  List<Dier> vleeseters = new List<Dier>();
      public  List<Dier> planteters = new List<Dier>();
        Dier leeuw = new Dier("Leeuw", "Vlees", 3);
        Dier olifant = new Dier("Olifant", "Plant", 5);
        Dier aap = new Dier("Aap", "Plant", 2);
        Dier konijn = new Dier("Konijn", "Plant", 1);
        Dier zeehond = new Dier("Zeehond", "Vlees", 2);
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

            vleeseters = dieren.Where(p => p.Diet == "Vlees").ToList();
            planteters = dieren.Where(p => p.Diet == "Plant").ToList();
            VleesCheck();
            foreach(Wagon wagon in wagons)
            {
                listBox4.Items.Add(wagon);
                foreach (Dier dier in wagon.DierenInWagon)
                {
                    listBox1.Items.Add(dier);
                }
            }
          
          
            listBox1.DisplayMember = "Info";
            listBox2.DataSource = vleeseters;
            listBox2.DisplayMember = "Info";
            listBox3.DataSource = planteters;
            listBox3.DisplayMember = "Info";
            
            listBox4.DisplayMember = "WagonInfo";





        }
        public void VleesCheck()
        {
        
            var goodVleeseters = vleeseters.Where(z1 => planteters.Any(z2 => z1.Points < z2.Points));
            var goodPlanteters = planteters.Where(y1 => vleeseters.Any(y2 => y1.Points > y2.Points));
            if (!goodPlanteters.Any())
            {
                foreach (Dier dier in goodVleeseters)
                {
                    //new wagon
                    Wagon wagon = new Wagon(10);
                    wagons.Add(wagon);
                    //add animals to list in wagon
                    wagon.DierenInWagon.Add(dier);
                  //  vleeseters.Remove(dier);
                }
            }
            else
            {
                Wagon wagon = new Wagon(10);
                wagons.Add(wagon);
                //create new wagon
                foreach (Dier dier in goodPlanteters)
                {
                    if (wagon.capacity > 0)
                    {
                        wagon.DierenInWagon.Add(dier);
                        wagon.capacity -= dier.Points;
                      //  planteters.Remove(dier);
                    }
                    foreach (Dier dier2 in goodVleeseters)
                    {
                        if (wagon.capacity > 0)
                        {
                            wagon.DierenInWagon.Add(dier2);
                            wagon.capacity -= dier2.Points;
                         //   vleeseters.Remove(dier2);
                        }

                    }

                }
            }
            plantenCheck();
            /*
            for (int i = 0; i <= count; i++)
            {


                //  var query = planteters.Any(p => p.Points > vleeseters.Points);
                var query1 = vleeseters.Where(dir1 => planteters.Any(dir2 => dir2.Points > dir1.Points));
                var query2 = planteters.Where(x1 => vleeseters.Any(x2 => x1.Points > x2.Points));


                foreach (Dier dir1 in query1)
                {
                    var vdier = dir1;
                    wachtrij.Add(dir1);
                    vleeseters.Remove(dir1);
                    break;
                }
                foreach (Dier x1 in query2)
                {
                    var pdier = x1;
                    wachtrij.Add(x1);
                    planteters.Remove(x1);
                    break;
                }
                puntencheck();
            } 

        }
        */
        }
        public void plantenCheck()
        {
            Wagon wagon = new Wagon(10);
            wagons.Add(wagon);
            foreach (Dier dier in planteters)
            {
                if (wagon.capacity >= 0)
                {
                    if (planteters.Any())
                    {
                        wagon.DierenInWagon.Add(dier);
                        wagon.capacity -= dier.Points;
                    //    planteters.Remove(dier);
                    }
                }
                else
                {
                    if (planteters.Any())
                    {
                        Wagon wagon2 = new Wagon(10);
                        wagons.Add(wagon);
                    }
                }

            }
        }
     
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dieren.Add(leeuw);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            dieren.Add(olifant);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            dieren.Add(aap);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            dieren.Add(konijn);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            dieren.Add(zeehond);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            dieren.Add(parakiet);
        }
    }
}
