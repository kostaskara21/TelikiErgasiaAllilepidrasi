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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        //STATHMI NEROU ++
        int add = 25;
        private void button1_Click(object sender, EventArgs e)
        {
            add += 25;
            button3.Enabled = true;
            if (add <= 100) {
                if (add > 75)
                {
                    label3.Text = "100" + "%";
                    MessageBox.Show("You have reached the Maximum Water level");
                    button1.Enabled = false;
                }
                else
                {
                    label3.Text = add.ToString() + "%";
                }
            }
                         
        }


        //STATHMI NEROU --
        private void button3_Click(object sender, EventArgs e)
        {
            add -= 25;
            button1.Enabled = true; ;
            if (add >=0)
            {
                if (add < 25)
                {
                    label3.Text = "0" + "%";
                    MessageBox.Show("You have reached the Min Water level");
                    button3.Enabled = false;
                }
                label3.Text = add.ToString() + "%";
            }
            
        }



        //gia na anoijoume kai na klieosume tin tv
        int pooltvcount = 1;
        private void button2_Click(object sender, EventArgs e)
        {
            pooltvcount++;
            if (pooltvcount % 2 == 0)
            {
                pictureBox3.Visible = true;
            }
            else
            {
                pictureBox3.Visible = false;
            }
        }

        int CountHeat = 25;
        private void button5_Click(object sender, EventArgs e)
        {
            CountHeat++;

            button4.Enabled = true;

            if (CountHeat > 44)
            {
                MessageBox.Show("You have reahed the Max Heat");
                button5.Enabled = false;
            }

            label4.Text = CountHeat.ToString() + "°C";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CountHeat--;

            button5.Enabled = true;

            if (CountHeat < 1)
            {
                MessageBox.Show("You have riched the Min Heat");
                button4.Enabled = false;
            }

            label4.Text = CountHeat.ToString() + "°C";
        }

        //gia aistitira
        int Sensor = 1;
        private void button6_Click(object sender, EventArgs e)
        {
            button7.Enabled = true;
            Sensor++;
            if (Sensor % 2 == 0)
            {
                MessageBox.Show("Sensor is On");
                button6.BackColor = Color.Green;
                Random random = new Random();
                int test = random.Next(0, 2);
                if (test == 0)
                {
                    MessageBox.Show("People in the Pool!!!");
                    button7.Enabled = false;
                }
                else
                {
                    MessageBox.Show("There is not people in the pool");
                    MessageBox.Show("Alarm is On");
                    button7.BackColor = Color.Green;
                }
            }
            else
            {
                MessageBox.Show("sensor is Off");
                button6.BackColor = Color.Transparent;
                button7.BackColor = Color.Transparent;
                button7.Enabled = false;
            }
        }

        
        private void button7_Click(object sender, EventArgs e)
        {
                  
            MessageBox.Show("Alarm is Off");
            button7.BackColor = Color.Transparent;

        }
    }
}
