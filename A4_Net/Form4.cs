﻿using System;
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
        public static string sqll = "select MaSanPham as \"Mã sản phẩm\", TenSanPham as \"Tên sản phẩm\", SoLuong as \"Số lượng\", GiaTien as \"Giá tiền\", ChiTietSanPham as \"Chi tiết sản phẩm\" from SanPham";
        public Form4()
        {
            InitializeComponent();
        }


        private void btdichvu1_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(masp.Text) || string.IsNullOrEmpty(text1dichvu.Text) || string.IsNullOrEmpty(text2dichvu.Text) || string.IsNullOrEmpty(text3dichvu.Text) || string.IsNullOrEmpty(richTextBox1.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ tất cả các trường bắt buộc.");
                    return; // Thoát khỏi chức năng nếu bất kỳ trường nào trống
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
                datadichvu.DataSource = modify.Table("select MaSanPham as \"Mã sản phẩm\", TenSanPham as \"Tên sản phẩm\", SoLuong as \"Số lượng\", GiaTien as \"Giá tiền\", ChiTietSanPham as \"Chi tiết sản phẩm\" from SanPham");
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

        public void xoadata()
        {
            masp.Text = string.Empty;
            text1dichvu.Text = string.Empty;
            text2dichvu.Text = string.Empty;
            text3dichvu.Text = string.Empty;
            richTextBox1.Text = string.Empty;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((texttimkiem2.Text != string.Empty) && (texttimkiem.Text == string.Empty))
            {
                datadichvu.DataSource = modify.Table(sqll +
                    " where MaSanPham = '" + texttimkiem2.Text + "'");
            }

            if ((texttimkiem2.Text == string.Empty) && (texttimkiem.Text != string.Empty))
            {
                datadichvu.DataSource = modify.Table(sqll +
                    " where TenSanPham = '" + texttimkiem.Text + "'");
            }

            if ((texttimkiem2.Text != string.Empty) && (texttimkiem.Text != string.Empty))
            {
                datadichvu.DataSource = modify.Table(sqll +
                    " where TenSanPham = '" + texttimkiem.Text + "' and  MaSanPham = '" + texttimkiem2.Text + "' ");
            }

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            datadichvu.DataSource = modify.Table(sqll);
            datadichvu.Columns[3].Width = 150;
            datadichvu.Columns[4].Width = 300;
            datadichvu.Columns[1].Width = 250;
            xoadata();
        }

        private void btdichvu3_Click(object sender, EventArgs e)
        {
            string query = "delete from SanPham where TenSanPham = '" + text1dichvu.Text + "'   ";
            modify.command(query);
            datadichvu.DataSource = modify.Table(sqll);
            xoadata();
        }

        private void texttimkiem_Click(object sender, EventArgs e)
        {
            datadichvu.DataSource = modify.Table(sqll +
                " where TenSanPham = '" + button1.Text + "'");
        }

        

        private void texttimkiem_TextChanged(object sender, EventArgs e)
        {
            if (texttimkiem.Text == string.Empty && texttimkiem2.Text == string.Empty)
            {
                datadichvu.DataSource = modify.Table(sqll);
            }
        }

        private void texttimkiem2_TextChanged(object sender, EventArgs e)
        {
            if (texttimkiem.Text == string.Empty && texttimkiem2.Text == string.Empty)
            {
                datadichvu.DataSource = modify.Table(sqll);
            }
        }

        private void datadichvu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            masp.DataBindings.Clear();
            masp.DataBindings.Add(new Binding("Text", datadichvu.DataSource, "Mã sản phẩm"));
            text1dichvu.DataBindings.Clear();
            text1dichvu.DataBindings.Add(new Binding("Text", datadichvu.DataSource, "Tên sản phẩm"));
            text2dichvu.DataBindings.Clear();
            text2dichvu.DataBindings.Add(new Binding("Text", datadichvu.DataSource, "Số lượng"));
            text3dichvu.DataBindings.Clear();
            text3dichvu.DataBindings.Add(new Binding("Text", datadichvu.DataSource, "Giá tiền"));
            richTextBox1.DataBindings.Clear();
            richTextBox1.DataBindings.Add(new Binding("Text", datadichvu.DataSource, "Chi tiết sản phẩm"));
        }

        private void btdichvu2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(masp.Text) || string.IsNullOrEmpty(text1dichvu.Text) || string.IsNullOrEmpty(text2dichvu.Text) || string.IsNullOrEmpty(text3dichvu.Text) || string.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ tất cả các trường bắt buộc.");
                return; // Thoát khỏi chức năng nếu bất kỳ trường nào trống
            }
            string query = "update SanPham set TenSanPham = '" + text1dichvu.Text + "' , SoLuong  = '" + text2dichvu.Text + "'  ,  GiaTien = '" + text3dichvu.Text + "' , ChiTietSanPham = '" + richTextBox1.Text + "'  where MaSanPham = '" + masp.Text + "' ";
            modify.command(query);
            datadichvu.DataSource = modify.Table(sqll);
            xoadata();

        }

        private void clear_Click(object sender, EventArgs e)
        {
            xoadata();
        }
    }
}
