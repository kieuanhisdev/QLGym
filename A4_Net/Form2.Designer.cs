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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel1Account = new System.Windows.Forms.Panel();
            this.panel2Account = new System.Windows.Forms.Panel();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.hoTenAccount = new System.Windows.Forms.Label();
            this.panel3Account = new System.Windows.Forms.Panel();
            this.ngaySinhAccount = new System.Windows.Forms.Label();
            this.gioiTinhAccount = new System.Windows.Forms.Label();
            this.soDienThoaiAccount = new System.Windows.Forms.Label();
            this.EmailAccount = new System.Windows.Forms.Label();
            this.diaChiAccount = new System.Windows.Forms.Label();
            this.txbNameAccount = new System.Windows.Forms.TextBox();
            this.txbSDTAccount = new System.Windows.Forms.TextBox();
            this.txbEmailAccount = new System.Windows.Forms.TextBox();
            this.txbDiaChiAccount = new System.Windows.Forms.TextBox();
            this.rbNamAccount = new System.Windows.Forms.RadioButton();
            this.rbNuAccount = new System.Windows.Forms.RadioButton();
            this.dtpNgaySinhAccount = new System.Windows.Forms.DateTimePicker();
            this.btThemAccount = new System.Windows.Forms.Button();
            this.btSuaAccount = new System.Windows.Forms.Button();
            this.btXoaAccount = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel1Account.SuspendLayout();
            this.panel2Account.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.panel3Account.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(956, 614);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Trang chủ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(916, 428);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3Account);
            this.tabPage2.Controls.Add(this.panel2Account);
            this.tabPage2.Controls.Add(this.panel1Account);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(956, 614);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tài Khoản";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
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
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(956, 614);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Thống Kê";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel1Account
            // 
            this.panel1Account.Controls.Add(this.dgvAccount);
            this.panel1Account.Location = new System.Drawing.Point(6, 6);
            this.panel1Account.Name = "panel1Account";
            this.panel1Account.Size = new System.Drawing.Size(467, 608);
            this.panel1Account.TabIndex = 0;
            // 
            // panel2Account
            // 
            this.panel2Account.Controls.Add(this.dtpNgaySinhAccount);
            this.panel2Account.Controls.Add(this.rbNuAccount);
            this.panel2Account.Controls.Add(this.rbNamAccount);
            this.panel2Account.Controls.Add(this.txbDiaChiAccount);
            this.panel2Account.Controls.Add(this.txbEmailAccount);
            this.panel2Account.Controls.Add(this.txbSDTAccount);
            this.panel2Account.Controls.Add(this.txbNameAccount);
            this.panel2Account.Controls.Add(this.diaChiAccount);
            this.panel2Account.Controls.Add(this.EmailAccount);
            this.panel2Account.Controls.Add(this.soDienThoaiAccount);
            this.panel2Account.Controls.Add(this.gioiTinhAccount);
            this.panel2Account.Controls.Add(this.ngaySinhAccount);
            this.panel2Account.Controls.Add(this.hoTenAccount);
            this.panel2Account.Location = new System.Drawing.Point(479, 6);
            this.panel2Account.Name = "panel2Account";
            this.panel2Account.Size = new System.Drawing.Size(473, 442);
            this.panel2Account.TabIndex = 1;
            // 
            // dgvAccount
            // 
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(6, 3);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.Size = new System.Drawing.Size(461, 599);
            this.dgvAccount.TabIndex = 0;
            // 
            // hoTenAccount
            // 
            this.hoTenAccount.AutoSize = true;
            this.hoTenAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoTenAccount.Location = new System.Drawing.Point(51, 53);
            this.hoTenAccount.Name = "hoTenAccount";
            this.hoTenAccount.Size = new System.Drawing.Size(98, 24);
            this.hoTenAccount.TabIndex = 0;
            this.hoTenAccount.Text = "Họ và Tên";
            // 
            // panel3Account
            // 
            this.panel3Account.Controls.Add(this.btXoaAccount);
            this.panel3Account.Controls.Add(this.btSuaAccount);
            this.panel3Account.Controls.Add(this.btThemAccount);
            this.panel3Account.Location = new System.Drawing.Point(478, 455);
            this.panel3Account.Name = "panel3Account";
            this.panel3Account.Size = new System.Drawing.Size(476, 153);
            this.panel3Account.TabIndex = 2;
            // 
            // ngaySinhAccount
            // 
            this.ngaySinhAccount.AutoSize = true;
            this.ngaySinhAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaySinhAccount.Location = new System.Drawing.Point(51, 118);
            this.ngaySinhAccount.Name = "ngaySinhAccount";
            this.ngaySinhAccount.Size = new System.Drawing.Size(94, 24);
            this.ngaySinhAccount.TabIndex = 1;
            this.ngaySinhAccount.Text = "Ngày sinh";
            // 
            // gioiTinhAccount
            // 
            this.gioiTinhAccount.AutoSize = true;
            this.gioiTinhAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gioiTinhAccount.Location = new System.Drawing.Point(51, 181);
            this.gioiTinhAccount.Name = "gioiTinhAccount";
            this.gioiTinhAccount.Size = new System.Drawing.Size(78, 24);
            this.gioiTinhAccount.TabIndex = 2;
            this.gioiTinhAccount.Text = "Giới tính";
            // 
            // soDienThoaiAccount
            // 
            this.soDienThoaiAccount.AutoSize = true;
            this.soDienThoaiAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soDienThoaiAccount.Location = new System.Drawing.Point(51, 242);
            this.soDienThoaiAccount.Name = "soDienThoaiAccount";
            this.soDienThoaiAccount.Size = new System.Drawing.Size(121, 24);
            this.soDienThoaiAccount.TabIndex = 3;
            this.soDienThoaiAccount.Text = "Số điện thoại";
            // 
            // EmailAccount
            // 
            this.EmailAccount.AutoSize = true;
            this.EmailAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAccount.Location = new System.Drawing.Point(51, 302);
            this.EmailAccount.Name = "EmailAccount";
            this.EmailAccount.Size = new System.Drawing.Size(57, 24);
            this.EmailAccount.TabIndex = 4;
            this.EmailAccount.Text = "Email";
            // 
            // diaChiAccount
            // 
            this.diaChiAccount.AutoSize = true;
            this.diaChiAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diaChiAccount.Location = new System.Drawing.Point(51, 367);
            this.diaChiAccount.Name = "diaChiAccount";
            this.diaChiAccount.Size = new System.Drawing.Size(67, 24);
            this.diaChiAccount.TabIndex = 5;
            this.diaChiAccount.Text = "Địa chỉ";
            // 
            // txbNameAccount
            // 
            this.txbNameAccount.Location = new System.Drawing.Point(187, 58);
            this.txbNameAccount.Name = "txbNameAccount";
            this.txbNameAccount.Size = new System.Drawing.Size(233, 20);
            this.txbNameAccount.TabIndex = 6;
            // 
            // txbSDTAccount
            // 
            this.txbSDTAccount.Location = new System.Drawing.Point(187, 246);
            this.txbSDTAccount.Name = "txbSDTAccount";
            this.txbSDTAccount.Size = new System.Drawing.Size(233, 20);
            this.txbSDTAccount.TabIndex = 7;
            // 
            // txbEmailAccount
            // 
            this.txbEmailAccount.Location = new System.Drawing.Point(187, 307);
            this.txbEmailAccount.Name = "txbEmailAccount";
            this.txbEmailAccount.Size = new System.Drawing.Size(233, 20);
            this.txbEmailAccount.TabIndex = 8;
            // 
            // txbDiaChiAccount
            // 
            this.txbDiaChiAccount.Location = new System.Drawing.Point(187, 372);
            this.txbDiaChiAccount.Name = "txbDiaChiAccount";
            this.txbDiaChiAccount.Size = new System.Drawing.Size(233, 20);
            this.txbDiaChiAccount.TabIndex = 9;
            // 
            // rbNamAccount
            // 
            this.rbNamAccount.AutoSize = true;
            this.rbNamAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNamAccount.Location = new System.Drawing.Point(188, 179);
            this.rbNamAccount.Name = "rbNamAccount";
            this.rbNamAccount.Size = new System.Drawing.Size(68, 28);
            this.rbNamAccount.TabIndex = 10;
            this.rbNamAccount.TabStop = true;
            this.rbNamAccount.Text = "Nam";
            this.rbNamAccount.UseVisualStyleBackColor = true;
            // 
            // rbNuAccount
            // 
            this.rbNuAccount.AutoSize = true;
            this.rbNuAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNuAccount.Location = new System.Drawing.Point(291, 179);
            this.rbNuAccount.Name = "rbNuAccount";
            this.rbNuAccount.Size = new System.Drawing.Size(53, 28);
            this.rbNuAccount.TabIndex = 11;
            this.rbNuAccount.TabStop = true;
            this.rbNuAccount.Text = "Nữ";
            this.rbNuAccount.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinhAccount
            // 
            this.dtpNgaySinhAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinhAccount.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinhAccount.Location = new System.Drawing.Point(187, 121);
            this.dtpNgaySinhAccount.Name = "dtpNgaySinhAccount";
            this.dtpNgaySinhAccount.Size = new System.Drawing.Size(233, 29);
            this.dtpNgaySinhAccount.TabIndex = 12;
            // 
            // btThemAccount
            // 
            this.btThemAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemAccount.Location = new System.Drawing.Point(34, 65);
            this.btThemAccount.Name = "btThemAccount";
            this.btThemAccount.Size = new System.Drawing.Size(116, 50);
            this.btThemAccount.TabIndex = 0;
            this.btThemAccount.Text = "Thêm";
            this.btThemAccount.UseVisualStyleBackColor = true;
            // 
            // btSuaAccount
            // 
            this.btSuaAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaAccount.Location = new System.Drawing.Point(188, 65);
            this.btSuaAccount.Name = "btSuaAccount";
            this.btSuaAccount.Size = new System.Drawing.Size(121, 50);
            this.btSuaAccount.TabIndex = 1;
            this.btSuaAccount.Text = "Sửa";
            this.btSuaAccount.UseVisualStyleBackColor = true;
            // 
            // btXoaAccount
            // 
            this.btXoaAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaAccount.Location = new System.Drawing.Point(342, 65);
            this.btXoaAccount.Name = "btXoaAccount";
            this.btXoaAccount.Size = new System.Drawing.Size(113, 50);
            this.btXoaAccount.TabIndex = 2;
            this.btXoaAccount.Text = "Xóa";
            this.btXoaAccount.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
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
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel1Account.ResumeLayout(false);
            this.panel2Account.ResumeLayout(false);
            this.panel2Account.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.panel3Account.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;


        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3Account;
        private System.Windows.Forms.Panel panel2Account;
        private System.Windows.Forms.Label hoTenAccount;
        private System.Windows.Forms.Panel panel1Account;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Label diaChiAccount;
        private System.Windows.Forms.Label EmailAccount;
        private System.Windows.Forms.Label soDienThoaiAccount;
        private System.Windows.Forms.Label gioiTinhAccount;
        private System.Windows.Forms.Label ngaySinhAccount;
        private System.Windows.Forms.TextBox txbDiaChiAccount;
        private System.Windows.Forms.TextBox txbEmailAccount;
        private System.Windows.Forms.TextBox txbSDTAccount;
        private System.Windows.Forms.TextBox txbNameAccount;
        private System.Windows.Forms.DateTimePicker dtpNgaySinhAccount;
        private System.Windows.Forms.RadioButton rbNuAccount;
        private System.Windows.Forms.RadioButton rbNamAccount;
        private System.Windows.Forms.Button btXoaAccount;
        private System.Windows.Forms.Button btSuaAccount;
        private System.Windows.Forms.Button btThemAccount;
        private System.Windows.Forms.Label label2;
    }
}