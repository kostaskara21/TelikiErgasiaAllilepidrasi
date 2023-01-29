using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TelikiErgasiaAllilepidrasi
{



    public partial class Form1 : Form    
    {
       

        public Form1()
        {
            InitializeComponent();
           

        }

      




        private void Form1_Load(object sender, EventArgs e)
        {

            
            
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            
            Form2 form =new Form2();
            form.Show();
            
        }

      

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
