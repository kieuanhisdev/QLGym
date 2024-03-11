namespace A4_Net
{
    partial class Form5
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
            this.panthongke = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvbanchitiet = new System.Windows.Forms.DataGridView();
            this.btsodo = new System.Windows.Forms.Button();
            this.bttheoquy = new System.Windows.Forms.Button();
            this.bttheothang = new System.Windows.Forms.Button();
            this.bttheongay = new System.Windows.Forms.Button();
            this.panthongke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbanchitiet)).BeginInit();
            this.SuspendLayout();
            // 
            // panthongke
            // 
            this.panthongke.Controls.Add(this.button2);
            this.panthongke.Controls.Add(this.button1);
            this.panthongke.Controls.Add(this.textBox1);
            this.panthongke.Controls.Add(this.label1);
            this.panthongke.Controls.Add(this.dgvbanchitiet);
            this.panthongke.Controls.Add(this.btsodo);
            this.panthongke.Controls.Add(this.bttheoquy);
            this.panthongke.Controls.Add(this.bttheothang);
            this.panthongke.Controls.Add(this.bttheongay);
            this.panthongke.Location = new System.Drawing.Point(7, 11);
            this.panthongke.Margin = new System.Windows.Forms.Padding(2);
            this.panthongke.Name = "panthongke";
            this.panthongke.Size = new System.Drawing.Size(1349, 743);
            this.panthongke.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1139, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 52);
            this.button2.TabIndex = 8;
            this.button2.Text = "Xuất file";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1212, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1024, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1020, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã hóa đơn";
            // 
            // dgvbanchitiet
            // 
            this.dgvbanchitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbanchitiet.Location = new System.Drawing.Point(0, 2);
            this.dgvbanchitiet.Margin = new System.Windows.Forms.Padding(2);
            this.dgvbanchitiet.Name = "dgvbanchitiet";
            this.dgvbanchitiet.RowHeadersWidth = 51;
            this.dgvbanchitiet.RowTemplate.Height = 24;
            this.dgvbanchitiet.Size = new System.Drawing.Size(997, 739);
            this.dgvbanchitiet.TabIndex = 4;
            // 
            // btsodo
            // 
            this.btsodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsodo.Location = new System.Drawing.Point(1070, 268);
            this.btsodo.Margin = new System.Windows.Forms.Padding(2);
            this.btsodo.Name = "btsodo";
            this.btsodo.Size = new System.Drawing.Size(100, 46);
            this.btsodo.TabIndex = 3;
            this.btsodo.Text = "sơ đồ";
            this.btsodo.UseVisualStyleBackColor = true;
            // 
            // bttheoquy
            // 
            this.bttheoquy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttheoquy.Location = new System.Drawing.Point(1204, 268);
            this.bttheoquy.Margin = new System.Windows.Forms.Padding(2);
            this.bttheoquy.Name = "bttheoquy";
            this.bttheoquy.Size = new System.Drawing.Size(100, 46);
            this.bttheoquy.TabIndex = 2;
            this.bttheoquy.Text = "theo quý";
            this.bttheoquy.UseVisualStyleBackColor = true;
            // 
            // bttheothang
            // 
            this.bttheothang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttheothang.Location = new System.Drawing.Point(1070, 174);
            this.bttheothang.Margin = new System.Windows.Forms.Padding(2);
            this.bttheothang.Name = "bttheothang";
            this.bttheothang.Size = new System.Drawing.Size(100, 46);
            this.bttheothang.TabIndex = 1;
            this.bttheothang.Text = "theo tháng";
            this.bttheothang.UseVisualStyleBackColor = true;
            // 
            // bttheongay
            // 
            this.bttheongay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttheongay.Location = new System.Drawing.Point(1212, 174);
            this.bttheongay.Margin = new System.Windows.Forms.Padding(2);
            this.bttheongay.Name = "bttheongay";
            this.bttheongay.Size = new System.Drawing.Size(92, 46);
            this.bttheongay.TabIndex = 0;
            this.bttheongay.Text = "theo ngày";
            this.bttheongay.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 755);
            this.Controls.Add(this.panthongke);
            this.Name = "Form5";
            this.Text = "Form5";
            this.panthongke.ResumeLayout(false);
            this.panthongke.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbanchitiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panthongke;
        private System.Windows.Forms.DataGridView dgvbanchitiet;
        private System.Windows.Forms.Button btsodo;
        private System.Windows.Forms.Button bttheoquy;
        private System.Windows.Forms.Button bttheothang;
        private System.Windows.Forms.Button bttheongay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}