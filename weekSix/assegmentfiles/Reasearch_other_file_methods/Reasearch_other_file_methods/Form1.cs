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

namespace Reasearch_other_file_methods
{
    public partial class Form1 : Form
    {
        private string filePath = @"D:\c#\Frist_Example_Of_c242\assegmentfiles\pratical files which i created chapter4.txt"; public Form1()
        {
            InitializeComponent();
        }

        private void btnReadwithStreamReader_Click(object sender, EventArgs e)
        {
            try
            {
                lst.Items.Clear();
                StreamReader read_existfile = File.OpenText(filePath);
                read_existfile = File.OpenText(filePath);
                string lines;
                while (read_existfile.EndOfStream == false)
                {
                    lines = read_existfile.ReadLine();
                    lst.Items.Add(lines);
                }
                read_existfile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cillad ayaa dhacday: " + ex.Message);
            }
        }

        private void btnreadall_Click(object sender, EventArgs e)
        {
            String[] lines;

            if (File.Exists(filePath))
            {
                // Bypasses standard single-line parsing to handle batch-load operations
                lines = File.ReadAllLines(filePath);
                lst.Items.AddRange(lines);
            }
            else
            {
                MessageBox.Show("file not found");
            }
        }

        private void btn_readlines_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                lst.Items.Clear();
                foreach (string line in File.ReadLines(filePath))
                {
                    lst.Items.Add(line);
                }
            }
            else
            {
                MessageBox.Show("Path not found");
            }
        }

        private void btn_deleteitem_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                if (lst.SelectedItem != null)
                {
                    string selectedItem = lst.SelectedItem.ToString();

                    // Isolates specific entries selected dynamically from the interface list component
                    var lines = File.ReadAllLines(filePath).ToList();

                    // Processes an automated filtration cycle that drops the chosen entry
                    if (lines.Remove(selectedItem))
                    {
                        // Rewrites the remaining data back into the storage file to keep records synchronized
                        File.WriteAllLines(filePath, lines);
                        lst.Items.Remove(selectedItem);
                        MessageBox.Show("Item deleted successfully.");
                        lst.SelectedItem = null; // Clear selection after deletion
                    }
                    else
                    {
                        MessageBox.Show("Item not found in the file.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select an item to delete.");
                }
            }
            else
            {
                MessageBox.Show("path not found");
            }
        }

        private void btndeleteentirefile_Click(object sender, EventArgs e)
        {
            // Includes preliminary safety validation checks to confirm physical existence
            if (File.Exists(filePath))
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete the entire file?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Targets physical file directory, executing complete removal commands
                    File.Delete(filePath);
                    lst.Items.Clear();
                    MessageBox.Show("File deleted successfully.");
                }
            }
            else
            {
                MessageBox.Show("File not found.");
            }
        }

        private void btnWriteToFile_Click(object sender, EventArgs e)
        {
            try
            {
                // File.AppendText waxay ku dareysaa qoraal cusub faylka adigoon tirtirin wixii hore
                using (StreamWriter writer = File.AppendText(filePath))
                {
                    writer.WriteLine("hanan waa gabar fiican .");
                }

                MessageBox.Show("Xogta si guul leh ayaa  qoray faylka!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cillad ayaa dhacday: " + ex.Message);
            }


        }
    }
}
