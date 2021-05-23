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
    public partial class FormPersonal : Form
    {
        public FormPersonal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close personal Information?", "Exit?", MessageBoxButtons.OKCancel).ToString() == "OK")
            {
                this.Close();
            }
        }
    }
}
