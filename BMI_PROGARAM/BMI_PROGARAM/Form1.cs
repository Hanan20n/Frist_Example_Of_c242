using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_PROGARAM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtWeight.Text, out double weight))
            {
                MessageBox.Show("Invalid input! Please enter a numeric value.", "Input Error");
                txtWeight.Focus();
                return;
            }

            if (!double.TryParse(txtHeight.Text, out double height))
            {
                MessageBox.Show("Invalid input! Please enter a numeric value.", "Input Error");
                txtHeight.Focus();
                return;
            }

            // Negative values
            if (weight <= 0 || height <= 0)
            {
                MessageBox.Show("Invalid input! Weight and height must be positive values.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xisaabinta BMI
            double bmi = weight / (height * height);

            // Qaybta (Category)
            string category = "";
            if (bmi < 18.5)
            {
                category = "Underweight";
            }
            else if (bmi <= 25)
            {
                category = "Optimal weight";
            }
            else
            {
                category = "Overweight";
            }

            // Soo bandhigida Natiijada
            txtbmi.Text = bmi.ToString("F2");
            lblBMIResult.Text = $"BMI Result: {bmi:F2}\nCategory: {category}";
        }

        private void bntclear_Click(object sender, EventArgs e)
        {

            txtWeight.Clear();
            txtHeight.Clear();
            txtbmi.Clear();
            lblBMIResult.Text = "";
            txtWeight.Focus();

        }

        private void bntclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}