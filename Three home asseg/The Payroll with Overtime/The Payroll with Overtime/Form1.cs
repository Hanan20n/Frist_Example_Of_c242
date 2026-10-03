using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Payroll_with_Overtime
{
    public partial class Form1 : Form
    {
        private const decimal BASE_HOURS = 40.0m;
        private const decimal OVERTIME_RATE = 1.5m;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Nested IF / Validation-ka saacadaha iyo qiimaha saacadda
                if (decimal.TryParse(hoursWorkedTextBox.Text, out decimal hoursWorked) && hoursWorked >= 0)
                {
                    if (decimal.TryParse(hourlyPayRateTextBox.Text, out decimal hourlyPayRate) && hourlyPayRate >= 0)
                    {
                        decimal grossPay;

                        // Xisaabinta mushaarka iyo Overtime-ka
                        if (hoursWorked > BASE_HOURS)
                        {
                            decimal basePay = BASE_HOURS * hourlyPayRate;
                            decimal overtimeHours = hoursWorked - BASE_HOURS;
                            decimal overtimePay = overtimeHours * (hourlyPayRate * OVERTIME_RATE);

                            grossPay = basePay + overtimePay;
                        }
                        else
                        {
                            grossPay = hoursWorked * hourlyPayRate;
                        }

                        // Ku muuji natiijada oo qaab lacag ah (Currency format "C2")
                        grossPayLabel.Text = grossPay.ToString("C2");
                    }
                    else
                    {
                        MessageBox.Show("Fadlan geli tiro sax ah: Hourly Pay Rate", "Input Error");
                        hourlyPayRateTextBox.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Fadlan geli tiro sax ah: Hours Worked", "Input Error");
                    hoursWorkedTextBox.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Waxaa dhacay error: " + ex.Message, "System Error");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            hoursWorkedTextBox.Clear();
            hourlyPayRateTextBox.Clear();
            grossPayLabel.Text = string.Empty;
            hoursWorkedTextBox.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
