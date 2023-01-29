using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; // gia na gini i forma round 


namespace TelikiErgasiaAllilepidrasi
{
    public partial class Form6 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")] //gia na gini forma round

        private static extern IntPtr CreateRoundRectRgn   //xrisimopiite i sinartisi auti gia na ftiaxi tin forma na gini round
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Form6()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // gia na gini round to menu 
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20)); //gia na gini round to menu 
        }

       

      



        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //gia ta drinks
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        //gia fagito
        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        //gia ola ston katalogo
        int price = 0;
        private void panel1_Click(object sender, EventArgs e)
        {
            price = price+200;
            label2.Text = price.ToString() + "€";
        }


        //gia na stili tin paragelia 
        private void panel2_Click(object sender, EventArgs e)
        {
            if (price <= 0)
            {
                MessageBox.Show("Your Cart Is Empty");
                label2.Text = 0 + "€";
                price = 0;
            }
            else
            {
                price = price - 200;
                label2.Text = price.ToString() + "€";
            }
        }


        //gia ta button ta - stous katalogous 
        private void button3_Click(object sender, EventArgs e)
        {
            if (price != 0)
            {
                MessageBox.Show("Thank You For Your Order, Your Order Is On The Way  ,Total Price : " + label2.Text);
                price = 0;
                label2.Text = price.ToString() + "€";
                this.Close();

            }
            else
            {
                MessageBox.Show("Your Cart Is Empty ");
            }
        }
    }
}
