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
    public partial class QuanLyKhoHang : Form
    {
        ControlLoaiMonAn ctrLoaiMA = new ControlLoaiMonAn();
        ControlMonAn ctrMA = new ControlMonAn();
        List<MONAN> dsMONAN = new List<MONAN>();
        List<MONAN> dsma = new List<MONAN>();

        public QuanLyKhoHang()
        {
            InitializeComponent();
            loadDSNhapHang();
            loadCMBLoaiMA();
        }

        void timKiemNhapHang()
        {
            var lst = ctrMA.findNH(txtbTimHang.Text);
            var rst = from t in lst select new { t.MAMA, t.TENMA, t.SOLUONGHANGHOA };
            dtNhapHang.DataSource = rst.ToList();
            dtNhapHang.Refresh();
        }

        void loadCMBLoaiMA()
        {
            List<LOAIMONAN> dslma = ctrLoaiMA.findAll();
            cbbNH.DataSource = dslma.ToList();
        }

        void loadDSNhapHang()
        {
            dsma = ctrMA.findAll();
            // chon cac thuoc tinh can hien thi len datagridview
            var rs = from t in dsma select new { t.MAMA, t.TENMA, t.SOLUONGHANGHOA };
            dtNhapHang.DataSource = rs.ToList();
        }

        private void btnSuaNhap_Click_1(object sender, EventArgs e)
        {
            if (cbbNH.Text == "" || txtbNhapTenMA.Text == "" || txtbNhapLoaiMA.Text == "")
            {
                MessageBox.Show("Vui lòng chọn món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (numUDSL.Value == 0)
                {
                    MessageBox.Show("Vui lòng cập nhật số lượng món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //  xac dinh doi tuong can cap nhat
                    int id = dtNhapHang.CurrentCell.RowIndex;
                    string mama = dtNhapHang.Rows[id].Cells[0].Value + "";
                    MONAN s = ctrMA.find(mama);
                    // thay doi cac thong tin 
                    s.SOLUONGHANGHOA = int.Parse(numUDSL.Value + "");
                    ctrMA.update(s);
                    loadDSNhapHang();
                }
            }
            
        }

        private void btnTimHang_Click(object sender, EventArgs e)
        {
            timKiemNhapHang();
        }

        private void btnXemNhap_Click(object sender, EventArgs e)
        {
            loadDSNhapHang();
        }


        private void dtNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // lay chi so dong cua doi tuong dang chon
            int index = dtNhapHang.CurrentCell.RowIndex;
            // lay doi tuong dang chon roi show len 
            string strma = dtNhapHang.Rows[index].Cells[0].Value + "";
            MONAN s = ctrMA.find(strma);
            if (s != null)
            {
                cbbNH.SelectedItem = s.LOAIMONAN;
                txtbNhapLoaiMA.Text = s.MAMA;
                txtbNhapTenMA.Text = s.TENMA;
            }
        }

        private void QuanLyKhoHang_Load(object sender, EventArgs e)
        {
            dtNhapHang.Columns[0].HeaderText = "Mã món ăn";
            dtNhapHang.Columns[0].Width = 110;
            dtNhapHang.Columns[1].HeaderText = "Tên món ăn";
            dtNhapHang.Columns[1].Width = 150;
            dtNhapHang.Columns[2].HeaderText = "Số lượng";
            dtNhapHang.Columns[2].Width = 98;
        }
    }
}
