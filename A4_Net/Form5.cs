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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        Modify modify = new Modify();

        private void Form5_Load(object sender, EventArgs e)
        {
            dgvbanchitiet.DataSource = modify.Table("select * from PhieuThanhToan");
            
        }

        private void dgvbanchitiet_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.DataBindings.Clear();
            textBox1.DataBindings.Add(new Binding("Text", dgvbanchitiet.DataSource, "MaHoaDon"));
        }

        private void bttheongay_Click(object sender, EventArgs e)
        {
            string mhd = textBox1.Text;
            dataGridView1.DataSource = modify.Table("SELECT ct.TenSanPham, " +
                                                            "ct.SoLuongMua, " +
                                                            "ct.ThanhTien " +
                                                    "FROM ChiTietPhieuThanhToan ct " +
                                                    "INNER JOIN PhieuThanhToan pt ON ct.MaHoaDon = pt.MaHoaDon " +
                                                    "WHERE pt.MaHoaDon = '" + mhd + "';");
        }
    }
}
