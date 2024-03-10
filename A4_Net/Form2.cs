using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace A4_Net
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bt_taikhoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form5 = new Form5();
            form5.ShowDialog();
            this.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        Modify modify = new Modify();
        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = modify.Table("select * from SanPham");
            label6.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "TenSanPham"));
            label7.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "SoLuong"));
            label8.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "GiaTien"));
            label9.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "ChiTietSanPham"));
        }


        /// <summary>
        /// 
        /// </summary>

        private void taobang()
        {
            DataGridViewTextBoxColumn colTenSP = new DataGridViewTextBoxColumn();
            colTenSP.HeaderText = "Tên sản phẩm";
            colTenSP.Name = "colTenSP";

            DataGridViewTextBoxColumn colSoLuong = new DataGridViewTextBoxColumn();
            colSoLuong.HeaderText = "Số lượng";
            colSoLuong.Name = "colSoLuong";

            DataGridViewTextBoxColumn colDonGia = new DataGridViewTextBoxColumn();
            colDonGia.HeaderText = "Đơn giá";
            colDonGia.Name = "colDonGia";

            dataGridView2.Columns.Add(colTenSP);
            dataGridView2.Columns.Add(colSoLuong);
            dataGridView2.Columns.Add(colDonGia);
        }



        private string tongTenSP = "";
        private decimal tongtien = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            decimal giatien = Convert.ToDecimal(label8.Text);
            string tenSP = Convert.ToString(label6.Text);
            decimal numb = Convert.ToDecimal(numericUpDown1.Value);
            tongtien += giatien * numb;
            label4.Text = tongtien.ToString();
            //string query = "insert into Biller values ('" + label6.Text + "' ,  N'" + Convert.ToString(numericUpDown1.Value) + "'  ,  '" + label8.Text + "')";
            //modify.command(query);
            //dataGridView2.DataSource = modify.Table("select * from Biller");
            tongTenSP += tenSP;
            taobang();
            dataGridView2.Rows.Add(label6.Text, Convert.ToString(numericUpDown1.Value), label8.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {

           
        
            dataGridView2.Rows.Clear();
            string query = "insert into SumBiller values ('" + textBox3.Text + "' ,  N'" + textBox2.Text + "'  ,  " + Convert.ToInt32(label4.Text) + ",  '" + tongTenSP + "',  '" + dateTimePicker1.Value + "')";
            modify.command(query);
            tongTenSP = "";
            tongtien = 0;
        }
    }
}
