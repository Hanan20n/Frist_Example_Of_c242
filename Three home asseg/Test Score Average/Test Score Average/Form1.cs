using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Score_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double score1, score2, score3;

                // Validation-ka iyadoo la isticmaalayo if / else if
                if (!double.TryParse(txtScore1.Text, out score1))
                {
                    MessageBox.Show("Fadlan geli tiro sax ah: Imtixaanka #1", "Input Error");
                    txtScore1.Focus();
                }
                else if (!double.TryParse(txtScore2.Text, out score2))
                {
                    MessageBox.Show("Fadlan geli tiro sax ah: Imtixaanka #2", "Input Error");
                    txtScore2.Focus();
                }
                else if (!double.TryParse(txtScore3.Text, out score3))
                {
                    MessageBox.Show("Fadlan geli tiro sax ah: Imtixaanka #3", "Input Error");
                    txtScore3.Focus();
                }
                else
                {
                    // Xisaabi celceliska
                    double average = (score1 + score2 + score3) / 3.0;

                    // Ku muuji label-ka
                    lblAverage.Text = average.ToString("F1");
                }
            }
            // 2. Catch-ku wuxuu qabanayaa wixii error ah ee dhaca waqtiga shaqada
            catch (Exception ex)
            {
                MessageBox.Show("Waxaa dhacay error aan la filyan: " + ex.Message, "System Error");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Nadiifi textbox-yada iyo label-ka
            txtScore1.Clear();
            txtScore2.Clear();
            txtScore3.Clear();
            lblAverage.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
// Xir barnaamijka
            Application.Exit();
        }
    }
}

