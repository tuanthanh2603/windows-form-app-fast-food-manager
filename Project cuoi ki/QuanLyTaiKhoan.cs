using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_cuoi_ki.PControl;

namespace Project_cuoi_ki
{
    public partial class QuanLyTaiKhoan : Form
    {
        ControlNhanVien ctrlNV = new ControlNhanVien();
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnLuuTT_Click(object sender, EventArgs e)
        {
            
            NHANVIEN s = new NHANVIEN();
            s = ctrlNV.kiemTraDangNhap(txtbTenDangNhap.Text, txtbMatKhauCu.Text);
            if (txtbTenDangNhap.TextLength <= 0 || txtbMatKhauMoi.TextLength <= 0 || txtbMatKhauCu.TextLength <= 0 || txtbNhapLai.TextLength <= 0)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (s == null)
                {
                    MessageBox.Show("Tai khoan khong ton tai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtbMatKhauMoi.Text == txtbMatKhauCu.Text)
                {
                    MessageBox.Show("Mat khau moi va mat khau cu trung nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtbMatKhauMoi.Text != txtbNhapLai.Text)
                {
                    do
                    {
                        MessageBox.Show("Vui long nhap lai mat khau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtbMatKhauMoi.Clear();
                        txtbNhapLai.Clear();
                        txtbMatKhauMoi.Focus();
                    } while (txtbMatKhauMoi.Text != txtbNhapLai.Text);


                }
                else
                {
                    s.TENNV = txtbTenDangNhap.Text;
                    s.SDT = txtbMatKhauMoi.Text;
                    ctrlNV.update(s);
                    MessageBox.Show("Thay doi thanh cong");
                }
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtbMatKhauCu.UseSystemPasswordChar = false;
                txtbMatKhauMoi.UseSystemPasswordChar = false;
                txtbNhapLai.UseSystemPasswordChar = false;
            }
            else
            {
                txtbMatKhauCu.UseSystemPasswordChar = true;
                txtbMatKhauMoi.UseSystemPasswordChar = true;
                txtbNhapLai.UseSystemPasswordChar = true;
            }
        }

        private void txtbMatKhauCu_TextChanged(object sender, EventArgs e)
        {
            txtbMatKhauCu.UseSystemPasswordChar = true;
            txtbMatKhauMoi.UseSystemPasswordChar = true;
            txtbNhapLai.UseSystemPasswordChar = true;
            checkBox1.Checked = false;
        }
    }
}
