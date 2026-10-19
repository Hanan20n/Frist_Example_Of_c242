using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Hotel_Room_Booking_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Clear previous items in ListBox
            lstBookingDetails.Items.Clear();
            //1.Validate Guest Name cannot be empty
            if (string.IsNullOrWhiteSpace(txtGuestName.Text))
            {
                MessageBox.Show("Please enter the Guest Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGuestName.Focus();
                return;
            }

            // 2. Validate all numeric inputs using TryParse
            int guestAge, numberOfNights, numberOfGuests;

            if (!int.TryParse(txtGuestAge.Text, out guestAge))
            {
                MessageBox.Show("Guest Age must be a valid numeric value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGuestAge.Focus();
                return;
            }

            if (!int.TryParse(txtNumNights.Text, out numberOfNights))
            {
                MessageBox.Show("Number of Nights must be a valid numeric value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumNights.Focus();
                return;
            }

            if (!int.TryParse(txtNumGuests.Text, out numberOfGuests))
            {
                MessageBox.Show("Number of Guests must be a valid numeric value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumGuests.Focus();
                return;
            }

            // 3. Range Validations
            if (guestAge < 18 || guestAge > 90)
            {
                MessageBox.Show("Guest age must be between 18 and 90.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGuestAge.Focus();
                return;
            }

            if (numberOfNights < 1 || numberOfNights > 30)
            {
                MessageBox.Show("Number of nights must be between 1 and 30.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumNights.Focus();
                return;
            }

            if (numberOfGuests < 1 || numberOfGuests > 6)
            {
                MessageBox.Show("Number of guests must be between 1 and 6.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumGuests.Focus();
                return;
            }

            // 4. Room Type & Capacity Validation using a boolean flag
            bool isBookingApproved = true;
            string roomType = "";
            decimal ratePerNight = 0m;

            if (rbStandard.Checked)
            {
                roomType = "Standard";
                if (numberOfGuests > 2)
                {
                    isBookingApproved = false;
                    MessageBox.Show("Standard rooms can accommodate a maximum of 2 guests.", "Booking Rejected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (rbNormal.Checked)
            {
                roomType = "Normal";
                if (numberOfGuests > 4)
                {
                    isBookingApproved = false;
                    MessageBox.Show("Normal/Deluxe rooms can accommodate a maximum of 4 guests.", "Booking Rejected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (rbHight.Checked)
            {
                roomType = "Hight";
                if (numberOfGuests > 6)
                {
                    isBookingApproved = false;
                    MessageBox.Show("A Suite can accommodate a maximum of 6 guests.", "Booking Rejected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a Room Type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Stop processing if booking failed capacity checks
            if (!isBookingApproved)
            {
                lstBookingDetails.Items.Add("=== BOOKING REJECTED ===");
                lstBookingDetails.Items.Add("Capacity limit exceeded for selected room type.");
                return;
            }

            // 5. Determine room rate using a switch statement
            switch (roomType)
            {
                case "Standard":
                    ratePerNight = 50m;
                    break;
                case "Normal":
                    ratePerNight = 80m;
                    break;
                case "Hight":
                    ratePerNight = 130m;
                    break;
            }

            // 6. Cost Calculations & Rules
            decimal baseCost = ratePerNight * numberOfNights;
            decimal discountPercentage = 0m;

            // Night-based discounts
            if (numberOfNights >= 5 && numberOfNights <= 9)
            {
                discountPercentage = 0.05m; // 5% discount
            }
            else if (numberOfNights >= 10)
            {
                discountPercentage = 0.12m; // 12% discount
            }

            decimal discountAmount = baseCost * discountPercentage;
            decimal subtotalAfterDiscount = baseCost - discountAmount;

            // Breakfast selected: add $10 per guest per night
            decimal breakfastCost = 0m;
            string breakfastStatus = "No";
            if (chkBreakfast.Checked)
            {
                breakfastCost = 10m * numberOfGuests * numberOfNights;
                breakfastStatus = "Yes";
            }

            // More than 4 guests: add 5% service surcharge
            decimal serviceSurcharge = 0m;
            if (numberOfGuests > 4)
            {
                serviceSurcharge = subtotalAfterDiscount * 0.05m;
            }

            // Guests aged 60 or above: receive an additional 5% senior discount
            decimal seniorDiscount = 0m;
            if (guestAge >= 60)
            {
                seniorDiscount = subtotalAfterDiscount * 0.05m;
            }

            // Final Total Cost
            decimal totalCost = subtotalAfterDiscount + breakfastCost + serviceSurcharge - seniorDiscount;

            // 7. Display Results line by line inside ListBox (lstBookingDetails)
            lstBookingDetails.Items.Add("=== HOTEL BOOKING DETAILS ===");
            lstBookingDetails.Items.Add($"Guest Name: {txtGuestName.Text}");
            lstBookingDetails.Items.Add($"Guest Age: {guestAge} (Senior: {(guestAge >= 60 ? "Yes" : "No")})");
            lstBookingDetails.Items.Add($"Room Type: {roomType} (${ratePerNight}/night)");
            lstBookingDetails.Items.Add($"Number of Nights: {numberOfNights}");
            lstBookingDetails.Items.Add($"Number of Guests: {numberOfGuests}");
            lstBookingDetails.Items.Add($"Breakfast Included: {breakfastStatus}");
            lstBookingDetails.Items.Add("----------------------------------------");
            lstBookingDetails.Items.Add($"Base Cost: ${baseCost:F2}");
            lstBookingDetails.Items.Add($"Discount Applied: -${discountAmount:F2}");
            lstBookingDetails.Items.Add($"Breakfast Surcharge: ${breakfastCost:F2}");
            lstBookingDetails.Items.Add($"Guest Surcharge (>4): ${serviceSurcharge:F2}");
            lstBookingDetails.Items.Add($"Senior Discount (>=60): -${seniorDiscount:F2}");
            lstBookingDetails.Items.Add("----------------------------------------");
            lstBookingDetails.Items.Add($"TOTAL AMOUNT DUE: ${totalCost:F2}");
            lstBookingDetails.Items.Add("Booking Status: Approved");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear inputs and ListBox items
            txtGuestName.Clear();
            txtGuestAge.Clear();
            txtNumNights.Clear();
            txtNumGuests.Clear();
            rbStandard.Checked = false;
            rbNormal.Checked = false;
            rbHight.Checked = false;
            chkBreakfast.Checked = false;
            lstBookingDetails.Items.Clear();
            txtGuestName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}