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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panthongke = new System.Windows.Forms.Panel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvbanchitiet = new System.Windows.Forms.DataGridView();
            this.bttheongay = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.panthongke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbanchitiet)).BeginInit();
            this.SuspendLayout();
            // 
            // panthongke
            // 
            this.panthongke.Controls.Add(this.button3);
            this.panthongke.Controls.Add(this.dateTimePicker2);
            this.panthongke.Controls.Add(this.dateTimePicker1);
            this.panthongke.Controls.Add(this.chart2);
            this.panthongke.Controls.Add(this.button2);
            this.panthongke.Controls.Add(this.button1);
            this.panthongke.Controls.Add(this.textBox1);
            this.panthongke.Controls.Add(this.label1);
            this.panthongke.Controls.Add(this.dgvbanchitiet);
            this.panthongke.Controls.Add(this.bttheongay);
            this.panthongke.Location = new System.Drawing.Point(7, 11);
            this.panthongke.Margin = new System.Windows.Forms.Padding(2);
            this.panthongke.Name = "panthongke";
            this.panthongke.Size = new System.Drawing.Size(1165, 562);
            this.panthongke.TabIndex = 1;
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(594, 3);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(564, 556);
            this.chart2.TabIndex = 11;
            this.chart2.Text = "chart2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(473, 500);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 52);
            this.button2.TabIndex = 8;
            this.button2.Text = "Xuất file";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 469);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(340, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 467);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã hóa đơn";
            // 
            // dgvbanchitiet
            // 
            this.dgvbanchitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbanchitiet.Location = new System.Drawing.Point(13, 55);
            this.dgvbanchitiet.Margin = new System.Windows.Forms.Padding(2);
            this.dgvbanchitiet.Name = "dgvbanchitiet";
            this.dgvbanchitiet.RowHeadersWidth = 51;
            this.dgvbanchitiet.RowTemplate.Height = 24;
            this.dgvbanchitiet.Size = new System.Drawing.Size(554, 387);
            this.dgvbanchitiet.TabIndex = 4;
            this.dgvbanchitiet.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvbanchitiet_CellMouseClick);
            // 
            // bttheongay
            // 
            this.bttheongay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttheongay.Location = new System.Drawing.Point(25, 506);
            this.bttheongay.Margin = new System.Windows.Forms.Padding(2);
            this.bttheongay.Name = "bttheongay";
            this.bttheongay.Size = new System.Drawing.Size(100, 46);
            this.bttheongay.TabIndex = 0;
            this.bttheongay.Text = "Chi tIẾT HÓA ĐƠN";
            this.bttheongay.UseVisualStyleBackColor = true;
            this.bttheongay.Click += new System.EventHandler(this.bttheongay_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(367, 21);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(251, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Tìm kiếm";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 575);
            this.Controls.Add(this.panthongke);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panthongke.ResumeLayout(false);
            this.panthongke.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbanchitiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panthongke;
        private System.Windows.Forms.DataGridView dgvbanchitiet;
        private System.Windows.Forms.Button bttheongay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}