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
            this.panthongke.Controls.Add(this.dgvbanchitiet);
            this.panthongke.Controls.Add(this.btsodo);
            this.panthongke.Controls.Add(this.bttheoquy);
            this.panthongke.Controls.Add(this.bttheothang);
            this.panthongke.Controls.Add(this.bttheongay);
            this.panthongke.Location = new System.Drawing.Point(7, 11);
            this.panthongke.Margin = new System.Windows.Forms.Padding(2);
            this.panthongke.Name = "panthongke";
            this.panthongke.Size = new System.Drawing.Size(926, 640);
            this.panthongke.TabIndex = 1;
            // 
            // dgvbanchitiet
            // 
            this.dgvbanchitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbanchitiet.Location = new System.Drawing.Point(4, 89);
            this.dgvbanchitiet.Margin = new System.Windows.Forms.Padding(2);
            this.dgvbanchitiet.Name = "dgvbanchitiet";
            this.dgvbanchitiet.RowHeadersWidth = 51;
            this.dgvbanchitiet.RowTemplate.Height = 24;
            this.dgvbanchitiet.Size = new System.Drawing.Size(918, 535);
            this.dgvbanchitiet.TabIndex = 4;
            // 
            // btsodo
            // 
            this.btsodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsodo.Location = new System.Drawing.Point(741, 30);
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
            this.bttheoquy.Location = new System.Drawing.Point(519, 30);
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
            this.bttheothang.Location = new System.Drawing.Point(303, 30);
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
            this.bttheongay.Location = new System.Drawing.Point(93, 30);
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
            this.ClientSize = new System.Drawing.Size(940, 662);
            this.Controls.Add(this.panthongke);
            this.Name = "Form5";
            this.Text = "Form5";
            this.panthongke.ResumeLayout(false);
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
    }
}