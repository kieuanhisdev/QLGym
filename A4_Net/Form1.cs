using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            SqlConnection sqlConnection = connection.GetSqlConnection();
           
                sqlConnection.Open();
                string tk = textBox1.Text;
                string mk = textBox2.Text;
                string sql = "select * from AccountAdmin where UserName = '" + tk + "' AND MatKhau = '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    Form2 f2 = new Form2();
                    this.Hide();
                    f2.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }

            textBox1.Text = "";
            textBox2.Text = ""; 


        }

       
        private void button2_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Nếu người dùng chọn "Yes", đóng form
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            // Nếu người dùng chọn "No", hủy bỏ việc đóng form
            else
            {
                e.Cancel = true;
            }
        }
    }
}
