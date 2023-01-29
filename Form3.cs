using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelikiErgasiaAllilepidrasi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        //button gia on off fota 
        int Count=1;
        private void button1_Click(object sender, EventArgs e)
        {
            Count++;
            if (Count%2==0) 
            {
                this.BackgroundImage = Properties.Resources.room1;
            }
            else
            {
                this.BackgroundImage = Properties.Resources.roomdark;
            }
            
            

        }

        //button gia on off tv 
        int CountTv = 1;
        private void button2_Click(object sender, EventArgs e)
        {

            CountTv++;
            if (CountTv % 2 == 0)
            {
                button5.Enabled = false; // otan paizei tv den mporoume na akousoume mousiki prepei na kleisoume tin tv opote kanoume to koumpi disable

                pictureBox3.Visible = true;
                pictureBox3.BackgroundImage = Properties.Resources.news;
            }
            else
            {
                button5.Enabled = true; //afou sklisame tin tv kanoume to koumpi tis mousikis enable 

                pictureBox3.Visible = false;
                
            }
           
        }


        // heat gia ++
        int CountHeat = 24;
        private void button3_Click(object sender, EventArgs e)
        {
            CountHeat++;

            button4.Enabled = true;

            if (CountHeat > 44)
            {
                MessageBox.Show("You have reahed the Max Heat");
                button3.Enabled = false;
            }

            label1.Text = CountHeat.ToString()+ "°C";
        }

        //heat gia --
        private void button4_Click(object sender, EventArgs e)
        {
            CountHeat--;

            button3.Enabled = true;

            if (CountHeat <-4)
            {
                MessageBox.Show("You have riched the Min Heat");
                button4.Enabled = false;
            }

            label1.Text = CountHeat.ToString() + "°C";
        }


        //button gia on of music
        int CountMusic = 1;
        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;

            CountMusic++;
            if (CountMusic % 2 == 0)
            {
                pictureBox3.Visible = true;
                button2.Enabled = false; // prepei na klisoume tin mousiki gia na anoijoume Tv opote to koumpi tis tv einai disable
                pictureBox3.BackgroundImage = Properties.Resources.Spotify;
            }
            else
            {
                button2.Enabled = true; // prepei na klisoume tin mousiki gia na anoijoume Tv opote afou tin klisame to koumpi tis tv einai enable 
                pictureBox3.Visible = false;

            }
           
        }



        //button gia na pame sto menu tis idiotikis  pisinas 
        private void button7_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }


        int Camera = 1;
        private void button6_Click(object sender, EventArgs e)
        {
            Camera++;
            if(Camera%2 == 0)
            {
                pictureBox5.Visible = true;
            }
            else
            {
                pictureBox5.Visible = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            Form6 f6 = new Form6();
            f6.Show();
        }
    }
}
