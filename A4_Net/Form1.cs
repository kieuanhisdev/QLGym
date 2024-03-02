using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A4_Net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            this.Show();

        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            an f3 = new an();
            this.Hide();
            f3.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
    }
}
