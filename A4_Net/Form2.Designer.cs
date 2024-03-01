namespace A4_Net
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btXoaAccount = new System.Windows.Forms.Button();
            this.btSuaAccount = new System.Windows.Forms.Button();
            this.btThemAccount = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpNgaySinhAccount = new System.Windows.Forms.DateTimePicker();
            this.rbNuAccount = new System.Windows.Forms.RadioButton();
            this.rbNamAccount = new System.Windows.Forms.RadioButton();
            this.txbDiaChiAccount = new System.Windows.Forms.TextBox();
            this.txbEmailAccount = new System.Windows.Forms.TextBox();
            this.txbSDTAccount = new System.Windows.Forms.TextBox();
            this.txbNameAccount = new System.Windows.Forms.TextBox();
            this.diaChiAccount = new System.Windows.Forms.Label();
            this.EmailAccount = new System.Windows.Forms.Label();
            this.soDienThoaiAccount = new System.Windows.Forms.Label();
            this.gioiTinhAccount = new System.Windows.Forms.Label();
            this.ngaySinhAccount = new System.Windows.Forms.Label();
            this.hoTenAccount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.datadichvu = new System.Windows.Forms.DataGridView();
            this.paneldichvu = new System.Windows.Forms.Panel();
            this.btdichvu1 = new System.Windows.Forms.Button();
            this.btdichvu2 = new System.Windows.Forms.Button();
            this.btdichvu3 = new System.Windows.Forms.Button();
            this.lb1dichvu = new System.Windows.Forms.Label();
            this.lb2dichvu = new System.Windows.Forms.Label();
            this.lb3dichvu = new System.Windows.Forms.Label();
            this.text1dichvu = new System.Windows.Forms.TextBox();
            this.text2dichvu = new System.Windows.Forms.TextBox();
            this.text3dichvu = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datadichvu)).BeginInit();
            this.paneldichvu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(964, 640);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(956, 614);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Trang chủ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(956, 614);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tài Khoản";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btXoaAccount);
            this.panel3.Controls.Add(this.btSuaAccount);
            this.panel3.Controls.Add(this.btThemAccount);
            this.panel3.Location = new System.Drawing.Point(491, 538);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(459, 69);
            this.panel3.TabIndex = 0;
            // 
            // btXoaAccount
            // 
            this.btXoaAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaAccount.Location = new System.Drawing.Point(327, 9);
            this.btXoaAccount.Name = "btXoaAccount";
            this.btXoaAccount.Size = new System.Drawing.Size(113, 50);
            this.btXoaAccount.TabIndex = 5;
            this.btXoaAccount.Text = "Xóa";
            this.btXoaAccount.UseVisualStyleBackColor = true;
            // 
            // btSuaAccount
            // 
            this.btSuaAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaAccount.Location = new System.Drawing.Point(173, 9);
            this.btSuaAccount.Name = "btSuaAccount";
            this.btSuaAccount.Size = new System.Drawing.Size(121, 50);
            this.btSuaAccount.TabIndex = 4;
            this.btSuaAccount.Text = "Sửa";
            this.btSuaAccount.UseVisualStyleBackColor = true;
            // 
            // btThemAccount
            // 
            this.btThemAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemAccount.Location = new System.Drawing.Point(19, 9);
            this.btThemAccount.Name = "btThemAccount";
            this.btThemAccount.Size = new System.Drawing.Size(116, 50);
            this.btThemAccount.TabIndex = 3;
            this.btThemAccount.Text = "Thêm";
            this.btThemAccount.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpNgaySinhAccount);
            this.panel2.Controls.Add(this.rbNuAccount);
            this.panel2.Controls.Add(this.rbNamAccount);
            this.panel2.Controls.Add(this.txbDiaChiAccount);
            this.panel2.Controls.Add(this.txbEmailAccount);
            this.panel2.Controls.Add(this.txbSDTAccount);
            this.panel2.Controls.Add(this.txbNameAccount);
            this.panel2.Controls.Add(this.diaChiAccount);
            this.panel2.Controls.Add(this.EmailAccount);
            this.panel2.Controls.Add(this.soDienThoaiAccount);
            this.panel2.Controls.Add(this.gioiTinhAccount);
            this.panel2.Controls.Add(this.ngaySinhAccount);
            this.panel2.Controls.Add(this.hoTenAccount);
            this.panel2.Location = new System.Drawing.Point(491, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 529);
            this.panel2.TabIndex = 1;
            // 
            // dtpNgaySinhAccount
            // 
            this.dtpNgaySinhAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinhAccount.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinhAccount.Location = new System.Drawing.Point(181, 163);
            this.dtpNgaySinhAccount.Name = "dtpNgaySinhAccount";
            this.dtpNgaySinhAccount.Size = new System.Drawing.Size(233, 29);
            this.dtpNgaySinhAccount.TabIndex = 25;
            // 
            // rbNuAccount
            // 
            this.rbNuAccount.AutoSize = true;
            this.rbNuAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNuAccount.Location = new System.Drawing.Point(285, 221);
            this.rbNuAccount.Name = "rbNuAccount";
            this.rbNuAccount.Size = new System.Drawing.Size(53, 28);
            this.rbNuAccount.TabIndex = 24;
            this.rbNuAccount.TabStop = true;
            this.rbNuAccount.Text = "Nữ";
            this.rbNuAccount.UseVisualStyleBackColor = true;
            // 
            // rbNamAccount
            // 
            this.rbNamAccount.AutoSize = true;
            this.rbNamAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNamAccount.Location = new System.Drawing.Point(182, 221);
            this.rbNamAccount.Name = "rbNamAccount";
            this.rbNamAccount.Size = new System.Drawing.Size(68, 28);
            this.rbNamAccount.TabIndex = 23;
            this.rbNamAccount.TabStop = true;
            this.rbNamAccount.Text = "Nam";
            this.rbNamAccount.UseVisualStyleBackColor = true;
            // 
            // txbDiaChiAccount
            // 
            this.txbDiaChiAccount.Location = new System.Drawing.Point(181, 414);
            this.txbDiaChiAccount.Name = "txbDiaChiAccount";
            this.txbDiaChiAccount.Size = new System.Drawing.Size(233, 20);
            this.txbDiaChiAccount.TabIndex = 22;
            // 
            // txbEmailAccount
            // 
            this.txbEmailAccount.Location = new System.Drawing.Point(181, 349);
            this.txbEmailAccount.Name = "txbEmailAccount";
            this.txbEmailAccount.Size = new System.Drawing.Size(233, 20);
            this.txbEmailAccount.TabIndex = 21;
            // 
            // txbSDTAccount
            // 
            this.txbSDTAccount.Location = new System.Drawing.Point(181, 288);
            this.txbSDTAccount.Name = "txbSDTAccount";
            this.txbSDTAccount.Size = new System.Drawing.Size(233, 20);
            this.txbSDTAccount.TabIndex = 20;
            // 
            // txbNameAccount
            // 
            this.txbNameAccount.Location = new System.Drawing.Point(181, 100);
            this.txbNameAccount.Name = "txbNameAccount";
            this.txbNameAccount.Size = new System.Drawing.Size(233, 20);
            this.txbNameAccount.TabIndex = 19;
            // 
            // diaChiAccount
            // 
            this.diaChiAccount.AutoSize = true;
            this.diaChiAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diaChiAccount.Location = new System.Drawing.Point(45, 409);
            this.diaChiAccount.Name = "diaChiAccount";
            this.diaChiAccount.Size = new System.Drawing.Size(67, 24);
            this.diaChiAccount.TabIndex = 18;
            this.diaChiAccount.Text = "Địa chỉ";
            // 
            // EmailAccount
            // 
            this.EmailAccount.AutoSize = true;
            this.EmailAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAccount.Location = new System.Drawing.Point(45, 344);
            this.EmailAccount.Name = "EmailAccount";
            this.EmailAccount.Size = new System.Drawing.Size(57, 24);
            this.EmailAccount.TabIndex = 17;
            this.EmailAccount.Text = "Email";
            // 
            // soDienThoaiAccount
            // 
            this.soDienThoaiAccount.AutoSize = true;
            this.soDienThoaiAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soDienThoaiAccount.Location = new System.Drawing.Point(45, 284);
            this.soDienThoaiAccount.Name = "soDienThoaiAccount";
            this.soDienThoaiAccount.Size = new System.Drawing.Size(121, 24);
            this.soDienThoaiAccount.TabIndex = 16;
            this.soDienThoaiAccount.Text = "Số điện thoại";
            // 
            // gioiTinhAccount
            // 
            this.gioiTinhAccount.AutoSize = true;
            this.gioiTinhAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gioiTinhAccount.Location = new System.Drawing.Point(45, 223);
            this.gioiTinhAccount.Name = "gioiTinhAccount";
            this.gioiTinhAccount.Size = new System.Drawing.Size(78, 24);
            this.gioiTinhAccount.TabIndex = 15;
            this.gioiTinhAccount.Text = "Giới tính";
            // 
            // ngaySinhAccount
            // 
            this.ngaySinhAccount.AutoSize = true;
            this.ngaySinhAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaySinhAccount.Location = new System.Drawing.Point(45, 160);
            this.ngaySinhAccount.Name = "ngaySinhAccount";
            this.ngaySinhAccount.Size = new System.Drawing.Size(94, 24);
            this.ngaySinhAccount.TabIndex = 14;
            this.ngaySinhAccount.Text = "Ngày sinh";
            // 
            // hoTenAccount
            // 
            this.hoTenAccount.AutoSize = true;
            this.hoTenAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoTenAccount.Location = new System.Drawing.Point(45, 95);
            this.hoTenAccount.Name = "hoTenAccount";
            this.hoTenAccount.Size = new System.Drawing.Size(98, 24);
            this.hoTenAccount.TabIndex = 13;
            this.hoTenAccount.Text = "Họ và Tên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvAccount);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 608);
            this.panel1.TabIndex = 0;
            // 
            // dgvAccount
            // 
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(3, 0);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.Size = new System.Drawing.Size(476, 604);
            this.dgvAccount.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btdichvu1);
            this.tabPage3.Controls.Add(this.btdichvu2);
            this.tabPage3.Controls.Add(this.btdichvu3);
            this.tabPage3.Controls.Add(this.paneldichvu);
            this.tabPage3.Controls.Add(this.datadichvu);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(956, 614);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Dịch vụ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(956, 614);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Thống Kê";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // datadichvu
            // 
            this.datadichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datadichvu.Location = new System.Drawing.Point(6, 6);
            this.datadichvu.Name = "datadichvu";
            this.datadichvu.Size = new System.Drawing.Size(479, 584);
            this.datadichvu.TabIndex = 1;
            // 
            // paneldichvu
            // 
            this.paneldichvu.BackColor = System.Drawing.Color.Transparent;
            this.paneldichvu.Controls.Add(this.text3dichvu);
            this.paneldichvu.Controls.Add(this.text2dichvu);
            this.paneldichvu.Controls.Add(this.text1dichvu);
            this.paneldichvu.Controls.Add(this.lb3dichvu);
            this.paneldichvu.Controls.Add(this.lb2dichvu);
            this.paneldichvu.Controls.Add(this.lb1dichvu);
            this.paneldichvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paneldichvu.Location = new System.Drawing.Point(491, 6);
            this.paneldichvu.Name = "paneldichvu";
            this.paneldichvu.Size = new System.Drawing.Size(459, 483);
            this.paneldichvu.TabIndex = 2;
            // 
            // btdichvu1
            // 
            this.btdichvu1.Location = new System.Drawing.Point(536, 511);
            this.btdichvu1.Name = "btdichvu1";
            this.btdichvu1.Size = new System.Drawing.Size(92, 57);
            this.btdichvu1.TabIndex = 1;
            this.btdichvu1.Text = "Thêm";
            this.btdichvu1.UseVisualStyleBackColor = true;
            // 
            // btdichvu2
            // 
            this.btdichvu2.Location = new System.Drawing.Point(674, 511);
            this.btdichvu2.Name = "btdichvu2";
            this.btdichvu2.Size = new System.Drawing.Size(92, 57);
            this.btdichvu2.TabIndex = 2;
            this.btdichvu2.Text = "Sửa";
            this.btdichvu2.UseVisualStyleBackColor = true;
            // 
            // btdichvu3
            // 
            this.btdichvu3.Location = new System.Drawing.Point(811, 511);
            this.btdichvu3.Name = "btdichvu3";
            this.btdichvu3.Size = new System.Drawing.Size(92, 57);
            this.btdichvu3.TabIndex = 3;
            this.btdichvu3.Text = "Xóa";
            this.btdichvu3.UseVisualStyleBackColor = true;
            // 
            // lb1dichvu
            // 
            this.lb1dichvu.AutoSize = true;
            this.lb1dichvu.BackColor = System.Drawing.Color.Transparent;
            this.lb1dichvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1dichvu.Location = new System.Drawing.Point(63, 90);
            this.lb1dichvu.Name = "lb1dichvu";
            this.lb1dichvu.Size = new System.Drawing.Size(117, 25);
            this.lb1dichvu.TabIndex = 0;
            this.lb1dichvu.Text = "tên dịch vụ";
            // 
            // lb2dichvu
            // 
            this.lb2dichvu.AutoSize = true;
            this.lb2dichvu.BackColor = System.Drawing.Color.Transparent;
            this.lb2dichvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2dichvu.Location = new System.Drawing.Point(63, 175);
            this.lb2dichvu.Name = "lb2dichvu";
            this.lb2dichvu.Size = new System.Drawing.Size(94, 25);
            this.lb2dichvu.TabIndex = 1;
            this.lb2dichvu.Text = "số lượng";
            // 
            // lb3dichvu
            // 
            this.lb3dichvu.AutoSize = true;
            this.lb3dichvu.BackColor = System.Drawing.Color.Transparent;
            this.lb3dichvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3dichvu.Location = new System.Drawing.Point(63, 257);
            this.lb3dichvu.Name = "lb3dichvu";
            this.lb3dichvu.Size = new System.Drawing.Size(82, 25);
            this.lb3dichvu.TabIndex = 2;
            this.lb3dichvu.Text = "giá tiền";
            // 
            // text1dichvu
            // 
            this.text1dichvu.Location = new System.Drawing.Point(207, 87);
            this.text1dichvu.Name = "text1dichvu";
            this.text1dichvu.Size = new System.Drawing.Size(205, 31);
            this.text1dichvu.TabIndex = 3;
            // 
            // text2dichvu
            // 
            this.text2dichvu.Location = new System.Drawing.Point(207, 172);
            this.text2dichvu.Name = "text2dichvu";
            this.text2dichvu.Size = new System.Drawing.Size(205, 31);
            this.text2dichvu.TabIndex = 4;
            this.text2dichvu.TextChanged += new System.EventHandler(this.text2dichvu_TextChanged);
            // 
            // text3dichvu
            // 
            this.text3dichvu.Location = new System.Drawing.Point(207, 254);
            this.text3dichvu.Name = "text3dichvu";
            this.text3dichvu.Size = new System.Drawing.Size(205, 31);
            this.text3dichvu.TabIndex = 5;
            this.text3dichvu.TextChanged += new System.EventHandler(this.text3dichvu_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 653);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datadichvu)).EndInit();
            this.paneldichvu.ResumeLayout(false);
            this.paneldichvu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btXoaAccount;
        private System.Windows.Forms.Button btSuaAccount;
        private System.Windows.Forms.Button btThemAccount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpNgaySinhAccount;
        private System.Windows.Forms.RadioButton rbNuAccount;
        private System.Windows.Forms.RadioButton rbNamAccount;
        private System.Windows.Forms.TextBox txbDiaChiAccount;
        private System.Windows.Forms.TextBox txbEmailAccount;
        private System.Windows.Forms.TextBox txbSDTAccount;
        private System.Windows.Forms.TextBox txbNameAccount;
        private System.Windows.Forms.Label diaChiAccount;
        private System.Windows.Forms.Label EmailAccount;
        private System.Windows.Forms.Label soDienThoaiAccount;
        private System.Windows.Forms.Label gioiTinhAccount;
        private System.Windows.Forms.Label ngaySinhAccount;
        private System.Windows.Forms.Label hoTenAccount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Button btdichvu3;
        private System.Windows.Forms.Panel paneldichvu;
        private System.Windows.Forms.Button btdichvu2;
        private System.Windows.Forms.Button btdichvu1;
        private System.Windows.Forms.DataGridView datadichvu;
        private System.Windows.Forms.Label lb3dichvu;
        private System.Windows.Forms.Label lb2dichvu;
        private System.Windows.Forms.Label lb1dichvu;
        private System.Windows.Forms.TextBox text3dichvu;
        private System.Windows.Forms.TextBox text2dichvu;
        private System.Windows.Forms.TextBox text1dichvu;
    }
}