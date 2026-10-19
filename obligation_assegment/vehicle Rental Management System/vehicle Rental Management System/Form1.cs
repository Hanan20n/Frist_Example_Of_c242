using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace vehicle_Rental_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Clear previous results in the ListBox
            lstresults.Items.Clear();

            // 1. Validate Customer Name
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Fadlan geli magaca macaamiisha (Customer Name).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerName.Focus();
                return;
            }
            string customerName = txtCustomerName.Text.Trim();

            // 2. Validate Numeric Inputs using TryParse
            int customerAge, rentalDays, drivingExperience;

            if (!int.TryParse(txtCustomerAge.Text, out customerAge))
            {
                MessageBox.Show("Da'du waa inay noqotaa tiro sax ah (Numeric value).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerAge.Focus();
                return;
            }

            if (!int.TryParse(txtRentalDays.Text, out rentalDays))
            {
                MessageBox.Show("Tirada maalmaha kireyntu waa inay noqotaa tiro sax ah.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRentalDays.Focus();
                return;
            }

            if (!int.TryParse(txtDrivingExperience. Text, out drivingExperience))
            {
                MessageBox.Show("Khibradda wadista waa inay noqotaa tiro sax ah.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDrivingExperience.Focus();
                return;
            }

            // 3. Range Validations & Eligibility Rules
            if (customerAge < 18 || customerAge > 80)
            {
                MessageBox.Show("Da'da macaamiishu waa inay u dhaxeyso 18 iyo 80 sano.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerAge.Focus();
                return;
            }

            if (rentalDays < 1 || rentalDays > 30)
            {
                MessageBox.Show("Tirada maalmaha kireyntu waa inay u dhaxeyso 1 iyo 30 maalmood.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               txtRentalDays.Focus();
                return;
            }

            if (drivingExperience < 0)
            {
                MessageBox.Show("Khibradda wadista ma noqon karto mid taban (Negative).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDrivingExperience.Focus();
                return;
            }

            // --- ELIGIBILITY CHECKS ---
            if (customerAge < 21)
            {
                DisplayRejection("Macmiilku wuxuu ka yar yahay 21 sano, mana lahan xaqa kireynta gawaarida.");
                return;
            }

            if (drivingExperience < 1)
            {
                DisplayRejection("Macmiilku wuxuu u baahan yahay ugu yaraan 1 sano oo khibrad wadid ah.");
                return;
            }

            // 4. Vehicle Type Selection & Rates
            string vehicleType = "";
            decimal dailyRate = 0m;

            if (rbEconomy.Checked)
            {
                vehicleType = "Economy";
                dailyRate = 35m;
            }
            else if (rbSUV.Checked)
            {
                vehicleType = "SUV";
                dailyRate = 60m;
            }
            else if (rbLuxury.Checked)
            {
                vehicleType = "Luxury";
                dailyRate = 100m;

                // Luxury vehicle special requirements: at least 25 years old and 3 years driving experience
                if (customerAge < 25 || drivingExperience < 3)
                {
                    DisplayRejection("Gaadhiga Luxury wuxuu u baahan yahay ugu yaraan 25 sano oo da' ah iyo 3 sano oo khibrad ah.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Fadlan dooro Nooca Gaadhiga (Vehicle Type).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 5. Cost Calculations & Rules
            decimal basicRentalCost = dailyRate * rentalDays;

            // Discount calculations
            decimal discount = 0m;
            if (rentalDays >= 14)
            {
                discount = basicRentalCost * 0.10m; // 10% discount for 14 or more days
            }
            else if (rentalDays >= 7)
            {
                discount = basicRentalCost * 0.05m; // 5% discount for 7-13 days
            }

            // Insurance Option ($15 per day if checked)
            decimal insuranceCost = 0m;
            if (chkinsurance.Checked)
            {
                insuranceCost = 15m * rentalDays;
            }

            // Young Driver Surcharge (Age 21-24: Add 10% of basic rental cost)
            decimal youngDriverSurcharge = 0m;
            if (customerAge >= 21 && customerAge <= 24)
            {
                youngDriverSurcharge = basicRentalCost * 0.10m;
            }

            // Final Rental Cost Calculation
            decimal finalRentalCost = (basicRentalCost - discount) + insuranceCost + youngDriverSurcharge;

            // 6. Display Results in ListBox (`lstresults`)
            lstresults.Items.Add("=== RENTAL DETAILS ===");
            lstresults.Items.Add($"Customer Name : {customerName}");
            lstresults.Items.Add($"Customer Age : {customerAge}");
            lstresults.Items.Add($"Driving Experience : {drivingExperience} years");
            lstresults.Items.Add($"Vehicle Type : {vehicleType} (${dailyRate}/day)");
            lstresults.Items.Add($"Rental Days : {rentalDays}");
            lstresults.Items.Add($"Basic Rental Cost : ${basicRentalCost:F2}");
            lstresults.Items.Add($"Discount : -${discount:F2}");
            lstresults.Items.Add($"Insurance Cost : ${insuranceCost:F2}");
            lstresults.Items.Add($"Young Driver Surcharge: ${youngDriverSurcharge:F2}");
            lstresults.Items.Add("----------------------------------------");
            lstresults.Items.Add($"Final Rental Cost : ${finalRentalCost:F2}");
            lstresults.Items.Add("Rental Status : Approved");
        }

        private void DisplayRejection(string reason)
        {
            lstresults.Items.Add("=== RENTAL DETAILS ===");
            lstresults.Items.Add($"Customer Name : {txtCustomerName.Text}");
            lstresults.Items.Add("Rental Status : REJECTED");
            lstresults.Items.Add($"Reason : {reason}");
            MessageBox.Show(reason, "Booking Rejected");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all input fields and results
            txtCustomerName.Clear();
            txtCustomerAge.Clear();
            txtRentalDays.Clear();
            txtDrivingExperience.Clear();
            rbEconomy.Checked = false;
            rbSUV.Checked = false;
            rbLuxury.Checked = false;
            chkinsurance.Checked = false;
            lstresults.Items.Clear();
            txtCustomerName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the application
            this.Close();
        }
    }
}