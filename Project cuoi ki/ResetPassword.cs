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
    public partial class ResetPassword : Form
    {
        ControlNhanVien ctrlNV = new ControlNhanVien();
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void btnForgotPW_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = new NHANVIEN();
            nv = ctrlNV.kiemTraTenDangNhap(txtbUsername.Text);
            if (nv == null)
            {
                MessageBox.Show("Tai khoan khong ton tai", "Thong bao");
            }
            else
            {
                FormRessetPassword formRessetPassword = new FormRessetPassword();
                this.Hide();
                formRessetPassword.ShowDialog();

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
        }
        private void openNewFormLogin()
        {

            Application.Run(new Login());

        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(openNewFormLogin);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
