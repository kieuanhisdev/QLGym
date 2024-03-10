using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace A4_Net
{
    public partial class Form4 : Form
    {
        Modify modify = new Modify();
        public static string id = "SP";
        public static int val = 1;
        public Form4()
        {
            InitializeComponent();
        }

        private void lb1sanpham_Click(object sender, EventArgs e)
        {

        }

        private void lb3dichvu_Click(object sender, EventArgs e)
        {

        }

        private void btdichvu1_Click(object sender, EventArgs e)
        {
            
            string query = "insert into SanPham values ('" + id + val.ToString() + "' ,  N'" + text1dichvu.Text + "'  ,  '" + text2dichvu.Text + "'  ,  '" + text3dichvu.Text + "'  ,  N'" + richTextBox1.Text  +"')";
            modify.command(query);
            datadichvu.DataSource = modify.Table("select * from SanPham");
            val += 1;

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            datadichvu.DataSource = modify.Table("select * from SanPham");
        }

        private void btdichvu3_Click(object sender, EventArgs e)
        {
            string query = "delete from SanPham where TenSanPham = '"+  text1dichvu.Text  + "'   ";
            modify.command(query);
            datadichvu.DataSource = modify.Table("select * from SanPham");
        }
    }
}
