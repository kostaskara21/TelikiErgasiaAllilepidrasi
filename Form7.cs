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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        int add = 25;
        private void button1_Click(object sender, EventArgs e)
        {
            add += 25;
            button3.Enabled = true;
            if (add <= 100)
            {
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

        private void button3_Click(object sender, EventArgs e)
        {
            add -= 25;
            button1.Enabled = true; ;
            if (add >= 0)
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
    }
}
