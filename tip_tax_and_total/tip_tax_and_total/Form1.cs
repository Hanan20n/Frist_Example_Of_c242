using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tip_tax_and_total
{
    public partial class txtFood : Form
    {
        public txtFood()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalculute_Click(object sender, EventArgs e)
        {

        }

        private void btncalculute_Click_1(object sender, EventArgs e)
        {
            try
            {
                // 1. Convert string to double 
                double price1 = Convert.ToDouble(txtPrice1.Text);
                double price2 = Convert.ToDouble(txtPrice2.Text);

                // 2. Hubinta in eysan ahayn tiro laga yar yahay 0
                if (price1 < 0 || price2 < 0)
                {
                    lblreaselt.ForeColor = Color.Red;
                    lblreaselt.Text = "Qiimuhu ma noqon karo tiro ka yar 0!";
                    return;
                }

                // 3. Xisaabinta: Subtotal, 10% Tax, iyo Total
                double subtotal = price1 + price2;
                double taxRate = 0.10; // 10% tax
                double salesTax = subtotal * taxRate;
                double total = subtotal + salesTax;

                // 4. Ku muujinta natiijada hal Label
                lblreaselt.ForeColor = Color.Black;
                lblreaselt.Text = $"Sales Tax = {salesTax}  |  Total = {total}";
            }
            catch (FormatException)
            {
                // Qaybtaan waxay qabanaysaa marka uu isticmaaluhu geliya xarfo/string
                lblreaselt.ForeColor = Color.Red;
                lblreaselt.Text = "Fadlan geli tiro sax ah oo qiimaha ah (Nambaro kaliya)!";
            }
            catch (Exception ex)
            {
                // Qaybtaan waxay qabanaysaa wixii maamul dhibato ah oo kale
               lblreaselt.ForeColor = Color.Red;
               lblreaselt.Text = "Cilad ayaa dhacday: " + ex.Message;
            }
        }
    }
}
