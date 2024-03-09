namespace A4_Net
{
    partial class Form3
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btXoaAccount = new System.Windows.Forms.Button();
            this.btSuaAccount = new System.Windows.Forms.Button();
            this.btThemAccount = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvAccount);
            this.panel2.Location = new System.Drawing.Point(455, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 660);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dtpNgaySinhAccount
            // 
            this.dtpNgaySinhAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinhAccount.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinhAccount.Location = new System.Drawing.Point(155, 106);
            this.dtpNgaySinhAccount.Name = "dtpNgaySinhAccount";
            this.dtpNgaySinhAccount.Size = new System.Drawing.Size(233, 29);
            this.dtpNgaySinhAccount.TabIndex = 25;
            // 
            // rbNuAccount
            // 
            this.rbNuAccount.AutoSize = true;
            this.rbNuAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNuAccount.Location = new System.Drawing.Point(259, 164);
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
            this.rbNamAccount.Location = new System.Drawing.Point(156, 164);
            this.rbNamAccount.Name = "rbNamAccount";
            this.rbNamAccount.Size = new System.Drawing.Size(68, 28);
            this.rbNamAccount.TabIndex = 23;
            this.rbNamAccount.TabStop = true;
            this.rbNamAccount.Text = "Nam";
            this.rbNamAccount.UseVisualStyleBackColor = true;
            // 
            // txbDiaChiAccount
            // 
            this.txbDiaChiAccount.Location = new System.Drawing.Point(155, 357);
            this.txbDiaChiAccount.Name = "txbDiaChiAccount";
            this.txbDiaChiAccount.Size = new System.Drawing.Size(233, 20);
            this.txbDiaChiAccount.TabIndex = 22;
            // 
            // txbEmailAccount
            // 
            this.txbEmailAccount.Location = new System.Drawing.Point(155, 292);
            this.txbEmailAccount.Name = "txbEmailAccount";
            this.txbEmailAccount.Size = new System.Drawing.Size(233, 20);
            this.txbEmailAccount.TabIndex = 21;
            // 
            // txbSDTAccount
            // 
            this.txbSDTAccount.Location = new System.Drawing.Point(155, 231);
            this.txbSDTAccount.Name = "txbSDTAccount";
            this.txbSDTAccount.Size = new System.Drawing.Size(233, 20);
            this.txbSDTAccount.TabIndex = 20;
            // 
            // txbNameAccount
            // 
            this.txbNameAccount.Location = new System.Drawing.Point(155, 43);
            this.txbNameAccount.Name = "txbNameAccount";
            this.txbNameAccount.Size = new System.Drawing.Size(233, 20);
            this.txbNameAccount.TabIndex = 19;
            // 
            // diaChiAccount
            // 
            this.diaChiAccount.AutoSize = true;
            this.diaChiAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diaChiAccount.Location = new System.Drawing.Point(19, 352);
            this.diaChiAccount.Name = "diaChiAccount";
            this.diaChiAccount.Size = new System.Drawing.Size(67, 24);
            this.diaChiAccount.TabIndex = 18;
            this.diaChiAccount.Text = "Địa chỉ";
            // 
            // EmailAccount
            // 
            this.EmailAccount.AutoSize = true;
            this.EmailAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAccount.Location = new System.Drawing.Point(19, 287);
            this.EmailAccount.Name = "EmailAccount";
            this.EmailAccount.Size = new System.Drawing.Size(57, 24);
            this.EmailAccount.TabIndex = 17;
            this.EmailAccount.Text = "Email";
            // 
            // soDienThoaiAccount
            // 
            this.soDienThoaiAccount.AutoSize = true;
            this.soDienThoaiAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soDienThoaiAccount.Location = new System.Drawing.Point(19, 227);
            this.soDienThoaiAccount.Name = "soDienThoaiAccount";
            this.soDienThoaiAccount.Size = new System.Drawing.Size(121, 24);
            this.soDienThoaiAccount.TabIndex = 16;
            this.soDienThoaiAccount.Text = "Số điện thoại";
            // 
            // gioiTinhAccount
            // 
            this.gioiTinhAccount.AutoSize = true;
            this.gioiTinhAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gioiTinhAccount.Location = new System.Drawing.Point(19, 166);
            this.gioiTinhAccount.Name = "gioiTinhAccount";
            this.gioiTinhAccount.Size = new System.Drawing.Size(78, 24);
            this.gioiTinhAccount.TabIndex = 15;
            this.gioiTinhAccount.Text = "Giới tính";
            // 
            // ngaySinhAccount
            // 
            this.ngaySinhAccount.AutoSize = true;
            this.ngaySinhAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaySinhAccount.Location = new System.Drawing.Point(19, 103);
            this.ngaySinhAccount.Name = "ngaySinhAccount";
            this.ngaySinhAccount.Size = new System.Drawing.Size(94, 24);
            this.ngaySinhAccount.TabIndex = 14;
            this.ngaySinhAccount.Text = "Ngày sinh";
            // 
            // hoTenAccount
            // 
            this.hoTenAccount.AutoSize = true;
            this.hoTenAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoTenAccount.Location = new System.Drawing.Point(19, 38);
            this.hoTenAccount.Name = "hoTenAccount";
            this.hoTenAccount.Size = new System.Drawing.Size(98, 24);
            this.hoTenAccount.TabIndex = 13;
            this.hoTenAccount.Text = "Họ và Tên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.soDienThoaiAccount);
            this.panel1.Controls.Add(this.dtpNgaySinhAccount);
            this.panel1.Controls.Add(this.hoTenAccount);
            this.panel1.Controls.Add(this.rbNuAccount);
            this.panel1.Controls.Add(this.ngaySinhAccount);
            this.panel1.Controls.Add(this.rbNamAccount);
            this.panel1.Controls.Add(this.gioiTinhAccount);
            this.panel1.Controls.Add(this.txbDiaChiAccount);
            this.panel1.Controls.Add(this.EmailAccount);
            this.panel1.Controls.Add(this.txbEmailAccount);
            this.panel1.Controls.Add(this.diaChiAccount);
            this.panel1.Controls.Add(this.txbSDTAccount);
            this.panel1.Controls.Add(this.txbNameAccount);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 622);
            this.panel1.TabIndex = 3;
            // 
            // dgvAccount
            // 
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(0, 3);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersWidth = 51;
            this.dgvAccount.Size = new System.Drawing.Size(897, 725);
            this.dgvAccount.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btXoaAccount);
            this.panel3.Controls.Add(this.btSuaAccount);
            this.panel3.Controls.Add(this.btThemAccount);
            this.panel3.Location = new System.Drawing.Point(12, 640);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(437, 103);
            this.panel3.TabIndex = 4;
            // 
            // btXoaAccount
            // 
            this.btXoaAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaAccount.Location = new System.Drawing.Point(312, 26);
            this.btXoaAccount.Name = "btXoaAccount";
            this.btXoaAccount.Size = new System.Drawing.Size(113, 50);
            this.btXoaAccount.TabIndex = 5;
            this.btXoaAccount.Text = "Xóa";
            this.btXoaAccount.UseVisualStyleBackColor = true;
            // 
            // btSuaAccount
            // 
            this.btSuaAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaAccount.Location = new System.Drawing.Point(157, 26);
            this.btSuaAccount.Name = "btSuaAccount";
            this.btSuaAccount.Size = new System.Drawing.Size(121, 50);
            this.btSuaAccount.TabIndex = 4;
            this.btSuaAccount.Text = "Sửa";
            this.btSuaAccount.UseVisualStyleBackColor = true;
            // 
            // btThemAccount
            // 
            this.btThemAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemAccount.Location = new System.Drawing.Point(3, 26);
            this.btThemAccount.Name = "btThemAccount";
            this.btThemAccount.Size = new System.Drawing.Size(116, 50);
            this.btThemAccount.TabIndex = 3;
            this.btThemAccount.Text = "Thêm";
            this.btThemAccount.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(456, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(899, 67);
            this.panel4.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm Kiếm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(669, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(785, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 755);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btXoaAccount;
        private System.Windows.Forms.Button btSuaAccount;
        private System.Windows.Forms.Button btThemAccount;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}