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

namespace WindowsFormsProject
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want\nto quit the application\nMoney Exchange", "Exit?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool country = true;
            double to = 0, from;
            string convertTo = "", convertFrom = "";
            if(radioButton1.Checked)
            {
                to = Convert.ToDouble(textBox1.Text);
                convertFrom = "CAD";
            }
            else if(radioButton2.Checked)
            {
                to = Convert.ToDouble(textBox1.Text) * 1.34;
                convertFrom = "USD";
            }
            else if (radioButton3.Checked)
            {
                to = Convert.ToDouble(textBox1.Text) * 1.56;
                convertFrom = "EUR";
            }
            else if (radioButton4.Checked)
            {
                to = Convert.ToDouble(textBox1.Text) * 1.74;
                convertFrom = "GBP";
            }
            else if (radioButton5.Checked)
            {
                to = Convert.ToDouble(textBox1.Text) * 0.018;
                convertFrom = "INR";
            }
            else
            {
                MessageBox.Show("Kindly select currency to convert from");
                country = false;
            }
            if(radioButton6.Checked)
            {
                from = to;
                textBox2.Text = Convert.ToString(from);
                convertTo = "CAD";
            }
            else if (radioButton7.Checked)
            {
                from = to * 0.74;
                textBox2.Text = Convert.ToString(from);
                convertTo = "USD";
            }
            else if (radioButton8.Checked)
            {
                from = to * 0.64;
                textBox2.Text = Convert.ToString(from);
                convertTo = "EUR";
            }
            else if (radioButton9.Checked)
            {
                from = to * 0.59;
                textBox2.Text = Convert.ToString(from);
                convertTo = "GBP";
            }
            else if (radioButton10.Checked)
            {
                from = to * 55.50;
                textBox2.Text = Convert.ToString(from);
                convertTo = "INR";
            }
            else
            {
                MessageBox.Show("Please select a cureency to convert");
                country = false;
            }
            if(country)
            {
                string path = "MoneyConversions.txt";
                DateTime lDate = DateTime.Now;
                if(!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(textBox1.Text + " " + convertFrom + " = " + textBox2.Text + " " + convertTo + "        " + lDate.ToString());
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine(textBox1.Text + " " + convertFrom + " = " + textBox2.Text + " " + convertTo + "        " + lDate.ToString());
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("MoneyConversions.txt"))
                {
                    String l = sr.ReadToEnd();
                    MessageBox.Show(l, "Tejvir's Money Conversion");
                }
            }
            catch (IOException ex1)
            {
                MessageBox.Show("The file cannot be read:");
                MessageBox.Show(ex1.Message, "Error");
            }
        }
    }
}
