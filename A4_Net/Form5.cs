using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        public void loadFileHDChiTiet()
        {
            string mhd = textBox1.Text;
            dataGridView1.DataSource = modify.Table("SELECT ct.TenSanPham, " +
                                                            "ct.SoLuongMua, " +
                                                            "ct.ThanhTien " +
                                                  "FROM ChiTietPhieuThanhToan ct " +
                                                 "INNER JOIN PhieuThanhToan pt ON ct.MaHoaDon = pt.MaHoaDon " +
                                                   "WHERE pt.MaHoaDon = '" + mhd + "';");
        }

        private void bttheongay_Click(object sender, EventArgs e)
        {
            loadFileHDChiTiet();

        }
      

        private void button3_Click(object sender, EventArgs e)
        {
            dgvbanchitiet.DataSource = modify.Table("SELECT* FROM PhieuThanhToan  WHERE NgayMua BETWEEN '"+ dateTimePicker1.Value +"' AND '" + dateTimePicker2.Value +"'");
        }
        private void ExportToCsv(DataGridView dataGridView)
        {
            // Tạo SaveFileDialog
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "CSV files (*.csv)|*.csv";
                dialog.DefaultExt = ".csv";
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Ghi dữ liệu vào file
                    using (StreamWriter writer = new StreamWriter(dialog.FileName))
                    {
                        // Ghi tiêu đề cột
                        for (int i = 0; i < dataGridView.ColumnCount; i++)
                        {
                            writer.Write(dataGridView.Columns[i].HeaderText + ",");
                        }
                        writer.WriteLine();

                        // Ghi dữ liệu
                        foreach (DataGridViewRow row in dataGridView.Rows)
                        {
                            for (int i = 0; i < dataGridView.ColumnCount; i++)
                            {
                                writer.Write(row.Cells[i].Value + ",");
                            }
                            writer.WriteLine();
                        }
                    }
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            ExportToCsv(dataGridView1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = "delete from ChiTietPhieuThanhToan where MaHoaDon = '" + textBox1.Text + "' delete from PhieuThanhToan where MaHoaDon = '" + textBox1.Text + "'";
            modify.command(query);
            dgvbanchitiet.DataSource = modify.Table("select * from PhieuThanhToan");
            loadFileHDChiTiet();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = "delete from ChiTietPhieuThanhToan where TenSanPham = '" + textBox2.Text + "'";
            modify.command(query);
            dgvbanchitiet.DataSource = modify.Table("select * from PhieuThanhToan");
            loadFileHDChiTiet();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox2.DataBindings.Clear();
            textBox2.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "TenSanPham"));
        }
    }
}
