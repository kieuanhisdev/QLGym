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
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
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
            loadBangSanPham();
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
        Modify modify = new Modify();
        private int cnt = 4;

        private void MaHD()
        {

            lbMaHaD.Text = "MHD" + GetMaHoaDon();
           
        }

        public static string GetMaHoaDon()
        {
            // Lấy ngày tháng năm hiện tại
            DateTime now = DateTime.Now;

            // Định dạng chuỗi mã hóa đơn
            string format = "yyMdHms";

            // Tạo mã hóa đơn
            string maHoaDon = now.ToString(format);

            // Trả về mã hóa đơn
            return maHoaDon;
        }

        public void loadBangSanPham()
        {
            dataGridView1.DataSource = modify.Table("select \r\n    MaSanPham AS \"Mã Sản Phẩm\",\r\n    TenSanPham AS \"Tên Sản Phẩm\",\r\n    SoLuong AS \"Số Lượng\",\r\n    GiaTien AS \"Giá Tiền\",\r\n    ChiTietSanPham AS \"Chi Tiết Sản Phẩm\"\r\nfrom \r\n    SanPham;");

        }


        private void Form2_Load(object sender, EventArgs e)
        {
            loadBangSanPham();
            //dataGridView1.DataSource = modify.Table("select * from SanPham");
            dataGridView1.Columns[4].Width = 185;
           // dataGridView1.Rows[0].Cells[0].Selected = false;
           // dataGridView1.Rows[dataGridView1.Rows.Count - 1].Selected = true;
            //label3.Text = modify.checkHD(query);
            cnt++;
            MaHD();
        }

        private decimal tongtien = 0;
        private int stt = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            if(lbMaSP.Text != string.Empty)
            {
                decimal giatien = Convert.ToDecimal(label8.Text);
                string tenSP = Convert.ToString(lbMaSP.Text);
                decimal numb = Convert.ToDecimal(numericUpDown1.Value);
                tongtien += giatien * numb;
                lbTongTien.Text = tongtien.ToString();
                stt++;
                ListViewItem l = listView1.Items.Add(Convert.ToString(Convert.ToString(stt)));
                l.SubItems.Add(tenSP);
                l.SubItems.Add(Convert.ToString(numericUpDown1.Value));
                l.SubItems.Add(Convert.ToString(giatien));
                l.SubItems.Add(Convert.ToString(giatien * numericUpDown1.Value));
            }
            else
            {
                MessageBox.Show("Chưa chọn đồ cần mua.", "Lỗi");
            }

            



        }

        private void button4_Click(object sender, EventArgs e)

        {

            if (textBox2.Text != string.Empty)
            {
                string query = "insert into PhieuThanhToan values (N'" + lbMaHaD.Text + "' ,  N'" + textBox2.Text + "'  ,  " + tongtien + ",  '" + dateTimePicker1.Value.ToShortDateString() + "')";
                modify.command(query);
                // dataGridView2.Rows.Clear();
                string MHD = lbMaBill.Text;

                decimal giatien = Convert.ToDecimal(label8.Text);

                foreach (ListViewItem item in listView1.Items)
                {
                    // Lấy dữ liệu từ mỗi mục
                    string column1Value = item.SubItems[1].Text;
                    string column2Value = item.SubItems[2].Text;
                    //string column3Value = item.SubItems[3].Text;
                    string column4Value = item.SubItems[4].Text;

                    // Thêm dữ liệu vào câu lệnh INSERT INTO

                    string query1 = "insert into ChiTietPhieuThanhToan values ('" + MHD + "' ,'" + column1Value + "' ,  " + Convert.ToString(column2Value) + "  ,  " + Convert.ToString(column4Value) + ")";
                    // Thực thi câu lệnh INSERT INTO
                    modify.command(query1);
                }

                listView1.Items.Clear();
                tongtien = 0;
                textBox2.Text = string.Empty;
                numericUpDown1.Value = 0;
                lbTongTien.Text = string.Empty;
                dateTimePicker1.Value = DateTime.Now;
                MaHD();
            }
            else
            {
                MessageBox.Show("Tên khách hàng chưa được nhập.", "Lỗi");
            }

            
        }
      
        private void lbMaHaD_TextChanged(object sender, EventArgs e)
        {
            lbMaBill.Text = lbMaHaD.Text;
        }


        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lbMaSP.DataBindings.Clear();
            lbMaSP.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Tên Sản Phẩm"));
            label7.DataBindings.Clear();
            label7.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Số Lượng"));
            label8.DataBindings.Clear();
            label8.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Giá Tiền"));
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(textBox1.Text == string.Empty)
            {
                loadBangSanPham();
            }
            else
            {
                dataGridView1.DataSource = modify.Table("select * from SanPham where TenSanPham = '" + textBox1.Text + "'");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                //dataGridView1.DataSource = modify.Table("select * from SanPham");
                loadBangSanPham();
            }
           // else
           // {
           //     dataGridView1.DataSource = modify.Table("select * from SanPham where TenSanPham = '" + textBox1.Text + "'");
           // }
        }

        private void Btxoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
