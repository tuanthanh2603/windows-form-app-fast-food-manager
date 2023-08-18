namespace Project_cuoi_ki
{
    partial class Danhmuc
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
            this.cbbMaLoaiMA = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbMaMA = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoaMA = new System.Windows.Forms.Button();
            this.btnSuaMA = new System.Windows.Forms.Button();
            this.btnXemMA = new System.Windows.Forms.Button();
            this.btnThemMA = new System.Windows.Forms.Button();
            this.txtbGiaBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbTenMA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbTimMA = new System.Windows.Forms.TextBox();
            this.dtMonAn = new System.Windows.Forms.DataGridView();
            this.btnTimMA = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbMaLoaiMA
            // 
            this.cbbMaLoaiMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaLoaiMA.FormattingEnabled = true;
            this.cbbMaLoaiMA.Location = new System.Drawing.Point(157, 110);
            this.cbbMaLoaiMA.Name = "cbbMaLoaiMA";
            this.cbbMaLoaiMA.Size = new System.Drawing.Size(305, 24);
            this.cbbMaLoaiMA.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Mã loại món ăn";
            // 
            // txtbMaMA
            // 
            this.txtbMaMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMaMA.Location = new System.Drawing.Point(157, 168);
            this.txtbMaMA.Name = "txtbMaMA";
            this.txtbMaMA.Size = new System.Drawing.Size(305, 22);
            this.txtbMaMA.TabIndex = 27;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(154, 147);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(73, 16);
            this.label.TabIndex = 26;
            this.label.Text = "Mã món ăn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXoaMA);
            this.panel1.Controls.Add(this.btnSuaMA);
            this.panel1.Controls.Add(this.btnXemMA);
            this.panel1.Controls.Add(this.btnThemMA);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(157, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 137);
            this.panel1.TabIndex = 25;
            // 
            // btnXoaMA
            // 
            this.btnXoaMA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoaMA.Image = global::Project_cuoi_ki.Properties.Resources.img_Clear;
            this.btnXoaMA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaMA.Location = new System.Drawing.Point(168, 76);
            this.btnXoaMA.Name = "btnXoaMA";
            this.btnXoaMA.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnXoaMA.Size = new System.Drawing.Size(98, 42);
            this.btnXoaMA.TabIndex = 3;
            this.btnXoaMA.Text = "Xóa";
            this.btnXoaMA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaMA.UseVisualStyleBackColor = false;
            this.btnXoaMA.Click += new System.EventHandler(this.btnXoaMA_Click);
            // 
            // btnSuaMA
            // 
            this.btnSuaMA.BackColor = System.Drawing.Color.Gold;
            this.btnSuaMA.Image = global::Project_cuoi_ki.Properties.Resources.img_Fix;
            this.btnSuaMA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaMA.Location = new System.Drawing.Point(37, 76);
            this.btnSuaMA.Name = "btnSuaMA";
            this.btnSuaMA.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnSuaMA.Size = new System.Drawing.Size(98, 42);
            this.btnSuaMA.TabIndex = 2;
            this.btnSuaMA.Text = "Sửa";
            this.btnSuaMA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaMA.UseVisualStyleBackColor = false;
            this.btnSuaMA.Click += new System.EventHandler(this.btnSuaMA_Click);
            // 
            // btnXemMA
            // 
            this.btnXemMA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXemMA.Image = global::Project_cuoi_ki.Properties.Resources.img_Xem;
            this.btnXemMA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemMA.Location = new System.Drawing.Point(168, 15);
            this.btnXemMA.Name = "btnXemMA";
            this.btnXemMA.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnXemMA.Size = new System.Drawing.Size(98, 42);
            this.btnXemMA.TabIndex = 1;
            this.btnXemMA.Text = "Xem";
            this.btnXemMA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemMA.UseVisualStyleBackColor = false;
            this.btnXemMA.Click += new System.EventHandler(this.btnXemMA_Click);
            // 
            // btnThemMA
            // 
            this.btnThemMA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnThemMA.Image = global::Project_cuoi_ki.Properties.Resources.img_Add;
            this.btnThemMA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMA.Location = new System.Drawing.Point(37, 15);
            this.btnThemMA.Name = "btnThemMA";
            this.btnThemMA.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnThemMA.Size = new System.Drawing.Size(98, 42);
            this.btnThemMA.TabIndex = 0;
            this.btnThemMA.Text = "Thêm";
            this.btnThemMA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemMA.UseVisualStyleBackColor = false;
            this.btnThemMA.Click += new System.EventHandler(this.btnThemMA_Click);
            // 
            // txtbGiaBan
            // 
            this.txtbGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbGiaBan.Location = new System.Drawing.Point(157, 280);
            this.txtbGiaBan.Name = "txtbGiaBan";
            this.txtbGiaBan.Size = new System.Drawing.Size(305, 22);
            this.txtbGiaBan.TabIndex = 24;
            this.txtbGiaBan.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Giá bán";
            // 
            // txtbTenMA
            // 
            this.txtbTenMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTenMA.Location = new System.Drawing.Point(157, 225);
            this.txtbTenMA.Name = "txtbTenMA";
            this.txtbTenMA.Size = new System.Drawing.Size(305, 22);
            this.txtbTenMA.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên món ăn";
            // 
            // txtbTimMA
            // 
            this.txtbTimMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTimMA.Location = new System.Drawing.Point(647, 41);
            this.txtbTimMA.Name = "txtbTimMA";
            this.txtbTimMA.Size = new System.Drawing.Size(224, 22);
            this.txtbTimMA.TabIndex = 19;
            // 
            // dtMonAn
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtMonAn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtMonAn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtMonAn.Location = new System.Drawing.Point(508, 78);
            this.dtMonAn.Name = "dtMonAn";
            this.dtMonAn.Size = new System.Drawing.Size(394, 389);
            this.dtMonAn.TabIndex = 18;
            this.dtMonAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtMonAn_CellClick);
            // 
            // btnTimMA
            // 
            this.btnTimMA.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTimMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimMA.Image = global::Project_cuoi_ki.Properties.Resources.img_Search3;
            this.btnTimMA.Location = new System.Drawing.Point(877, 40);
            this.btnTimMA.Name = "btnTimMA";
            this.btnTimMA.Size = new System.Drawing.Size(25, 25);
            this.btnTimMA.TabIndex = 30;
            this.btnTimMA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimMA.UseVisualStyleBackColor = false;
            this.btnTimMA.Click += new System.EventHandler(this.btnTimMA_Click);
            // 
            // Danhmuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 574);
            this.Controls.Add(this.btnTimMA);
            this.Controls.Add(this.cbbMaLoaiMA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbMaMA);
            this.Controls.Add(this.label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtbGiaBan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbTenMA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbTimMA);
            this.Controls.Add(this.dtMonAn);
            this.Name = "Danhmuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danhmuc";
            this.Load += new System.EventHandler(this.Danhmuc_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtMonAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbMaLoaiMA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbMaMA;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoaMA;
        private System.Windows.Forms.Button btnSuaMA;
        private System.Windows.Forms.Button btnXemMA;
        private System.Windows.Forms.Button btnThemMA;
        private System.Windows.Forms.TextBox txtbGiaBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbTenMA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbTimMA;
        private System.Windows.Forms.DataGridView dtMonAn;
        private System.Windows.Forms.Button btnTimMA;
    }
}