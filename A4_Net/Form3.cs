﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A4_Net
{
    public partial class Form3 : Form
    {
        Modify modify = new Modify();
        public Form3()
        {
            InitializeComponent();
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txbSDTAccount_TextChanged(object sender, EventArgs e)
        {

        }



        private void btThemAccount_Click(object sender, EventArgs e)
        {
            int gt;
            if (rbNamAccount.Checked)
            {
                gt = 1;
            }
            else gt = 0;
            /*string str = " insert into Account values (N'" + txbDiaChiAccount.Text + "' , N'" + txbNameAccount.Text + "' , '" + dtpNgaySinhAccount.Text + "', " + gt.ToString() + " ,  '" + txbSDTAccount.Text + "', N'" + txbEmailAccount.Text + "' )";
            modify.command(str);
            dgvAccount.DataSource = modify.Table("select * from Account");
            */
            try
            {
                if (string.IsNullOrEmpty(txbNameAccount.Text) || string.IsNullOrEmpty(txbDiaChiAccount.Text) || string.IsNullOrEmpty(txbSDTAccount.Text) || string.IsNullOrEmpty(txbEmailAccount.Text))
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
                string str = " insert into Account values (N'" + txbDiaChiAccount.Text + "' , N'" + txbNameAccount.Text + "' , '" + dtpNgaySinhAccount.Text + "', " + gt.ToString() + " ,  '" + txbSDTAccount.Text + "', N'" + txbEmailAccount.Text + "' )";
                modify.command(str);
                dgvAccount.DataSource = modify.Table("select UserName, HoVaTen as \"Họ và tên\",   NgaySinh as \"Ngày sinh\", GioiTinh as \"Giới tính\", SoDienThoai as \"Số điện thoại\", Email\r\nfrom Account");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("username da ton tai");

                }


            }

        }

        private void diaChiAccount_Click(object sender, EventArgs e)
        {

        }

        private void rbNamAccount_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txbEmailAccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btXoaAccount_Click(object sender, EventArgs e)
        {
            string str = "delete from Account where UserName = '" + txbDiaChiAccount.Text + "'";
            modify.command(str);
            dgvAccount.DataSource = modify.Table("select UserName, HoVaTen as \"Họ và tên\",   NgaySinh as \"Ngày sinh\", GioiTinh as \"Giới tính\", SoDienThoai as \"Số điện thoại\", Email\r\nfrom Account");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dgvAccount.DataSource = modify.Table("select UserName, HoVaTen as \"Họ và tên\",   NgaySinh as \"Ngày sinh\", GioiTinh as \"Giới tính\", SoDienThoai as \"Số điện thoại\", Email\r\nfrom Account");
        }

        private void btSuaAccount_Click(object sender, EventArgs e)
        {
            int gt;
            if (rbNamAccount.Checked)
            {
                gt = 1;
            }
            else gt = 0;
            string str = "update Account set HoVaTen = '" + txbNameAccount.Text + "' , NgaySinh = '" + dtpNgaySinhAccount.Text + "', GioiTinh =  " + gt.ToString() + " , SoDienThoai =   '" + txbSDTAccount.Text + "' , Email =  '" + txbEmailAccount.Text + "'  where UserName = '" + txbDiaChiAccount.Text + "'        ";
            modify.command(str);
            dgvAccount.DataSource = modify.Table("select UserName, HoVaTen as \"Họ và tên\",   NgaySinh as \"Ngày sinh\", GioiTinh as \"Giới tính\", SoDienThoai as \"Số điện thoại\", Email\r\nfrom Account");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvAccount.DataSource = modify.Table("select * from Account where UserName = '" + timacc.Text + "'");

        }

        private void timacc_TextChanged(object sender, EventArgs e)
        {
            if (timacc.Text == string.Empty)
            {
                dgvAccount.DataSource = modify.Table("select UserName, HoVaTen as \"Họ và tên\",   NgaySinh as \"Ngày sinh\", GioiTinh as \"Giới tính\", SoDienThoai as \"Số điện thoại\", Email\r\nfrom Account");
            }
        }

        private void dgvAccount_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txbNameAccount.DataBindings.Clear();
            txbNameAccount.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "Họ và tên"));

            dtpNgaySinhAccount.DataBindings.Clear();
            dtpNgaySinhAccount.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "Ngày sinh"));

            txbSDTAccount.DataBindings.Clear();
            txbSDTAccount.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "Giới tính"));

            txbEmailAccount.DataBindings.Clear();
            txbEmailAccount.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "Email"));

            txbDiaChiAccount.DataBindings.Clear();
            txbDiaChiAccount.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "UserName"));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
