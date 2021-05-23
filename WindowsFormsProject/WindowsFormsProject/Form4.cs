using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsProject
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close Temp Conversion App", "Exit?", MessageBoxButtons.OKCancel).ToString() == "OK")
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            if(radioButton1.Checked)
            {
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1.8 + 32);
            }
            else
            {
                textBox1.Text = Convert.ToString((Convert.ToDouble(textBox2.Text) - 32) / 1.8);
            }
            if (textBox1.Text == "100")
            {
                textBox3.Text = "Water Boils";
            }
            else if (textBox1.Text == "40")
            {
                textBox3.Text = "Hot Bath";
            }
            else if (textBox1.Text == "37")
            {
                textBox3.Text = "Body Temperature";
            }
            else if (textBox1.Text == "30")
            {
                textBox3.Text = "Beach weather";
            }
            else if (Convert.ToInt32(textBox1.Text) > 10 && Convert.ToInt32(textBox1.Text) < 30)
            {
                textBox3.Text = "Room Temperature";
            }
            else if (textBox1.Text == "10")
            {
                textBox3.Text = "Cool Day";
            }
            else if (textBox1.Text == "0")
            {
                textBox3.Text = "Freezing point of water";
            }
            else if (Convert.ToInt32(textBox1.Text) > -40 && Convert.ToInt32(textBox1.Text) < 0)
            {
                textBox3.Text = "Very Cold Day";
            }
            else if (textBox1.Text == "-40")
            {
                textBox3.Text = "Extremely Cold day (and same number!)";
            }
            string path = "TempConversions.txt";
            DateTime lDate = DateTime.Now;
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(textBox1.Text + "C" + "  =  " + textBox2.Text + "F" + ",     " + lDate.ToString());
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(textBox1.Text + "C" + "  =  " + textBox2.Text + "F" + ",     " + lDate.ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("TempConversions.txt"))
                {
                    String l = sr.ReadToEnd();
                    MessageBox.Show(l, "Tejvir's Temperature Conversion");
                }
            }
            catch (IOException ex1)
            {
                MessageBox.Show("The file cannot be read:");
                MessageBox.Show(ex1.Message, "Error");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = false;
        }
    }
}
