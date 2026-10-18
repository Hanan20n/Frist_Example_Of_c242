using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Ticket_Booking_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Clear previous output display
            lstBookingDetails.Items.Clear();

            // 1. Validation using TryParse for numeric fields
            if (!int.TryParse(txtPassengerAge.Text, out int passengerAge))
            {
                MessageBox.Show("Please enter a valid integer for Passenger Age.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassengerAge.Focus();
                return;
            }

            if (!int.TryParse(txtNumTickets.Text, out int numTickets))
            {
                MessageBox.Show("Please enter a valid integer for Number of Tickets.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumTickets.Focus();
                return;
            }

            if (!double.TryParse(txtBaggageWeight.Text, out double baggageWeight))
            {
                MessageBox.Show("Please enter a valid number for Baggage Weight.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBaggageWeight.Focus();
                return;
            }

            string passengerName = txtPassengerName.Text.Trim();
            if (string.IsNullOrEmpty(passengerName))
            {
                MessageBox.Show("Passenger Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassengerName.Focus();
                return;
            }

            // 2. Business and Booking Rules Validation
            bool bookingApproved = true;
            string rejectionReason = string.Empty;

            // Age must be between 1 and 100
            if (passengerAge < 1 || passengerAge > 100)
            {
                bookingApproved = false;
                rejectionReason = "Passenger age must be between 1 and 100 years.";
            }
            // Number of tickets must be between 1 and 5
            else if (numTickets < 1 || numTickets > 5)
            {
                bookingApproved = false;
                rejectionReason = "Number of tickets must be between 1 and 5.";
            }
            // Baggage weight cannot be negative and cannot exceed 50 kg per passenger
            else if (baggageWeight < 0 || baggageWeight > (50 * numTickets))
            {
                bookingApproved = false;
                rejectionReason = "Baggage weight cannot be negative and cannot exceed 50 kg per passenger.";
            }
            // Passengers below 12 cannot book First Class
            else if (passengerAge < 12 && rdoFirstClass.Checked)
            {
                bookingApproved = false;
                rejectionReason = "Booking Rejected: Passengers below 12 years old cannot book First Class.";
            }

            // 3. Handle Rejection Display
            if (!bookingApproved)
            {
                lstBookingDetails.Items.Add("=== BOOKING STATUS: REJECTED ===");
                lstBookingDetails.Items.Add($"Reason: {rejectionReason}");
                MessageBox.Show(rejectionReason, "Booking Rejected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. Cost Calculation Rules
            // Base ticket price configuration based on class selection
            decimal baseTicketPrice = 100.00m; // Standard base price unit
            string travelClassStr = "Normal Class";

            if (rdoFirstClass.Checked)
            {
                baseTicketPrice = 250.00m;
                travelClassStr = "First Class";
            }
            else if (rdoBusinessClass.Checked)
            {
                baseTicketPrice = 180.00m;
                travelClassStr = "Business Class";
            }
            else if (rdoFirstClass.Checked)
            {
                baseTicketPrice = 100.00m;
                travelClassStr = "Normal Class";
            }

            // Basic Ticket Cost = Ticket Price x Number of Tickets
            decimal basicTicketCost = baseTicketPrice * numTickets;
            decimal totalDiscountRate = 0.00m;
            decimal ticketDiscountAmount = 0.00m;

            // Ticket Volume Discounts
            if (numTickets >= 3 && numTickets <= 4)
            {
                totalDiscountRate += 0.05m; // 5% discount
            }
            else if (numTickets == 5)
            {
                totalDiscountRate += 0.10m; // 10% discount
            }

            // Age-based Discounts
            if (passengerAge < 12)
            {
                totalDiscountRate += 0.20m; // 20% child discount
            }
            else if (passengerAge >= 60)
            {
                totalDiscountRate += 0.10m; // 10% senior discount
            }

            // Calculate discount value from subtotal
            ticketDiscountAmount = basicTicketCost * totalDiscountRate;
            decimal discountedTicketTotal = basicTicketCost - ticketDiscountAmount;

            // Travel Insurance Calculation ($25 per ticket if selected)
            decimal insuranceTotal = 0.00m;
            if (chkTravelInsurance.Checked)
            {
                insuranceTotal = 25.00m * numTickets;
            }

            // Baggage Fee Calculation (Free up to 20 kg per passenger, $5 per extra kg total pool over limit)
            double allowedFreeBaggage = 20.00 * numTickets;
            decimal extraBaggageFee = 0.00m;
            if (baggageWeight > allowedFreeBaggage)
            {
                double excessKg = baggageWeight - allowedFreeBaggage;
                extraBaggageFee = (decimal)excessKg * 2.00m; // $2 per extra kg over allowance
            }

            // Final Total Calculation
            decimal finalTotalCost = discountedTicketTotal + insuranceTotal + extraBaggageFee;

            // 5. Display Details in Output View
            lstBookingDetails.Items.Add("=== AIRLINE TICKET BOOKING DETAILS ===");
            lstBookingDetails.Items.Add($"Passenger Name: {passengerName}");
            lstBookingDetails.Items.Add($"Passenger Age: {passengerAge} years");
            lstBookingDetails.Items.Add($"Travel Class: {travelClassStr}");
            lstBookingDetails.Items.Add($"Number of Tickets: {numTickets}");
            lstBookingDetails.Items.Add($"Baggage Weight: {baggageWeight} kg");
            lstBookingDetails.Items.Add("--------------------------------------------------");
            lstBookingDetails.Items.Add($"Basic Ticket Cost: ${basicTicketCost:N2}");
            lstBookingDetails.Items.Add($"Applied Discounts: {totalDiscountRate * 100}% (-${ticketDiscountAmount:N2})");
            lstBookingDetails.Items.Add($"Travel Insurance: ${(chkTravelInsurance.Checked ? insuranceTotal : 0):N2}");
            lstBookingDetails.Items.Add($"Extra Baggage Fee: ${extraBaggageFee:N2}");
            lstBookingDetails.Items.Add("--------------------------------------------------");
            lstBookingDetails.Items.Add($"FINAL TOTAL COST: ${finalTotalCost:N2}");
            lstBookingDetails.Items.Add("Booking Status: Approved");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Reset input fields and output
            txtPassengerName.Clear();
            txtPassengerAge.Clear();
            txtNumTickets.Clear();
            txtBaggageWeight.Clear();
            rdoNormalClass.Checked = true;
            chkTravelInsurance.Checked = false;
            lstBookingDetails.Items.Clear();
            txtPassengerName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the application
            this.Close();
        }
    }
}
