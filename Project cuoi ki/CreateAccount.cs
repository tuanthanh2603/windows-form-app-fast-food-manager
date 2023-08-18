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
    public partial class CreateAccount : Form
    {
        ControlNhanVien ctrlNV = new ControlNhanVien();
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<NHANVIEN> lstNV = new List<NHANVIEN>();
            lstNV = ctrlNV.findNV(txtbTenDangNhap.Text);
            if (txtbTenDangNhap.TextLength <= 0 || txtbMatKhauMoi.TextLength <= 0 || txtbHoTen.TextLength <= 0 || rdbtnNV.Checked == false && rdbtnQL.Checked == false)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (lstNV.Count == 0)
                {
                    NHANVIEN s = new NHANVIEN() { MANV = txtbTenDangNhap.Text, TENNV = txtbHoTen.Text, SDT = txtbMatKhauMoi.Text, MALNV = (rdbtnNV.Checked == true ? "PV" : "QL"),
                    NGAYSINH = DateTime.Parse( txtbNgaySinh.Text), GIOITINH = (rdbtnNam.Checked == true ? "Nam" : "Nữ")};
                    ctrlNV.add(s);
                    MessageBox.Show("Tạo tài khoản nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Nhân viên này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void txtbPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtbMatKhauMoi.UseSystemPasswordChar = false;
            }
            else
            {
                txtbMatKhauMoi.UseSystemPasswordChar = true;
            }
        }

        private void txtbMatKhauMoi_TextChanged(object sender, EventArgs e)
        {
            txtbMatKhauMoi.UseSystemPasswordChar = true;
            checkBox1.Checked = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(openNewFormLogin);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void openNewFormLogin()
        {

            Application.Run(new Login());

        }

        private void txtbHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbNgaySinh_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
