using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Range_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnchech_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (int.TryParse(txtInput.Text.Trim(), out int number))
                {
                    // Check range between 1 and 10
                    if (number >= 1 && number <= 10)
                    {
                        lblDecision.Text = "The number is within the range 1 through 10.";
                    }
                    else
                    {
                        lblDecision.Text = " The number is OUTSIDE the range 1 through 10.";
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid integer number.", "Input Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtInput.Focus();
                    txtInput.SelectAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            lblDecision.Text = string.Empty;
            txtInput.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
