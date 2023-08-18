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
using System.Threading;
namespace Project_cuoi_ki
{
    public partial class Login : Form
    {
        ControlNhanVien ctrlNV = new ControlNhanVien();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            NHANVIEN nv = ctrlNV.kiemTraDangNhap(txtbTenDangNhap.Text, txtbMatKhauMoi.Text);
            if (nv != null)
            {
                if (nv.MALNV == "QL                            ")
                {
                    Const.loaiTaiKhoan = "Quan Ly";
                }
                else
                {
                    Const.loaiTaiKhoan = "Nhan Vien";
                }
                Const.maNV = nv.MANV;
                Home fQuanLy = new Home();
                fQuanLy.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nhan vien khong ton tai", "Thong Bao",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Thread thread = new Thread(openNewFormLogin);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void openNewFormLogin()
        {
            Application.Run(new ResetPassword());
        }

        private void txtbMatKhauMoi_TextChanged(object sender, EventArgs e)
        {
            txtbMatKhauMoi.UseSystemPasswordChar = true;
            checkBox1.Checked = false;
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtbMatKhauMoi.UseSystemPasswordChar = false;
            }
            else
            {
                txtbMatKhauMoi.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(openNewFormCreateAccount);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void openNewFormCreateAccount()
        {
            Application.Run(new CreateAccount());
        }
    }
}
