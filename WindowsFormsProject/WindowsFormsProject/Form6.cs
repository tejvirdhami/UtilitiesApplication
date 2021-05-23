using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsProject
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            label2.Text = DateTime.Now.ToLongDateString();
        }
        void reset()
        {
            textBox1.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close IP v4 Validator", "Exit?", MessageBoxButtons.OKCancel).ToString() == "OK")
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex obj = new Regex(@"^(25[0-5]|2[0-4]\d|[0-1]?\d?\d)(\.(25[0-5]|2[0-4]\d|[0-1]?\d?\d)){3}$");
            if (obj.IsMatch(textBox1.Text.Trim()) == true)
            {
                MessageBox.Show(textBox1.Text + "\nThe ip is correct", "Valid IP", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(textBox1.Text + "\nThe IP must have 4 bytes\ninteger numbers between 0 to 255\nseparated by a dot (255.255.255.255)", "Error", MessageBoxButtons.OK);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}