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
    public partial class QuanLyDoanhThu : Form
    {
        ControlHoaDon ctrHD = new ControlHoaDon();
        List<HOADON> dshd = new List<HOADON>();
        public QuanLyDoanhThu()
        {
            InitializeComponent();
            loadHoaDon();
        }

        void loadHoaDon()
        {
            dshd = ctrHD.findAll();
            var rs = from t in dshd select new { t.MAHD, t.NGAYDEN, t.THANHTIEN, t.MANV };
            dtDoanhThu.DataSource = rs.ToList();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            int index = dtDoanhThu.Rows.Count;
            for (int i = 0; i < index - 1; i++)
            {
                if (DateTime.Parse(dtDoanhThu.Rows[i].Cells[1].Value.ToString()) <= dtNgayCuoi.Value && DateTime.Parse(dtDoanhThu.Rows[i].Cells[1].Value.ToString()) >= dtNgayDau.Value)
                {
                    textBox1.Text = "1/1/2000";
                    DateTime btn1 = DateTime.Parse(textBox1.Text);
                    if (btn1 == DateTime.Parse("1/1/2000"))
                    {
                        var lst1 = ctrHD.finddate(btn1);
                        var rst1 = from t in lst1 select new { t.MAHD, t.NGAYDEN, t.THANHTIEN };
                        dtDoanhThu.DataSource = rst1.ToList();
                        dtDoanhThu.Refresh();
                        loadHoaDon();
                    }
                }
                else
                {
                    textBox1.Text = "0";
                }
            }
        }

        private void QuanLyDoanhThu_Load(object sender, EventArgs e)
        {
            dtDoanhThu.Columns[0].HeaderText = "Mã hóa đơn";
            dtDoanhThu.Columns[0].Width = 200;
            dtDoanhThu.Columns[1].HeaderText = "Ngày xuất hóa đơn";
            dtDoanhThu.Columns[1].Width = 200;
            dtDoanhThu.Columns[2].HeaderText = "Thành tiền";
            dtDoanhThu.Columns[2].Width = 200;
            dtDoanhThu.Columns[3].HeaderText = "Nhân viên phụ trách";
            dtDoanhThu.Columns[3].Width = 200;
        }

        private void dtDoanhThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
