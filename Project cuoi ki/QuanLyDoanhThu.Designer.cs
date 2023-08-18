namespace Project_cuoi_ki
{
    partial class QuanLyDoanhThu
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtDoanhThu = new System.Windows.Forms.DataGridView();
            this.dtNgayCuoi = new System.Windows.Forms.DateTimePicker();
            this.dtNgayDau = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(295, 502);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 9;
            this.textBox1.Visible = false;
            // 
            // dtDoanhThu
            // 
            this.dtDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDoanhThu.Location = new System.Drawing.Point(295, 126);
            this.dtDoanhThu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtDoanhThu.Name = "dtDoanhThu";
            this.dtDoanhThu.RowHeadersWidth = 51;
            this.dtDoanhThu.Size = new System.Drawing.Size(859, 401);
            this.dtDoanhThu.TabIndex = 8;
            this.dtDoanhThu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDoanhThu_CellContentClick);
            // 
            // dtNgayCuoi
            // 
            this.dtNgayCuoi.CustomFormat = "MM/dd/yyyy";
            this.dtNgayCuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayCuoi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayCuoi.Location = new System.Drawing.Point(887, 71);
            this.dtNgayCuoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtNgayCuoi.Name = "dtNgayCuoi";
            this.dtNgayCuoi.Size = new System.Drawing.Size(265, 26);
            this.dtNgayCuoi.TabIndex = 7;
            this.dtNgayCuoi.Value = new System.DateTime(2022, 8, 19, 12, 0, 0, 0);
            // 
            // dtNgayDau
            // 
            this.dtNgayDau.CustomFormat = "MM/dd/yyyy";
            this.dtNgayDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayDau.Location = new System.Drawing.Point(295, 71);
            this.dtNgayDau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtNgayDau.Name = "dtNgayDau";
            this.dtNgayDau.Size = new System.Drawing.Size(265, 26);
            this.dtNgayDau.TabIndex = 5;
            this.dtNgayDau.Value = new System.DateTime(2022, 8, 19, 6, 0, 0, 0);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Image = global::Project_cuoi_ki.Properties.Resources.img_Thong_Ke;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(641, 64);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.btnThongKe.Size = new System.Drawing.Size(157, 46);
            this.btnThongKe.TabIndex = 6;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // QuanLyDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 763);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dtDoanhThu);
            this.Controls.Add(this.dtNgayCuoi);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.dtNgayDau);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QuanLyDoanhThu";
            this.Text = "QuanLyDoanhThu";
            this.Load += new System.EventHandler(this.QuanLyDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtDoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dtDoanhThu;
        private System.Windows.Forms.DateTimePicker dtNgayCuoi;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DateTimePicker dtNgayDau;
    }
}