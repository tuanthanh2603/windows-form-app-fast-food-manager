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

    public partial class Danhmuc : Form
    {
        ControlMonAn ctrMA = new ControlMonAn();
        ControlLoaiMonAn ctrLoaiMA = new ControlLoaiMonAn();
        List<MONAN> dsma = new List<MONAN>();
        public Danhmuc()
        {
            InitializeComponent();
            loadDSMonAn();
            loadCMBLoaiMA();
        }

        void loadDSMonAn()
        {
            dsma = ctrMA.findAll();
            // chon cac thuoc tinh can hien thi len datagridview
            var rs = from t in dsma select new { t.MAMA, t.TENMA, t.GIABAN };
            dtMonAn.DataSource = rs.ToList();
        }
        void loadCMBLoaiMA()
        {
            List<LOAIMONAN> dslma = ctrLoaiMA.findAll();
            cbbMaLoaiMA.DataSource = dslma.ToList();
            cbbMaLoaiMA.DataSource = dslma.ToList();
        }

        void timKiemMonAn()
        {
            var lst = ctrMA.findMA(txtbTimMA.Text);
            var rst = from s in lst select new { s.MAMA, s.TENMA, s.GIABAN };
            dtMonAn.DataSource = rst.ToList();
            dtMonAn.Refresh();
        }

        private void btnThemMA_Click(object sender, EventArgs e)
        {
            if (cbbMaLoaiMA.Text == "")
            {
                MessageBox.Show("Vui lòng chọn loại món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtbMaMA.Text == "")
                {
                    MessageBox.Show("Vui lòng điền mã món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtbTenMA.Text == "")
                    {
                        MessageBox.Show("Vui lòng điền tên món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (txtbGiaBan.Text == "0")
                        {
                            MessageBox.Show("Vui lòng điền giá bán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MONAN ma = new MONAN
                            {
                                MAMA = txtbMaMA.Text,
                                TENMA = txtbTenMA.Text,
                                GIABAN = int.Parse(txtbGiaBan.Text),
                                LOAIMONAN = (LOAIMONAN)cbbMaLoaiMA.SelectedItem,
                            };
                            // Them doi tuong vao csdl
                            ctrMA.add(ma);
                            // Load lai luoi
                            if (ma != null)
                            {
                                MessageBox.Show("Thêm món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadDSMonAn();
                            }
                        }
                    }
                }
            }
        }

        private void dtMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // lay chi so dong cua doi tuong dang chon
            int index = dtMonAn.CurrentCell.RowIndex;
            // lay doi tuong dang chon roi show len 
            string strma = dtMonAn.Rows[index].Cells[0].Value + "";
            MONAN s = ctrMA.find(strma);
            if (s != null)
            {
                cbbMaLoaiMA.SelectedItem = s.LOAIMONAN;
                txtbGiaBan.Text = s.GIABAN + "";
                txtbMaMA.Text = s.MAMA;
                txtbTenMA.Text = s.TENMA;
            }

        }

        private void btnXemMA_Click(object sender, EventArgs e)
        {
            loadDSMonAn();
        }

        private void btnSuaMA_Click(object sender, EventArgs e)
        {
            //  xac dinh doi tuong can cap nhat
            int id = dtMonAn.CurrentCell.RowIndex;
            string mama = dtMonAn.Rows[id].Cells[0].Value + "";
            MONAN s = ctrMA.find(mama);
            // thay doi cac thong tin 
            s.LOAIMONAN = (LOAIMONAN)cbbMaLoaiMA.SelectedItem;
            s.MAMA = txtbMaMA.Text;
            s.TENMA = txtbTenMA.Text;
            s.GIABAN = int.Parse(txtbGiaBan.Text);
            ctrMA.update(s);
            if (s != null)
            {
                MessageBox.Show("Sửa món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDSMonAn();
                cbbMaLoaiMA.Text = "";
                txtbGiaBan.Text = "";
                txtbMaMA.Text = "";
                txtbTenMA.Text = "";
            }
            
        }

        private void btnXoaMA_Click(object sender, EventArgs e)
        {
            // xac dinh doi tuong can xoa
            int index = dtMonAn.CurrentCell.RowIndex;
            string mama = dtMonAn.Rows[index].Cells[0].Value + "";
            MONAN s = ctrMA.find(mama);
            if (s != null)
            {
                DialogResult h = MessageBox.Show("Bạn có muốn xóa món ăn này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (h == DialogResult.Yes)
                {
                    ctrMA.delete(s);
                    loadDSMonAn();
                    cbbMaLoaiMA.Text = "";
                    txtbGiaBan.Text = "";
                    txtbMaMA.Text = "";
                    txtbTenMA.Text = "";
                }
            }
            
        }

        private void Danhmuc_Load(object sender, EventArgs e)
        {
            dtMonAn.Columns[0].HeaderText = "Mã món ăn";
            dtMonAn.Columns[0].Width = 120;
            dtMonAn.Columns[1].HeaderText = "Tên món ăn";
            dtMonAn.Columns[1].Width = 150;
            dtMonAn.Columns[2].HeaderText = "Giá bán";
            dtMonAn.Columns[2].Width = 80;
        }

        private void btnTimMA_Click(object sender, EventArgs e)
        {
            timKiemMonAn();
        }
    }
}
