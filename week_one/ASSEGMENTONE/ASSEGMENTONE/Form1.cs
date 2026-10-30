using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASSEGMENTONE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showinformation_Click(object sender, EventArgs e)
        {
            //creating variiable to store using input

            string studentname, department, fullinformation;
               int  studentid,  semester ;

            studentname = txtname.Text;
            studentid = int.Parse(txtstudentid.Text);
            department = txtdepertment.Text;
            semester = int.Parse(txtsemester.Text);

            //process to concatanition studentname + studentid + departmentt + semester
            fullinformation = studentname + " " + studentid + " " + department + " " + semester;



            //display the input in labal

            lbloutput.Text = fullinformation;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            // claer you are information
            txtname.Clear();
            txtstudentid.Clear();   
            txtdepertment.Clear();  
            txtsemester.Clear();
            lbloutput.Text = "";
        }
    }
}
