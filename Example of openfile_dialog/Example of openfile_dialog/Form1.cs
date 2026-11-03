using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_of_openfile_dialog
{
    public partial class Form1 : Form
    {
        // Store the selected file path
        string currentFilePath = "";

        public Form1()
        {
            InitializeComponent();

            // Set Open File Dialog properties
            openFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            // Set Save File Dialog properties
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog1.DefaultExt = "txt";
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            // Open file dialog
            DialogResult result;

            result = openFile.ShowDialog();

            // Check user selection
            if (result == DialogResult.OK)
            {
                // Store selected file path
                currentFilePath = openFile.FileName;

                // Clear old items from ListBox
                listBox1.Items.Clear();

                // Open the selected file for reading
                using (StreamReader reader = File.OpenText(currentFilePath))
                {
                    string lines;

                    // Read file line by line
                    while ((lines = reader.ReadLine()) != null)
                    {
                        // Display each line in ListBox
                        listBox1.Items.Add(lines);
                    }
                }

                MessageBox.Show("File opened successfully");
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("File not opened");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
             // Creating and writing file

    string data;
    StreamWriter writes;
    DialogResult result;

    // Get user input
    data = textBox1.Text;

    if (data != "")
    {
        // Select file
        result = saveFileDialog1.ShowDialog();

        if (result == DialogResult.OK)
        {
            // Append data to file
            writes = File.AppendText(saveFileDialog1.FileName);

            // Write user input
            writes.WriteLine(data);

            // Close file
            writes.Close();

            // Display data in ListBox
            listBox1.Items.Add(data);

            // Clear TextBox
            textBox1.Clear();

            MessageBox.Show("Data saved successfully");
        }
    }
    else
    {
        MessageBox.Show("Please enter your data");
    }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear TextBox
            textBox1.Clear();

            // Clear ListBox
            listBox1.Items.Clear();

            // Do not delete the saved file
            MessageBox.Show("Data cleared successfully");
        }
    }
}
