using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Project_cuoi_ki.PControl;
namespace Project_cuoi_ki
{
    public partial class FormRessetPassword : Form
    {
        ControlNhanVien ctrlNV = new ControlNhanVien();
        public FormRessetPassword()
        {
            InitializeComponent();
        }

        private void txtbTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            txtbMatKhauNhapLai.UseSystemPasswordChar = true;
            txtbMatKhauMoi.UseSystemPasswordChar = true;
            checkBox1.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtbMatKhauMoi.UseSystemPasswordChar = false;
                txtbMatKhauNhapLai.UseSystemPasswordChar = false;
            }
            else
            {
                txtbMatKhauMoi.UseSystemPasswordChar = true;
                txtbMatKhauNhapLai.UseSystemPasswordChar = true;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(openNewFormResetPassword);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void openNewFormResetPassword()
        {

            Application.Run(new ResetPassword());

        }

        private void btnForgotPW_Click(object sender, EventArgs e)
        {
            NHANVIEN s = new NHANVIEN();
            s = ctrlNV.kiemTraDangNhap(txtbTenDangNhap.Text, txtbMatKhauMoi.Text);
            if (txtbMatKhauMoi.TextLength <= 0 || txtbMatKhauNhapLai.TextLength <= 0 || txtbTenDangNhap.TextLength <= 0)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (s.SDT == txtbMatKhauMoi.Text)
                {
                    MessageBox.Show("Bạn đã nhớ lại mật khẩu", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtbMatKhauMoi.Text == txtbMatKhauNhapLai.Text)
                {
                    MessageBox.Show("Mat khau moi va mat khau cu trung nhau!");
                }
                else if (txtbMatKhauMoi.Text != txtbMatKhauNhapLai.Text)
                {
                    do
                    {
                        MessageBox.Show("Vui long nhap lai mat khau");
                        txtbMatKhauMoi.Clear();
                        txtbMatKhauNhapLai.Clear();
                        txtbMatKhauMoi.Focus();
                    } while (txtbMatKhauMoi.Text != txtbMatKhauNhapLai.Text);


                }
                else
                {
                    s.SDT = txtbMatKhauMoi.Text;
                    ctrlNV.update(s);
                    MessageBox.Show("Thay doi thanh cong");
                }
            }
        }
    }
}
