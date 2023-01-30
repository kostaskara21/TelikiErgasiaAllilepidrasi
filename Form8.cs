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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            
        }
        
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.horseUp;
            pictureBox7.Location = new Point(pictureBox7.Location.X, pictureBox7.Location.Y - 20) ;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.Horse;
            pictureBox7.Location = new Point(pictureBox7.Location.X + 20, pictureBox7.Location.Y);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.horseFlip;
            pictureBox7.Location = new Point(pictureBox7.Location.X - 20, pictureBox7.Location.Y);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.HorseDown;
            pictureBox7.Location = new Point(pictureBox7.Location.X , pictureBox7.Location.Y + 20);

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            pictureBox5.Visible = false;
            pictureBox4.Visible = false;
            pictureBox3.Visible = false;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.Visible = false;
            pictureBox9.Visible = false;
            pictureBox6.Visible = true;
            pictureBox5.Visible = true;
            pictureBox4.Visible = true;
            pictureBox3.Visible = true;

        }
    }
}
