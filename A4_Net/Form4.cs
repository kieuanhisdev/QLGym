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

            string query = "insert into SanPham values ('" + masp.Text + "' ,  N'" + text1dichvu.Text + "'  ,  '" + text2dichvu.Text + "'  ,  '" + text3dichvu.Text + "'  ,  N'" + richTextBox1.Text + "')";


            modify.command(query);
            datadichvu.DataSource = modify.Table("select * from SanPham");


        }

        public void xoadata()
        {
            masp.Text = string.Empty;
            text1dichvu.Text = string.Empty;
            text2dichvu.Text = string.Empty;
            text3dichvu.Text = string.Empty;
            richTextBox1.Text = string.Empty;

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            datadichvu.DataSource = modify.Table("select * from SanPham");
            datadichvu.Columns[3].Width = 150;
            datadichvu.Columns[4].Width = 300;
            datadichvu.Columns[1].Width = 250;
            xoadata();
        }

        private void btdichvu3_Click(object sender, EventArgs e)
        {
            string query = "delete from SanPham where TenSanPham = '" + text1dichvu.Text + "'   ";
            modify.command(query);
            datadichvu.DataSource = modify.Table("select * from SanPham");
            xoadata();
        }

        private void texttimkiem_Click(object sender, EventArgs e)
        {
            datadichvu.DataSource = modify.Table("select * from SanPham where TenSanPham = '" + button1.Text + "'");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(masp.Text) || string.IsNullOrEmpty(text1dichvu.Text) || string.IsNullOrEmpty(text2dichvu.Text) || string.IsNullOrEmpty(text3dichvu.Text) || string.IsNullOrEmpty(richTextBox1.Text))
                {
                    throw new Exception("du lieu khong duoc de trong");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            try
            {
                string query = "insert into SanPham values ('" + masp.Text + "' ,  N'" + text1dichvu.Text + "'  ,  '" + text2dichvu.Text + "'  ,  '" + text3dichvu.Text + "'  ,  N'" + richTextBox1.Text + "')";
                modify.command(query);
                datadichvu.DataSource = modify.Table("select * from SanPham");
                xoadata();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("ma san pham da ton tai");

                }
            }
        }

        private void texttimkiem_TextChanged(object sender, EventArgs e)
        {
            if (texttimkiem.Text == string.Empty && texttimkiem2.Text == string.Empty)
            {
                datadichvu.DataSource = modify.Table("select * from SanPham");
            }
        }

        private void texttimkiem2_TextChanged(object sender, EventArgs e)
        {
            if (texttimkiem.Text == string.Empty && texttimkiem2.Text == string.Empty)
            {
                datadichvu.DataSource = modify.Table("select * from SanPham");
            }
        }

        private void datadichvu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            masp.DataBindings.Clear();
            masp.DataBindings.Add(new Binding("Text", datadichvu.DataSource, "MaSanPham"));
            text1dichvu.DataBindings.Clear();
            text1dichvu.DataBindings.Add(new Binding("Text", datadichvu.DataSource, "TenSanPham"));
            text2dichvu.DataBindings.Clear();
            text2dichvu.DataBindings.Add(new Binding("Text", datadichvu.DataSource, "SoLuong"));
            text3dichvu.DataBindings.Clear();
            text3dichvu.DataBindings.Add(new Binding("Text", datadichvu.DataSource, "SoLuong"));
            richTextBox1.DataBindings.Clear();
            richTextBox1.DataBindings.Add(new Binding("Text", datadichvu.DataSource, "ChiTietSanPham"));
        }

        private void btdichvu2_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "update SanPham set TenSanPham = '" + text1dichvu.Text + "' , SoLuong  = '" + text2dichvu.Text + "'  ,  GiaTien = '" + text3dichvu.Text + "' , ChiTietSanPham = '" + richTextBox1.Text + "'  where MaSanPham = '" + masp.Text + "' ";
                modify.command(query);
                datadichvu.DataSource = modify.Table("select * from SanPham ");
                xoadata();
            }

            catch (Exception ex)
            {
                MessageBox.Show("dữ liệu không được để trống");
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            xoadata();
        }
    }
}
