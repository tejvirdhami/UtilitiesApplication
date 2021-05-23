/*Tejvir Singh
 * 7/21/2020*/
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit this application?", "Exit?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        public bool NumBr(int[] array, int a)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if(a == array[i])
                {
                    return true;
                }
            }
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int[] nums = new int[8];
            int i = 0;
            int randomNumber = 0;
            while (i < 8)
            {
                do
                {
                    Random random = new Random();
                    randomNumber = random.Next(1, 49);
                }
                while (NumBr(nums, randomNumber));
                nums[i] = randomNumber;
                ++i;
            }
            textBox1.Text = Convert.ToString(nums[0] + "\r\n" + nums[1] + "\r\n" + nums[2] + "\r\n" + nums[3] + "\r\n" + nums[4] + "\r\n" + nums[5] + "\r\n" + nums[6] + "\r\n" + nums[7]);
            string numbers = Convert.ToString(nums[0] + "," + nums[1] + "," + nums[2] + "," + nums[3] + "," +  nums[4] + "," + nums[5] + "," + nums[6]);
            try
            {
                string path = "LottoNbrs.txt";
                DateTime lDate = DateTime.Now;
                if(!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("Max,      {0},    {1}     Extra {2}", lDate.ToString(), numbers, Convert.ToString(nums[7]));
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine("Max,      {0},    {1}     Extra {2}", lDate.ToString(), numbers, Convert.ToString(nums[7]));
                    }
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("LottoNbrs.txt"))
                {
                    String l = sr.ReadToEnd();
                    MessageBox.Show(l, "Tejvir's Lotto");
                }
            }
            catch (IOException ex1)
            {
                MessageBox.Show("The file cannot be read:");
                MessageBox.Show(ex1.Message, "Error");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
