using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
//creating variable  to store user input 
string firstname,secondname,fullname;

            firstname=txtone.Text;
            secondname=txbtwo.Text;

            //process to concatanition fristname +secondname 

            fullname=firstname+" "+secondname;

            //display the input using labal

            guji.Text = fullname;
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
