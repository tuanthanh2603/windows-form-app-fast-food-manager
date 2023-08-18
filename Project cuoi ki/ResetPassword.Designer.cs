
namespace Project_cuoi_ki
{
    partial class ResetPassword
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnForgotPW = new System.Windows.Forms.Button();
            this.txtbUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Location = new System.Drawing.Point(623, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(38, 398);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.btnForgotPW);
            this.panel1.Controls.Add(this.txtbUsername);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(139, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 398);
            this.panel1.TabIndex = 5;
            // 
            // btnForgotPW
            // 
            this.btnForgotPW.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnForgotPW.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgotPW.ForeColor = System.Drawing.SystemColors.Control;
            this.btnForgotPW.Location = new System.Drawing.Point(78, 254);
            this.btnForgotPW.Name = "btnForgotPW";
            this.btnForgotPW.Size = new System.Drawing.Size(337, 47);
            this.btnForgotPW.TabIndex = 5;
            this.btnForgotPW.Text = "CHANGE";
            this.btnForgotPW.UseVisualStyleBackColor = false;
            this.btnForgotPW.Click += new System.EventHandler(this.btnForgotPW_Click);
            // 
            // txtbUsername
            // 
            this.txtbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbUsername.Location = new System.Drawing.Point(78, 199);
            this.txtbUsername.Multiline = true;
            this.txtbUsername.Name = "txtbUsername";
            this.txtbUsername.Size = new System.Drawing.Size(337, 40);
            this.txtbUsername.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "USERNAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(115, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORGOT PASSWORD";
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(710, 12);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(78, 46);
            this.button13.TabIndex = 17;
            this.button13.Text = "Back";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click_1);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_cuoi_ki.Properties.Resources._360_F_283136113_b3VRHNiOPFMOluzYJPpfuoH8Czh9c743;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResetPassword";
            this.Text = "ResetPassword";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnForgotPW;
        private System.Windows.Forms.TextBox txtbUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button13;
    }
}