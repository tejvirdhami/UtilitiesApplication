/*Tejvir Singh
 * 7/20/2020*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsProject
{
    public partial class Form5 : Form
    {
        double NumOne;
        string Operand;
        public Form5()
        {
            InitializeComponent();
        }
        void reset()
        {
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit Calculator?", "Exit?", MessageBoxButtons.OKCancel).ToString() == "OK")
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            NumOne = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            Operand = "+";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            NumOne = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            Operand = "-";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            NumOne = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            Operand = "*";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            NumOne = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            Operand = "/";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double NumTwo;
            double Result = 0;
            NumTwo = Convert.ToDouble(textBox1.Text);

            if( Operand == "+")
            {
                Result = (NumOne + NumTwo);
                textBox1.Text = Convert.ToString(Result);
            }
            if (Operand == "-")
            {
                Result = (NumOne - NumTwo);
                textBox1.Text = Convert.ToString(Result);
            }
            if (Operand == "*")
            {
                Result = (NumOne * NumTwo);
                textBox1.Text = Convert.ToString(Result);
            }
            if (Operand == "/")
            {
                if (NumTwo == 0)
                {
                    textBox1.Text = "Cannot divide by zero.\nPlease enter a valid numver";
                }
                else
                {
                    Result = (NumOne / NumTwo);
                    textBox1.Text = Convert.ToString(Result);
                }

            }
            string path = "Calculator.txt"; //This is added only one time
            if(!File.Exists(path)) //If file is already there
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("{0} {1} {2} = {3}", Convert.ToString(NumOne), Operand, Convert.ToString(NumTwo), Convert.ToString(Result));
                }
            }
            else // Creates new one
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("{0} {1} {2} = {3}", Convert.ToString(NumOne), Operand, Convert.ToString(NumTwo), Convert.ToString(Result));
                }
            }
            NumOne = Result;
        }
    }
}
