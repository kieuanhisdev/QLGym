using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A4_Net
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void panel2_Paint(object sender, PaintEventArgs e)
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
            string str = " insert into Account values (N'" + txbDiaChiAccount.Text + "' , N'" + txbNameAccount.Text + "' , '" + dtpNgaySinhAccount.Text + "', " + gt.ToString() + " ,  '" + txbSDTAccount.Text + "', N'" + txbEmailAccount.Text + "' )";
            modify.command(str);
            dgvAccount.DataSource = modify.Table("select * from Account");
        }

        private void btXoaAccount_Click(object sender, EventArgs e)
        {
            string str = "delete from Account where UserName = '" + txbDiaChiAccount.Text + "'";
            modify.command(str);
            dgvAccount.DataSource = modify.Table("select * from Account");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dgvAccount.DataSource = modify.Table("select * from Account");
        }

        private void btSuaAccount_Click(object sender, EventArgs e)
        {
            int gt;
            if (rbNamAccount.Checked)
            {
                gt = 1;
            }
            else gt = 0;
            // string str = "update Account set HoVaTen = '" + txbNameAccount.Text + "' , NgaySinh = '" + dtpNgaySinhAccount.Text + "', GioiTinh =  " + gt.ToString(); + " , SoDienThoai =   '"+ txbSDTAccount.Text + "' , Email =  '"+ txbEmailAccount.Text +"'          ";
        }
    }
}
