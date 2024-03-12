using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace A4_Net
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
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
        private int cnt = 4;

        private void MaHD()
        {
         
            txMaHoaDon.Text = "MHD" + GetMaHoaDon();
           
        }

        public static string GetMaHoaDon()
        {
            // Lấy ngày tháng năm hiện tại
            DateTime now = DateTime.Now;

            // Định dạng chuỗi mã hóa đơn
            string format = "yyyyMMddHHmmss";

            // Tạo mã hóa đơn
            string maHoaDon = now.ToString(format);

            // Trả về mã hóa đơn
            return maHoaDon;
        }


        private void Form2_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = modify.Table("select * from SanPham");
            dataGridView1.Columns[4].Width = 185;
            lbMaSP.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "TenSanPham"));
            label7.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "SoLuong"));
            label8.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "GiaTien"));

            ///
            ///

            //label3.Text = modify.checkHD(query);
            cnt++;

            MaHD();
        }


        /// <summary>
        /// 
        /// </summary>


        private decimal tongtien = 0;
        private int stt = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            decimal giatien = Convert.ToDecimal(label8.Text);
            string tenSP = Convert.ToString(lbMaSP.Text);
            decimal numb = Convert.ToDecimal(numericUpDown1.Value);
            tongtien += giatien * numb;
            lbTongTien.Text = tongtien.ToString();
            string query = "insert into ChiTietPhieuThanhToan values ('" + txMaHoaDon.Text + "' ,'" + lbMaSP.Text + "' ,  " + Convert.ToString(numericUpDown1.Value) + "  ,  " + Convert.ToString(giatien * numericUpDown1.Value) + ")";
            modify.command(query);
            stt++;
            ListViewItem l = listView1.Items.Add(Convert.ToString(Convert.ToString(stt)));
            l.SubItems.Add(tenSP);
            l.SubItems.Add(Convert.ToString(numericUpDown1.Value));
            l.SubItems.Add(Convert.ToString(giatien));
            l.SubItems.Add(Convert.ToString(giatien * numericUpDown1.Value));



        }

        private void button4_Click(object sender, EventArgs e)

        {
            MaHD();
            // dataGridView2.Rows.Clear();
            string query = "insert into PhieuThanhToan values (N'" + txMaHoaDon.Text + "' ,  N'" + textBox2.Text + "'  ,  " + tongtien + ",  '" + dateTimePicker1.Value.ToShortDateString() + "')";
            modify.command(query);
            listView1.Items.Clear();
            tongtien = 0;
            
        }

        private void txMaHoaDon_TextChanged(object sender, EventArgs e)
        {
            lbMaBill.Text = txMaHoaDon.Text;
        }
    }
}
