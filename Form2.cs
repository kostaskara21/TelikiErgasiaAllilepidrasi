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
    public partial class Form2 : Form
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




        int Count; //xrisimopoiite gia na jeroume pote klini i forma oste stin proti forma na ekteleite h antistixi energia 

        public Form2()
        {
            InitializeComponent();
            
            this.FormBorderStyle = FormBorderStyle.None; // gia na gini round to menu 
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20)); //gia na gini round to menu 
        }


        private void Form2_Load(object sender, EventArgs e)
        {
           
        }



        //to X gia na kleisi
        private void pictureBox1_Click(object sender, EventArgs e) 
        {
            this.Close();
            
        }



        // to check gia na gini confirm 
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
           


            //pername to count stin 1h forma meso constructor pou ftiajame
            Form f3=new Form3();
            f3.Show();
           


            //klinoume auti tin forma 
            this.Close();
        }
    }
}
