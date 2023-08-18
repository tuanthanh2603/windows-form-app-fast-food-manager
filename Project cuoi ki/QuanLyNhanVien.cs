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
    public partial class QuanLyNhanVien : Form
    {
        ControlNhanVien ctrNV = new ControlNhanVien();
        ControlLoaiNhanVien ctrLoaiNV = new ControlLoaiNhanVien();
        List<NHANVIEN> dsnv = new List<NHANVIEN>();

        public QuanLyNhanVien()
        {
            InitializeComponent();
            loadDSNV();
            loadCMBLoaiNV();
        }

        void loadDSNV()
        {
            dtNV.Refresh();
            dsnv = ctrNV.findAll();
            // chon cac thuoc tinh can hien thi len datagridview
            var rs = from t in dsnv select new { t.MANV, t.TENNV, t.NGAYSINH, t.GIOITINH, t.SDT, t.LOAINHANVIEN.TENLNV };
            dtNV.DataSource = rs.ToList();
        }

        void loadCMBLoaiNV()
        {
            List<LOAINHANVIEN> dslnv = ctrLoaiNV.findAll();
            cbbLoaiNV.DataSource = dslnv.ToList();
        }

        void timKiemNhanVien()
        {
            var lst = ctrNV.findNV(txtbTimNV.Text);
            var rst = from t in lst select new { t.MANV, t.TENNV, t.NGAYSINH, t.GIOITINH, t.SDT, t.LOAINHANVIEN.TENLNV };
            dtNV.DataSource = rst.ToList();
            dtNV.Refresh();
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            int index = dtNV.CurrentCell.RowIndex;
            string strma = dtNV.Rows[index].Cells[0].Value + "";
            NHANVIEN s = ctrNV.find(strma);
            if (s != null)
            {
                DialogResult h = MessageBox.Show("Bạn có muốn xóa nhân viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (h == DialogResult.Yes)
                {
                    ctrNV.delete(s);
                    loadDSNV();
                }
            }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (txtbMaNV.Text == "")
            {
                MessageBox.Show("Vui lòng điền mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbMaNV.Focus();
            }
            else
            {
                if (txtbTenNV.Text == "")
                {
                    MessageBox.Show("Vui lòng điền tên nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtbTenNV.Focus();
                }
                else
                {
                    if (cbbLoaiNV.Text == "")
                    {
                        MessageBox.Show("Vui lòng chọn loại nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cbbLoaiNV.Focus();
                    }
                    else
                    {
                        if (rdNam.Checked == false && rdNu.Checked == false)
                        {
                            MessageBox.Show("Vui lòng chọn giới tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (txtbSDTNV.Text == "")
                            {
                                MessageBox.Show("Vui lòng điền số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtbSDTNV.Focus();
                            }
                            else
                            {
                                NHANVIEN nv = new NHANVIEN
                                {
                                    MANV = txtbMaNV.Text,
                                    TENNV = txtbTenNV.Text,
                                    GIOITINH = (rdNam.Checked == true ? "Nam" : "Nữ"),
                                    NGAYSINH = dtNgaySinh.Value,
                                    SDT = txtbSDTNV.Text,
                                    LOAINHANVIEN = (LOAINHANVIEN)cbbLoaiNV.SelectedItem
                                };
                                ctrNV.add(nv);
                                loadDSNV();
                            }
                        }
                    } 


                    

                }
            }
            
        }

        private void btnXemNV_Click(object sender, EventArgs e)
        {
            loadDSNV();
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            int index = dtNV.CurrentCell.RowIndex;
            string strma = dtNV.Rows[index].Cells[0].Value + "";
            NHANVIEN s = ctrNV.find(strma);
            s.MANV = txtbMaNV.Text;
            s.TENNV = txtbTenNV.Text;
            s.GIOITINH = (rdNam.Checked == true ? "Nam" : "Nữ");
            s.NGAYSINH = dtNgaySinh.Value;
            s.SDT = txtbSDTNV.Text;
            s.LOAINHANVIEN = (LOAINHANVIEN)cbbLoaiNV.SelectedItem;
            if (s != null)
            {
                MessageBox.Show("Sửa thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ctrNV.update(s);
                loadDSNV();
            }
            
        }

        private void btnTimNV_Click(object sender, EventArgs e)
        {
            timKiemNhanVien();
        }

        private void dtNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtNV.CurrentCell.RowIndex;
            string strma = dtNV.Rows[index].Cells[0].Value + "";
            NHANVIEN s = ctrNV.find(strma);
            if (s != null)
            {
                txtbMaNV.Text = s.MANV;
                txtbTenNV.Text = s.TENNV;
                dtNgaySinh.Value = (DateTime)s.NGAYSINH;
                rdNam.Checked = (s.GIOITINH == "Nam" ? true : false);
                rdNu.Checked = (s.GIOITINH == "Nữ" ? true : false);
                cbbLoaiNV.SelectedItem = s.LOAINHANVIEN;
                txtbSDTNV.Text = s.SDT;
            }
        }

        private void txtbSDTNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            dtNV.Columns[0].HeaderText = "Mã nhân viên";
            dtNV.Columns[0].Width = 140;
            dtNV.Columns[1].HeaderText = "Tên nhân viên";
            dtNV.Columns[1].Width = 180;
            dtNV.Columns[2].HeaderText = "Ngày sinh";
            dtNV.Columns[2].Width = 110;
            dtNV.Columns[3].HeaderText = "Giới tính";
            dtNV.Columns[3].Width = 90;
            dtNV.Columns[4].HeaderText = "Điện thoại";
            dtNV.Columns[4].Width = 120;
            dtNV.Columns[5].HeaderText = "Chức vụ";
            dtNV.Columns[5].Width = 135;
        }
    }
}
