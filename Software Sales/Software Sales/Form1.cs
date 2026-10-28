using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Sales
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        // dhamaan meesha laga cisaabinaayo shaqada aan soo qabtay
        private void btncalculate_Click(object sender, EventArgs e)
        {

          
            // Variable-yada loogu talagalay quantity iyo price
            int quantity;
            int pricePerPackage;

            // xaqiiji in number of package uu yahay nambar sax ah uuna yeelaynin tiro  negative ah
            if (!int.TryParse(txtPackages.Text, out quantity) || quantity < 0)
            {
                MessageBox.Show("Fadlan geli nambar sax ah oo aan negative aheyn (Packages)!");
                txtPackages.Clear();
                txtPackages.Focus();
                return;
            }

            //  xaqiiji in txtpriceperpackage uu yahay nambar sax ah uuna yeelaynin tiro  negative ah
            if (!int.TryParse(txtpriceperpackage.Text, out pricePerPackage) || pricePerPackage < 0)
            {
                MessageBox.Show("Fadlan geli nambar sax ah oo aan negative aheyn (Price)!");
                txtpriceperpackage.Clear();
                txtpriceperpackage.Focus();
                return;
            }

            // Qiimaha caadiga ah ee hal package
            double packagePrice = 99.00;
            double discountRate = 0.0;

            // patrs of discount
            if (quantity >= 10 && quantity <= 19)
            {
                discountRate = 0.20; // waxaa helee qiimo dhis dhan  20%
            }
            else if (quantity >= 20 && quantity <= 49)
            {
                discountRate = 0.30; // waxaa helee qiimo dhis dhan  30%
            }
            else if (quantity >= 50 && quantity <= 99)
            {
                discountRate = 0.40; // waxaa helee qiimo dhis dhan  40%
            }
            else if (quantity >= 100)
            {
                discountRate = 0.50; 
            }

            else
            {
                discountRate = 0.0; // Inta u dhaxaysa 1-9 malahan wax qiimo dhimis ah
            }

            // Xisaabinta guud ee lacagta
            double subtotal = quantity * packagePrice;
            double discountAmount = subtotal * discountRate;
            double totalAmount = subtotal - discountAmount;

            // Soo bandhigida natiijada ee ListBox-ka
            lstResults.Items.Clear();
            lstResults.Items.Add("---- Software Sales Results ----");
            lstResults.Items.Add("Number of Packages : " + quantity);
            lstResults.Items.Add("Price per Package : $" + packagePrice.ToString("N2"));
            lstResults.Items.Add("Subtotal (Before Discount) : $" + subtotal.ToString("N2"));
            lstResults.Items.Add("Discount Rate : " + (discountRate * 100) + "%");
            lstResults.Items.Add("Discount Amount : $" + discountAmount.ToString("N2"));
            lstResults.Items.Add("Total Amount (After Discount) : $" + totalAmount.ToString("N2"));

        }
        // tirtirida ama nadiifinta (Clear Button)
        private void btncleare_Click(object sender, EventArgs e)
        {
            lstResults.Items.Clear();
            txtPackages.Clear();
            txtpriceperpackage.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }  
    
