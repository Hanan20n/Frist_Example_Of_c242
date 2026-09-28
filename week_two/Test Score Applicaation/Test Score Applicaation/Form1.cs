using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Score_Applicaation
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

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                // Declare variables to store the three scores
                double score1;
                double score2;
                double score3;

                // Declare variables to store total and average
                double total;
                double average;

                // Get Score 1 from the first TextBox
                score1 = double.Parse(txtScore1.Text);

                // Get Score 2 from the second TextBox
                score2 = double.Parse(txtScore2.Text);

                // Get Score 3 from the third TextBox
                score3 = double.Parse(txtScore3.Text);

                // Calculate the total
                total = score1 + score2 + score3;

                // Calculate the average
                average = total / 3;

                // Display the total
                lblTotal.Text = total.ToString();

                // Display the average with 2 decimal places
                lblavrg.Text = average.ToString("n2");
            }
            catch (Exception ex)
            {
                // Display an error message if invalid data is entered
                MessageBox.Show(
                    "Please enter valid numbers.\n\nError: " + ex.Message,
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
