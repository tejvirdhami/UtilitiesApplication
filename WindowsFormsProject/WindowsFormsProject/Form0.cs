using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProject
{
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form6 obj = new Form6();
            obj.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit now?", "Exit?", MessageBoxButtons.OKCancel).ToString() == "OK")
            {
                this.Close();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 obj = new Form5();
            obj.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 obj = new Form4();
            obj.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 obj = new Form3();
            obj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.ShowDialog();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormPersonal obj = new FormPersonal();
            obj.ShowDialog();
        }
    }
}
