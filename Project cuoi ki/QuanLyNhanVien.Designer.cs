namespace Project_cuoi_ki
{
    partial class QuanLyNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtbSDTNV = new System.Windows.Forms.TextBox();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbbLoaiNV = new System.Windows.Forms.ComboBox();
            this.txtbTenNV = new System.Windows.Forms.TextBox();
            this.txtbMaNV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtNV = new System.Windows.Forms.DataGridView();
            this.txtbTimNV = new System.Windows.Forms.TextBox();
            this.btnTimNV = new System.Windows.Forms.Button();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.btnXemNV = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtbSDTNV);
            this.panel2.Controls.Add(this.rdNu);
            this.panel2.Controls.Add(this.rdNam);
            this.panel2.Controls.Add(this.dtNgaySinh);
            this.panel2.Controls.Add(this.cbbLoaiNV);
            this.panel2.Controls.Add(this.txtbTenNV);
            this.panel2.Controls.Add(this.txtbMaNV);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(103, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(817, 166);
            this.panel2.TabIndex = 1;
            // 
            // txtbSDTNV
            // 
            this.txtbSDTNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSDTNV.Location = new System.Drawing.Point(564, 104);
            this.txtbSDTNV.MaxLength = 11;
            this.txtbSDTNV.Name = "txtbSDTNV";
            this.txtbSDTNV.Size = new System.Drawing.Size(197, 22);
            this.txtbSDTNV.TabIndex = 12;
            this.txtbSDTNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbSDTNV_KeyPress);
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNu.Location = new System.Drawing.Point(620, 67);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(42, 20);
            this.rdNu.TabIndex = 11;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNam.Location = new System.Drawing.Point(565, 67);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(54, 20);
            this.rdNam.TabIndex = 10;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaySinh.Location = new System.Drawing.Point(564, 28);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(200, 22);
            this.dtNgaySinh.TabIndex = 9;
            // 
            // cbbLoaiNV
            // 
            this.cbbLoaiNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoaiNV.FormattingEnabled = true;
            this.cbbLoaiNV.Location = new System.Drawing.Point(161, 64);
            this.cbbLoaiNV.Name = "cbbLoaiNV";
            this.cbbLoaiNV.Size = new System.Drawing.Size(204, 24);
            this.cbbLoaiNV.TabIndex = 8;
            // 
            // txtbTenNV
            // 
            this.txtbTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTenNV.Location = new System.Drawing.Point(161, 104);
            this.txtbTenNV.Name = "txtbTenNV";
            this.txtbTenNV.Size = new System.Drawing.Size(204, 22);
            this.txtbTenNV.TabIndex = 7;
            // 
            // txtbMaNV
            // 
            this.txtbMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMaNV.Location = new System.Drawing.Point(161, 28);
            this.txtbMaNV.Name = "txtbMaNV";
            this.txtbMaNV.Size = new System.Drawing.Size(204, 22);
            this.txtbMaNV.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(58, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Loại nhân viên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(473, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Số điện thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(473, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(473, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên nhân viên";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtNV);
            this.panel3.Location = new System.Drawing.Point(103, 231);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(818, 270);
            this.panel3.TabIndex = 2;
            // 
            // dtNV
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtNV.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtNV.Location = new System.Drawing.Point(0, 0);
            this.dtNV.Name = "dtNV";
            this.dtNV.Size = new System.Drawing.Size(818, 270);
            this.dtNV.TabIndex = 0;
            this.dtNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtNV_CellClick);
            // 
            // txtbTimNV
            // 
            this.txtbTimNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTimNV.Location = new System.Drawing.Point(709, 193);
            this.txtbTimNV.Name = "txtbTimNV";
            this.txtbTimNV.Size = new System.Drawing.Size(180, 22);
            this.txtbTimNV.TabIndex = 18;
            // 
            // btnTimNV
            // 
            this.btnTimNV.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTimNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimNV.Image = global::Project_cuoi_ki.Properties.Resources.img_Search3;
            this.btnTimNV.Location = new System.Drawing.Point(895, 191);
            this.btnTimNV.Name = "btnTimNV";
            this.btnTimNV.Size = new System.Drawing.Size(25, 25);
            this.btnTimNV.TabIndex = 19;
            this.btnTimNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimNV.UseVisualStyleBackColor = false;
            this.btnTimNV.Click += new System.EventHandler(this.btnTimNV_Click);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNV.Image = global::Project_cuoi_ki.Properties.Resources.img_Clear;
            this.btnXoaNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaNV.Location = new System.Drawing.Point(430, 184);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(90, 40);
            this.btnXoaNV.TabIndex = 16;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaNV.UseVisualStyleBackColor = false;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.BackColor = System.Drawing.Color.Gold;
            this.btnSuaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNV.Image = global::Project_cuoi_ki.Properties.Resources.img_Fix;
            this.btnSuaNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaNV.Location = new System.Drawing.Point(210, 184);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(90, 40);
            this.btnSuaNV.TabIndex = 17;
            this.btnSuaNV.Text = "Sửa";
            this.btnSuaNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaNV.UseVisualStyleBackColor = false;
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // btnXemNV
            // 
            this.btnXemNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXemNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemNV.Image = global::Project_cuoi_ki.Properties.Resources.img_Xem;
            this.btnXemNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemNV.Location = new System.Drawing.Point(320, 184);
            this.btnXemNV.Name = "btnXemNV";
            this.btnXemNV.Size = new System.Drawing.Size(90, 40);
            this.btnXemNV.TabIndex = 15;
            this.btnXemNV.Text = "Xem";
            this.btnXemNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemNV.UseVisualStyleBackColor = false;
            this.btnXemNV.Click += new System.EventHandler(this.btnXemNV_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnThemNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNV.Image = global::Project_cuoi_ki.Properties.Resources.img_Add;
            this.btnThemNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemNV.Location = new System.Drawing.Point(100, 184);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(90, 40);
            this.btnThemNV.TabIndex = 14;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemNV.UseVisualStyleBackColor = false;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(992, 521);
            this.Controls.Add(this.btnTimNV);
            this.Controls.Add(this.txtbTimNV);
            this.Controls.Add(this.btnXoaNV);
            this.Controls.Add(this.btnSuaNV);
            this.Controls.Add(this.btnXemNV);
            this.Controls.Add(this.btnThemNV);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "QuanLyNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyNhanVien";
            this.Load += new System.EventHandler(this.QuanLyNhanVien_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtbSDTNV;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.ComboBox cbbLoaiNV;
        private System.Windows.Forms.TextBox txtbTenNV;
        private System.Windows.Forms.TextBox txtbMaNV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtNV;
        private System.Windows.Forms.Button btnTimNV;
        private System.Windows.Forms.TextBox txtbTimNV;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.Button btnSuaNV;
        private System.Windows.Forms.Button btnXemNV;
        private System.Windows.Forms.Button btnThemNV;
    }
}