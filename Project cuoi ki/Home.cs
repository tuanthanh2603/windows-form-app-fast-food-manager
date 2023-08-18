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
    public partial class Home : Form
    {
        ControlHoaDon ctrHD = new ControlHoaDon();
        List<HOADON> dshd = new List<HOADON>();
        ControlBan ctrBan = new ControlBan();
        List<BAN> dsban = new List<BAN>();
        ControlChiTietHD ctrCTHD = new ControlChiTietHD();
        List<chitiethoadon> dsCTHD = new List<chitiethoadon>();
        ControlLoaiMonAn ctrLoaiMA = new ControlLoaiMonAn();
        ControlMonAn ctrMA = new ControlMonAn();
        List<MONAN> dsMONAN = new List<MONAN>();
        List<MONAN> dsma = new List<MONAN>();
        public Home()
        {
            InitializeComponent();
            loadChiTietHD();
            loadCMBMAMA();
            loadCMBBan();
            DoiMauBan();
            loadDSMA();
            lbTime.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }
        public void phanQuyenNguoiDung()
        {
            if (Const.loaiTaiKhoan == "Quan Ly")
            {
                btnNhanVien.Enabled = true;
            }
            else if (Const.loaiTaiKhoan == "Nhan Vien")
            {
                btnNhanVien.Enabled = false;
            }
        }
        void loadCMBMAMA()
        {
            List<MONAN> dslma = ctrMA.findAll();
            cbbMaMA.DataSource = dslma.ToList();
        }
        void loadChiTietHD()
        {
            dsCTHD = ctrCTHD.findAll();
            var rs = from t in dsCTHD select new { t.MABN, t.MONAN.TENMA, t.SOLUONG, t.MONAN.GIABAN, t.MAHD, t.MAMA, t.MACTHD };
            dtCTHD.DataSource = rs.ToList();
            dtCTHD.Refresh();
        }

        void loadDSMA()
        {
            dsMONAN = ctrMA.findAll();
            var rs = from t in dsMONAN select new { t.MAMA, t.TENMA };
            dtma.DataSource = rs.ToList();
            dtma.Refresh();
        }

        void loadCMBBan()
        {
            List<BAN> dslnv = ctrBan.findAll();
            cbbBan.DataSource = dslnv.ToList();
        }

        void DoiMauBan()
        {
            int a = dtCTHD.Rows.Count;
            for (int i = 0; i < a; i++)
            {
                if (dtCTHD.Rows[i].Cells[0].Value.ToString() == "Ban 1")
                {
                    button1.BackColor = Color.Red; button1.ForeColor = Color.White;
                }
                else if (dtCTHD.Rows[i].Cells[0].Value.ToString() == "Ban 2")
                {
                    button2.BackColor = Color.Red; button2.ForeColor = Color.White;
                }
                else if (dtCTHD.Rows[i].Cells[0].Value.ToString() == "Ban 3")
                {
                    button3.BackColor = Color.Red; button3.ForeColor = Color.White;
                }
                else if (dtCTHD.Rows[i].Cells[0].Value.ToString() == "Ban 4")
                {
                    button4.BackColor = Color.Red; button4.ForeColor = Color.White;
                }
                else if (dtCTHD.Rows[i].Cells[0].Value.ToString() == "Ban 5")
                {
                    button5.BackColor = Color.Red; button5.ForeColor = Color.White;
                }
                else if (dtCTHD.Rows[i].Cells[0].Value.ToString() == "Ban 6")
                {
                    button6.BackColor = Color.Red; button6.ForeColor = Color.White;
                }
                else if (dtCTHD.Rows[i].Cells[0].Value.ToString() == "Ban 7")
                {
                    button7.BackColor = Color.Red; button7.ForeColor = Color.White;
                }
                else if (dtCTHD.Rows[i].Cells[0].Value.ToString() == "Ban 8")
                {
                    button8.BackColor = Color.Red; button8.ForeColor = Color.White;
                }
                else if (dtCTHD.Rows[i].Cells[0].Value.ToString() == "Ban 9")
                {
                    button9.BackColor = Color.Red; button9.ForeColor = Color.White;
                }
                else if (dtCTHD.Rows[i].Cells[0].Value.ToString() == "Ban 10")
                {
                    button10.BackColor = Color.Red; button10.ForeColor = Color.White;
                }
                else if (dtCTHD.Rows[i].Cells[0].Value.ToString() == "Ban 11")
                {
                    button11.BackColor = Color.Red; button11.ForeColor = Color.White;
                }
                else if (dtCTHD.Rows[i].Cells[0].Value.ToString() == "Ban 12")
                {
                    button12.BackColor = Color.Red; button12.ForeColor = Color.White;
                }

            }

        }

        public int GetSL()
        {
            int index = dtCTHD.Rows.Count;
            int soluong = 0;
            for (int i = 0; i < index; i++)
                soluong += int.Parse(dtCTHD.Rows[i].Cells[2].Value.ToString());
            return soluong;
        }

        public float KM()
        {
            if (DateTime.Now.DayOfWeek.ToString() == "Tuesday")
            {
                return 0.3f;
            }
            else if (GetSL() > 3)
            {
                return 0.1f;
            }
            else
            {
                return 0;
            }
        }

        void TONG()
        {
            if (cbbBan.Text == "Ban 1")
            {
                string btn1 = button1.Text;
                var lst1 = ctrCTHD.findCTHD(btn1);
                int sd = lst1.Count;
                float thanhtien = 0;
                for (int i = 0; i < sd; i++)
                    thanhtien += (int.Parse(dtCTHD.Rows[i].Cells[3].Value.ToString()) * int.Parse(dtCTHD.Rows[i].Cells[2].Value.ToString()));
                txtbTongTien.Text = (thanhtien - thanhtien * KM()).ToString();
            }
            else if (cbbBan.Text == "Ban 2")
            {
                string btn2 = button2.Text;
                var lst2 = ctrCTHD.findCTHD(btn2);
                int sd = lst2.Count;
                int thanhtien = 0;
                for (int i = 0; i < sd; i++)
                    thanhtien += (int.Parse(dtCTHD.Rows[i].Cells[3].Value.ToString()) * int.Parse(dtCTHD.Rows[i].Cells[2].Value.ToString()));
                txtbTongTien.Text = (thanhtien - thanhtien * KM()).ToString();
            }
            else if (cbbBan.Text == "Ban 3")
            {
                string btn3 = button3.Text;
                var lst3 = ctrCTHD.findCTHD(btn3);
                int sd = lst3.Count;
                int thanhtien = 0;
                for (int i = 0; i < sd; i++)
                    thanhtien += (int.Parse(dtCTHD.Rows[i].Cells[3].Value.ToString()) * int.Parse(dtCTHD.Rows[i].Cells[2].Value.ToString()));
                txtbTongTien.Text = (thanhtien - thanhtien * KM()).ToString();
            }
            else if (cbbBan.Text == "Ban 4")
            {
                string btn4 = button4.Text;
                var lst4 = ctrCTHD.findCTHD(btn4);
                int sd = lst4.Count;
                int thanhtien = 0;
                for (int i = 0; i < sd; i++)
                    thanhtien += (int.Parse(dtCTHD.Rows[i].Cells[3].Value.ToString()) * int.Parse(dtCTHD.Rows[i].Cells[2].Value.ToString()));
                txtbTongTien.Text = (thanhtien - thanhtien * KM()).ToString();
            }
            else if (cbbBan.Text == "Ban 5")
            {
                string btn5 = button5.Text;
                var lst5 = ctrCTHD.findCTHD(btn5);
                int sd = lst5.Count;
                int thanhtien = 0;
                for (int i = 0; i < sd; i++)
                    thanhtien += (int.Parse(dtCTHD.Rows[i].Cells[3].Value.ToString()) * int.Parse(dtCTHD.Rows[i].Cells[2].Value.ToString()));
                txtbTongTien.Text = (thanhtien - thanhtien * KM()).ToString();
            }
            else if (cbbBan.Text == "Ban 6")
            {
                string btn6 = button6.Text;
                var lst6 = ctrCTHD.findCTHD(btn6);
                int sd = lst6.Count;
                int thanhtien = 0;
                for (int i = 0; i < sd; i++)
                    thanhtien += (int.Parse(dtCTHD.Rows[i].Cells[3].Value.ToString()) * int.Parse(dtCTHD.Rows[i].Cells[2].Value.ToString()));
                txtbTongTien.Text = (thanhtien - thanhtien * KM()).ToString();
            }
            else if (cbbBan.Text == "Ban 7")
            {
                string btn7 = button7.Text;
                var lst7 = ctrCTHD.findCTHD(btn7);
                int sd = lst7.Count;
                int thanhtien = 0;
                for (int i = 0; i < sd; i++)
                    thanhtien += (int.Parse(dtCTHD.Rows[i].Cells[3].Value.ToString()) * int.Parse(dtCTHD.Rows[i].Cells[2].Value.ToString()));
                txtbTongTien.Text = (thanhtien - thanhtien * KM()).ToString();
            }
            else if (cbbBan.Text == "Ban 8")
            {
                string btn8 = button8.Text;
                var lst8 = ctrCTHD.findCTHD(btn8);
                int sd = lst8.Count;
                int thanhtien = 0;
                for (int i = 0; i < sd; i++)
                    thanhtien += (int.Parse(dtCTHD.Rows[i].Cells[3].Value.ToString()) * int.Parse(dtCTHD.Rows[i].Cells[2].Value.ToString()));
                txtbTongTien.Text = (thanhtien - thanhtien * KM()).ToString();
            }
            else if (cbbBan.Text == "Ban 9")
            {
                string btn9 = button9.Text;
                var lst9 = ctrCTHD.findCTHD(btn9);
                int sd = lst9.Count;
                int thanhtien = 0;
                for (int i = 0; i < sd; i++)
                    thanhtien += (int.Parse(dtCTHD.Rows[i].Cells[3].Value.ToString()) * int.Parse(dtCTHD.Rows[i].Cells[2].Value.ToString()));
                txtbTongTien.Text = (thanhtien - thanhtien * KM()).ToString();
            }
            else if (cbbBan.Text == "Ban 10")
            {
                string btn10 = button10.Text;
                var lst10 = ctrCTHD.findCTHD(btn10);
                int sd = lst10.Count;
                int thanhtien = 0;
                for (int i = 0; i < sd; i++)
                    thanhtien += (int.Parse(dtCTHD.Rows[i].Cells[3].Value.ToString()) * int.Parse(dtCTHD.Rows[i].Cells[2].Value.ToString()));
                txtbTongTien.Text = (thanhtien - thanhtien * KM()).ToString();
            }
            else if (cbbBan.Text == "Ban 11")
            {
                string btn11 = button11.Text;
                var lst11 = ctrCTHD.findCTHD(btn11);
                int sd = lst11.Count;
                int thanhtien = 0;
                for (int i = 0; i < sd; i++)
                    thanhtien += (int.Parse(dtCTHD.Rows[i].Cells[3].Value.ToString()) * int.Parse(dtCTHD.Rows[i].Cells[2].Value.ToString()));
                txtbTongTien.Text = (thanhtien - thanhtien * KM()).ToString();
            }
            else if (cbbBan.Text == "Ban 12")
            {
                string btn12 = button12.Text;
                var lst12 = ctrCTHD.findCTHD(btn12);
                int sd = lst12.Count;
                int thanhtien = 0;
                for (int i = 0; i < sd; i++)
                    thanhtien += (int.Parse(dtCTHD.Rows[i].Cells[3].Value.ToString()) * int.Parse(dtCTHD.Rows[i].Cells[2].Value.ToString()));
                txtbTongTien.Text = (thanhtien - thanhtien * KM()).ToString();
            }


        }

        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Danhmuc());
            label1.Text = "Danh mục món ăn";
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyNhanVien());
            label1.Text = "Quản lý nhân viên";
        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyKhoHang());
            label1.Text = "Quản lý kho hàng";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
                label1.Text = "Quản lý bán hàng";
            }
           
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyTaiKhoan());
            label1.Text = "Quản lý tài khoản";
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyDoanhThu());
            label1.Text = "Quản lý doanh thu";
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            
            if (cbbBan.Text == "")
            {
                MessageBox.Show("Vui lòng chọn bàn để thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TONG();
                MessageBox.Show("Thanh toán hoàn tất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            MONAN monan = new MONAN();
            txtbTongTien.Text = monan.SOLUONGHANGHOA.ToString();
        }

        ControlMonAn ctrlMA = new ControlMonAn();
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (cbbBan.Text == "")
            {
                MessageBox.Show("Vui lòng chọn bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbbBan.Focus();
            }
            else
            {
                if (cbbTenMA.Text == "" || cbbMaMA.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtma.Focus();
                }
                else
                {
                    // lay chi so dong cua doi tuong dang chon
                    int index = dtma.CurrentCell.RowIndex;
                    // lay doi tuong dang chon roi show len 
                    string strma = dtma.Rows[index].Cells[0].Value + "";
                    MONAN a = ctrMA.find(strma);
            if (a != null)
            {
                textBox1.Text = a.SOLUONGHANGHOA.ToString();
            }
                    if (numUDSoLuongMonAn.Value > int.Parse(textBox1.Text))
                    {
                        MessageBox.Show("Số lượng quá tải!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lbQuaTai.Text = "Số lượng trong kho chỉ còn " + textBox1.Text;
                    }
                    else
                    {
                        a.SOLUONGHANGHOA -= int.Parse (numUDSoLuongMonAn.Value.ToString());
                        chitiethoadon s = new chitiethoadon
                        {
                            MONAN = (MONAN)cbbMaMA.SelectedItem,
                            SOLUONG = int.Parse(numUDSoLuongMonAn.Value + ""),
                            HOADON = (HOADON)cbbMaHD.SelectedItem,
                            BAN = (BAN)cbbBan.SelectedItem,
                            
                        };
                        ctrCTHD.add(s);
                        loadChiTietHD();
                        DoiMauBan();
                        if (dtCTHD.Rows.Count >= 0)
                        {
                            if (dtCTHD.Rows[dtCTHD.Rows.Count - 1].Cells[0].Value.ToString() == "Ban 1")
                            {
                                loadChiTietHD();
                                string btn1 = button1.Text;
                                var lst1 = ctrCTHD.findCTHD(btn1);
                                var rst1 = from t in lst1 select new { t.MABN, t.MONAN.TENMA, t.SOLUONG, t.MONAN.GIABAN, t.MAHD, t.MAMA, t.MACTHD };
                                dtCTHD.DataSource = rst1.ToList();
                                dtCTHD.Refresh();

                            }
                            if (dtCTHD.Rows[dtCTHD.Rows.Count - 1].Cells[0].Value.ToString() == "Ban 2")
                            {
                                loadChiTietHD();
                                string btn1 = button2.Text;
                                var lst1 = ctrCTHD.findCTHD(btn1);
                                var rst1 = from t in lst1 select new { t.MABN, t.MONAN.TENMA, t.SOLUONG, t.MONAN.GIABAN, t.MAHD, t.MAMA, t.MACTHD };
                                dtCTHD.DataSource = rst1.ToList();
                                dtCTHD.Refresh();

                            }
                            if (dtCTHD.Rows[dtCTHD.Rows.Count - 1].Cells[0].Value.ToString() == "Ban 3")
                            {
                                loadChiTietHD();
                                string btn1 = button3.Text;
                                var lst1 = ctrCTHD.findCTHD(btn1);
                                var rst1 = from t in lst1 select new { t.MABN, t.MONAN.TENMA, t.SOLUONG, t.MONAN.GIABAN, t.MAHD, t.MAMA, t.MACTHD };
                                dtCTHD.DataSource = rst1.ToList();
                                dtCTHD.Refresh();

                            }
                            if (dtCTHD.Rows[dtCTHD.Rows.Count - 1].Cells[0].Value.ToString() == "Ban 4")
                            {
                                loadChiTietHD();
                                string btn1 = button4.Text;
                                var lst1 = ctrCTHD.findCTHD(btn1);
                                var rst1 = from t in lst1 select new { t.MABN, t.MONAN.TENMA, t.SOLUONG, t.MONAN.GIABAN, t.MAHD, t.MAMA, t.MACTHD };
                                dtCTHD.DataSource = rst1.ToList();
                                dtCTHD.Refresh();

                            }
                            if (dtCTHD.Rows[dtCTHD.Rows.Count - 1].Cells[0].Value.ToString() == "Ban 5")
                            {
                                loadChiTietHD();
                                string btn1 = button5.Text;
                                var lst1 = ctrCTHD.findCTHD(btn1);
                                var rst1 = from t in lst1 select new { t.MABN, t.MONAN.TENMA, t.SOLUONG, t.MONAN.GIABAN, t.MAHD, t.MAMA, t.MACTHD };
                                dtCTHD.DataSource = rst1.ToList();
                                dtCTHD.Refresh();

                            }
                            if (dtCTHD.Rows[dtCTHD.Rows.Count - 1].Cells[0].Value.ToString() == "Ban 6")
                            {
                                loadChiTietHD();
                                string btn1 = button6.Text;
                                var lst1 = ctrCTHD.findCTHD(btn1);
                                var rst1 = from t in lst1 select new { t.MABN, t.MONAN.TENMA, t.SOLUONG, t.MONAN.GIABAN, t.MAHD, t.MAMA, t.MACTHD };
                                dtCTHD.DataSource = rst1.ToList();
                                dtCTHD.Refresh();

                            }
                            if (dtCTHD.Rows[dtCTHD.Rows.Count - 1].Cells[0].Value.ToString() == "Ban 7")
                            {
                                loadChiTietHD();
                                string btn1 = button7.Text;
                                var lst1 = ctrCTHD.findCTHD(btn1);
                                var rst1 = from t in lst1 select new { t.MABN, t.MONAN.TENMA, t.SOLUONG, t.MONAN.GIABAN, t.MAHD, t.MAMA, t.MACTHD };
                                dtCTHD.DataSource = rst1.ToList();
                                dtCTHD.Refresh();

                            }
                            if (dtCTHD.Rows[dtCTHD.Rows.Count - 1].Cells[0].Value.ToString() == "Ban 8")
                            {
                                loadChiTietHD();
                                string btn1 = button8.Text;
                                var lst1 = ctrCTHD.findCTHD(btn1);
                                var rst1 = from t in lst1 select new { t.MABN, t.MONAN.TENMA, t.SOLUONG, t.MONAN.GIABAN, t.MAHD, t.MAMA, t.MACTHD };
                                dtCTHD.DataSource = rst1.ToList();
                                dtCTHD.Refresh();

                            }
                            if (dtCTHD.Rows[dtCTHD.Rows.Count - 1].Cells[0].Value.ToString() == "Ban 9")
                            {
                                loadChiTietHD();
                                string btn1 = button9.Text;
                                var lst1 = ctrCTHD.findCTHD(btn1);
                                var rst1 = from t in lst1 select new { t.MABN, t.MONAN.TENMA, t.SOLUONG, t.MONAN.GIABAN, t.MAHD, t.MAMA, t.MACTHD };
                                dtCTHD.DataSource = rst1.ToList();
                                dtCTHD.Refresh();

                            }
                            if (dtCTHD.Rows[dtCTHD.Rows.Count - 1].Cells[0].Value.ToString() == "Ban 10")
                            {
                                loadChiTietHD();
                                string btn1 = button10.Text;
                                var lst1 = ctrCTHD.findCTHD(btn1);
                                var rst1 = from t in lst1 select new { t.MABN, t.MONAN.TENMA, t.SOLUONG, t.MONAN.GIABAN, t.MAHD, t.MAMA, t.MACTHD };
                                dtCTHD.DataSource = rst1.ToList();
                                dtCTHD.Refresh();

                            }
                            if (dtCTHD.Rows[dtCTHD.Rows.Count - 1].Cells[0].Value.ToString() == "Ban 11")
                            {
                                loadChiTietHD();
                                string btn1 = button11.Text;
                                var lst1 = ctrCTHD.findCTHD(btn1);
                                var rst1 = from t in lst1 select new { t.MABN, t.MONAN.TENMA, t.SOLUONG, t.MONAN.GIABAN, t.MAHD, t.MAMA, t.MACTHD };
                                dtCTHD.DataSource = rst1.ToList();
                                dtCTHD.Refresh();

                            }
                            if (dtCTHD.Rows[dtCTHD.Rows.Count - 1].Cells[0].Value.ToString() == "Ban 12")
                            {
                                loadChiTietHD();
                                string btn1 = button12.Text;
                                var lst1 = ctrCTHD.findCTHD(btn1);
                                var rst1 = from t in lst1 select new { t.MABN, t.MONAN.TENMA, t.SOLUONG, t.MONAN.GIABAN, t.MAHD, t.MAMA, t.MACTHD };
                                dtCTHD.DataSource = rst1.ToList();
                                dtCTHD.Refresh();

                            }
                        }
                    
                        
                        //cbbMaMA.Text = "";
                        //cbbTenMA.Text = "";
                        //numUDSoLuongMonAn.Value = 0;
                        //cbbMaHD.Text = "";
                        //cbbBan.Text = "";
                        //cbbGiamGia.Text = "";
                        //txtbTongTien.Text = "0";
                        }
                }
            }
        }

        private void dtCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dtCTHD.Rows[e.RowIndex];
            cbbMaMA.Text = Convert.ToString(row.Cells[5].Value);
            cbbBan.Text = Convert.ToString(row.Cells[0].Value);
            cbbTenMA.Text = Convert.ToString(row.Cells[1].Value);
            numUDSoLuongMonAn.Text = Convert.ToString(row.Cells[2].Value);
            cbbMaHD.Text = Convert.ToString(row.Cells[4].Value);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            loadDSMA();
            loadChiTietHD();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string btn1 = button1.Text;
            var lst1 = ctrCTHD.findCTHD(btn1);
            var rst1 = from t in lst1 select new { t.MABN, t.MONAN.TENMA, t.SOLUONG, t.MONAN.GIABAN, t.MAHD, t.MAMA, t.MACTHD };
            dtCTHD.DataSource = rst1.ToList();
            dtCTHD.Refresh();
            cbbBan.Text = "Ban 1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string btn2 = button2.Text;
            var lst2 = ctrCTHD.findCTHD(btn2);
            var rst2 = from t in lst2 select new { t.MABN, t.MONAN.TENMA, t.SOLUONG, t.MONAN.GIABAN, t.MAHD, t.MAMA, t.MACTHD };
            dtCTHD.DataSource = rst2.ToList();
            cbbBan.Text = "Ban 2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string btn3 = button3.Text;
            var lst3 = ctrCTHD.findCTHD(btn3);
            var rst3 = from t in lst3 select new { t.MABN, t.MONAN.TENMA, t.SOLUONG, t.MONAN.GIABAN, t.MAHD, t.MAMA, t.MACTHD };
            dtCTHD.DataSource = rst3.ToList();
            cbbBan.Text = "Ban 3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string btn4 = button4.Text;
            var lst4 = ctrCTHD.findCTHD(btn4);
            var rst4 = from t in lst4 select new { t.MABN, t.MONAN.TENMA, t.SOLUONG, t.MONAN.GIABAN, t.MAHD, t.MAMA, t.MACTHD };
            dtCTHD.DataSource = rst4.ToList();
            cbbBan.Text = "Ban 4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string btn5 = button5.Text;
            var lst5 = ctrCTHD.findCTHD(btn5);
            var rst5 = from t in lst5 select new { t.MABN, t.MONAN.TENMA, t.SOLUONG, t.MONAN.GIABAN, t.MAHD, t.MAMA, t.MACTHD };
            dtCTHD.DataSource = rst5.ToList();
            cbbBan.Text = "Ban 5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string btn6 = button6.Text;
            var lst6 = ctrCTHD.findCTHD(btn6);
            var rst6 = from t in lst6 select new { t.MABN, t.MONAN.TENMA, t.SOLUONG, t.MONAN.GIABAN, t.MAHD, t.MAMA, t.MACTHD };
            dtCTHD.DataSource = rst6.ToList();
            cbbBan.Text = "Ban 6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string btn7 = button7.Text;
            var lst7 = ctrCTHD.findCTHD(btn7);
            var rst7 = from t in lst7 select new { t.MABN, t.MONAN.TENMA, t.SOLUONG, t.MONAN.GIABAN, t.MAHD, t.MAMA, t.MACTHD };
            dtCTHD.DataSource = rst7.ToList();
            cbbBan.Text = "Ban 7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string btn8 = button8.Text;
            var lst8 = ctrCTHD.findCTHD(btn8);
            var rst8 = from t in lst8 select new { t.MABN, t.MONAN.TENMA, t.SOLUONG, t.MONAN.GIABAN, t.MAHD, t.MAMA, t.MACTHD };
            dtCTHD.DataSource = rst8.ToList();
            cbbBan.Text = "Ban 8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string btn9 = button9.Text;
            var lst9 = ctrCTHD.findCTHD(btn9);
            var rst9 = from t in lst9 select new { t.MABN, t.MONAN.TENMA, t.SOLUONG, t.MONAN.GIABAN, t.MAHD, t.MAMA, t.MACTHD };
            dtCTHD.DataSource = rst9.ToList();
            cbbBan.Text = "Ban 9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string btn10 = button10.Text;
            var lst10 = ctrCTHD.findCTHD(btn10);
            var rst10 = from t in lst10 select new { t.MABN, t.MONAN.TENMA, t.SOLUONG, t.MONAN.GIABAN, t.MAHD, t.MAMA, t.MACTHD };
            dtCTHD.DataSource = rst10.ToList();
            cbbBan.Text = "Ban 10";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string btn11 = button11.Text;
            var lst11 = ctrCTHD.findCTHD((btn11));
            var rst11 = from t in lst11 select new { t.MABN, t.MONAN.TENMA, t.SOLUONG, t.MONAN.GIABAN, t.MAHD, t.MAMA, t.MACTHD };
            dtCTHD.DataSource = rst11.ToList();
            cbbBan.Text = "Ban 11";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string btn12 = button12.Text;
            var lst12 = ctrCTHD.findCTHD((btn12));
            var rst12 = from t in lst12 select new { t.MABN, t.MONAN.TENMA, t.SOLUONG, t.MONAN.GIABAN, t.MAHD, t.MAMA, t.MACTHD };
            dtCTHD.DataSource = rst12.ToList();
            dtCTHD.Refresh();
            cbbBan.Text = "Ban 12";
        }

        private void dtma_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // lay chi so dong cua doi tuong dang chon
            int index = dtma.CurrentCell.RowIndex;
            // lay doi tuong dang chon roi show len 
            string strma = dtma.Rows[index].Cells[0].Value + "";
            MONAN s = ctrMA.find(strma);
            if (s != null)
            {
                cbbMaMA.Text = s.MAMA;
                cbbTenMA.Text = s.TENMA;
                textBox1.Text = s.SOLUONGHANGHOA.ToString();
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            dtma.Columns[1].Width = 175;
            dtCTHD.Columns[2].Width = 60;
            dtCTHD.Columns[0].HeaderText = "Bàn";
            dtCTHD.Columns[0].Width = 80;
            dtCTHD.Columns[1].HeaderText = "Tên món ăn";
            dtCTHD.Columns[2].HeaderText = "Số lượng";
            dtCTHD.Columns[2].Width = 80;
            dtCTHD.Columns[3].HeaderText = "Giá bán";
            dtCTHD.Columns[3].Width = 100;
            dtma.Columns[0].Width = 106;
            dtma.Columns[0].HeaderText = "Mã món ăn";
            dtma.Columns[1].Width = 200;
            dtma.Columns[1].HeaderText = "Tên món ăn";
            phanQuyenNguoiDung();
            cbbMaMA.Text = "";
            cbbTenMA.Text = "";
            numUDSoLuongMonAn.Value = 0;
            cbbMaHD.Text = "";
            cbbBan.Text = "";
            cbbGiamGia.Text = "";
            txtbTongTien.Text = "0";
            cbbBan.Focus();
        }

        public static string ConvertTimeTo24(string hour)
        {
            string h = "";
            switch (hour)
            {
                case "1":
                    h = "13";
                    break;
                case "2":
                    h = "14";
                    break;
                case "3":
                    h = "15";
                    break;
                case "4":
                    h = "16";
                    break;
                case "5":
                    h = "17";
                    break;
                case "6":
                    h = "18";
                    break;
                case "7":
                    h = "19";
                    break;
                case "8":
                    h = "20";
                    break;
                case "9":
                    h = "21";
                    break;
                case "10":
                    h = "22";
                    break;
                case "11":
                    h = "23";
                    break;
                case "12":
                    h = "0";
                    break;
            }
            return h;
        }

        public static string CreateKey(string tiento)
        {
            string key = tiento;
            string[] partsDay;
            partsDay = DateTime.Now.ToShortDateString().Split('/');
            //Ví dụ 07/08/2009
            string d = String.Format("{0}{1}{2}", partsDay[0], partsDay[1], partsDay[2]);
            key = key + d;
            string[] partsTime;
            partsTime = DateTime.Now.ToLongTimeString().Split(':');
            //Ví dụ 7:08:03 PM hoặc 7:08:03 AM
            if (partsTime[2].Substring(3, 2) == "PM")
                partsTime[0] = ConvertTimeTo24(partsTime[0]);
            if (partsTime[2].Substring(3, 2) == "AM")
                if (partsTime[0].Length == 1)
                    partsTime[0] = "0" + partsTime[0];
            //Xóa ký tự trắng và PM hoặc AM
            partsTime[2] = partsTime[2].Remove(2, 3);
            string t;
            t = String.Format("_{0}{1}{2}", partsTime[0], partsTime[1], partsTime[2]);
            key = key + t;
            return key;
        }

        private void btnApDung_Click(object sender, EventArgs e)
        {

            if (DateTime.Now.DayOfWeek.ToString() == "Tuesday")
            {
                cbbMaHD.Text = CreateKey("HD");
                cbbGiamGia.Text = "30";
            }
            else
            {
                cbbMaHD.Text = CreateKey("HD");
                cbbGiamGia.Text = "0";
            }
        }

        private void btnXuatHD_Click(object sender, EventArgs e)
        {

            if (cbbBan.Text == "")
            {
                MessageBox.Show("Vui lòng chọn bàn để thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbbBan.Focus();
            }
            else if (dtCTHD.Rows.Count == 0)
            {
                MessageBox.Show("Bàn này không có món!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbbBan.Focus();
            }
            else
            {
                if (cbbGiamGia.Text == "")
                {
                    MessageBox.Show("Bạn chưa tạo mới hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtbTongTien.Text == "0")
                {
                    MessageBox.Show("Bàn này chưa được thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if (dtCTHD.Rows[0].Cells[0].Value.ToString() == "Ban 1")
                    {
                        string btn1 = button1.Text;
                        var lst1 = ctrCTHD.findCTHD(btn1);
                        if (lst1.Count != 0)
                        {
                            int index = lst1.Count;
                            for (int i = 0; i < index; i++)
                            {
                                string macthd = dtCTHD.Rows[i].Cells[6].Value + "";
                                chitiethoadon a1 = ctrCTHD.find(int.Parse(macthd));
                                ctrCTHD.delete(a1);
                            }
                            loadChiTietHD();
                        }
                    }
                    else if (dtCTHD.Rows[0].Cells[0].Value.ToString() == "Ban 2")
                    {
                        var lst02 = ctrCTHD.findCTHD(button2.Text);
                        if (lst02.Count != 0)
                        {
                            int index = lst02.Count;
                            for (int i = 0; i < index; i++)
                            {
                                string macthd = dtCTHD.Rows[i].Cells[6].Value + "";
                                chitiethoadon a2 = ctrCTHD.find(int.Parse(macthd));
                                ctrCTHD.delete(a2);
                            }
                            loadChiTietHD();
                        }
                    }
                    else if (dtCTHD.Rows[0].Cells[0].Value.ToString() == "Ban 3")
                    {
                        var lst03 = ctrCTHD.findCTHD(button3.Text);
                        if (lst03.Count != 0)
                        {
                            int index = lst03.Count;
                            for (int i = 0; i < index; i++)
                            {
                                string macthd = dtCTHD.Rows[i].Cells[6].Value + "";
                                chitiethoadon a3 = ctrCTHD.find(int.Parse(macthd));
                                ctrCTHD.delete(a3);
                            }
                            loadChiTietHD();
                        }
                    }
                    else if (dtCTHD.Rows[0].Cells[0].Value.ToString() == "Ban 4")
                    {
                        var lst04 = ctrCTHD.findCTHD(button4.Text);
                        if (lst04.Count != 0)
                        {
                            int index = lst04.Count;
                            for (int i = 0; i < index; i++)
                            {
                                string macthd = dtCTHD.Rows[i].Cells[6].Value + "";
                                chitiethoadon a4 = ctrCTHD.find(int.Parse(macthd));
                                ctrCTHD.delete(a4);
                            }
                            loadChiTietHD();
                        }
                    }
                    else if (dtCTHD.Rows[0].Cells[0].Value.ToString() == "Ban 5")
                    {
                        var lst05 = ctrCTHD.findCTHD(button5.Text);
                        if (lst05.Count != 0)
                        {
                            int index = lst05.Count;
                            for (int i = 0; i < index; i++)
                            {
                                string macthd = dtCTHD.Rows[i].Cells[6].Value + "";
                                chitiethoadon a5 = ctrCTHD.find(int.Parse(macthd));
                                ctrCTHD.delete(a5);
                            }
                            loadChiTietHD();
                        }
                    }
                    else if (dtCTHD.Rows[0].Cells[0].Value.ToString() == "Ban 6")
                    {
                        var lst06 = ctrCTHD.findCTHD(button6.Text);
                        if (lst06.Count != 0)
                        {
                            int index = lst06.Count;
                            for (int i = 0; i < index; i++)
                            {
                                string macthd = dtCTHD.Rows[i].Cells[6].Value + "";
                                chitiethoadon a6 = ctrCTHD.find(int.Parse(macthd));
                                ctrCTHD.delete(a6);
                            }
                            loadChiTietHD();
                        }
                    }
                    else if (dtCTHD.Rows[0].Cells[0].Value.ToString() == "Ban 7")
                    {
                        var lst07 = ctrCTHD.findCTHD(button7.Text);
                        if (lst07.Count != 0)
                        {
                            int index = lst07.Count;
                            for (int i = 0; i < index; i++)
                            {
                                string macthd = dtCTHD.Rows[i].Cells[6].Value + "";
                                chitiethoadon a7 = ctrCTHD.find(int.Parse(macthd));
                                ctrCTHD.delete(a7);
                            }
                            loadChiTietHD();
                        }
                    }
                    else if (dtCTHD.Rows[0].Cells[0].Value.ToString() == "Ban 8")
                    {
                        var lst08 = ctrCTHD.findCTHD(button8.Text);
                        if (lst08.Count != 0)
                        {
                            int index = lst08.Count;
                            for (int i = 0; i < index; i++)
                            {
                                string macthd = dtCTHD.Rows[i].Cells[6].Value + "";
                                chitiethoadon a8 = ctrCTHD.find(int.Parse(macthd));
                                ctrCTHD.delete(a8);
                            }
                            loadChiTietHD();
                        }
                    }
                    else if (dtCTHD.Rows[0].Cells[0].Value.ToString() == "Ban 9")
                    {
                        var lst09 = ctrCTHD.findCTHD(button9.Text);
                        if (lst09.Count != 0)
                        {
                            int index = lst09.Count;
                            for (int i = 0; i < index; i++)
                            {
                                string macthd = dtCTHD.Rows[i].Cells[6].Value + "";
                                chitiethoadon a9 = ctrCTHD.find(int.Parse(macthd));
                                ctrCTHD.delete(a9);
                            }
                            loadChiTietHD();
                        }
                    }
                    else if (dtCTHD.Rows[0].Cells[0].Value.ToString() == "Ban 10")
                    {
                        var lst010 = ctrCTHD.findCTHD(button10.Text);
                        if (lst010.Count != 0)
                        {
                            int index = lst010.Count;
                            for (int i = 0; i < index; i++)
                            {
                                string macthd = dtCTHD.Rows[i].Cells[6].Value + "";
                                chitiethoadon a10 = ctrCTHD.find(int.Parse(macthd));
                                ctrCTHD.delete(a10);
                            }
                            loadChiTietHD();
                        }
                    }
                    else if (dtCTHD.Rows[0].Cells[0].Value.ToString() == "Ban 11")
                    {
                        var lst011 = ctrCTHD.findCTHD(button11.Text);
                        if (lst011.Count != 0)
                        {
                            int index = lst011.Count;
                            for (int i = 0; i < index; i++)
                            {
                                string macthd = dtCTHD.Rows[i].Cells[6].Value + "";
                                chitiethoadon a11 = ctrCTHD.find(int.Parse(macthd));
                                ctrCTHD.delete(a11);
                            }
                            loadChiTietHD();
                        }
                    }
                    else if (dtCTHD.Rows[0].Cells[0].Value.ToString() == "Ban 12")
                    {
                        var lst012 = ctrCTHD.findCTHD(button12.Text);
                        if (lst012.Count != 0)
                        {
                            int index = lst012.Count;
                            for (int i = 0; i < index; i++)
                            {
                                string macthd = dtCTHD.Rows[i].Cells[6].Value + "";
                                chitiethoadon a12 = ctrCTHD.find(int.Parse(macthd));
                                ctrCTHD.delete(a12);
                            }
                            loadChiTietHD();
                        }
                    }



                    string btnn1 = button1.Text;
                    var tt = ctrCTHD.findCTHD(btnn1);
                    if (tt.Count == 0)
                    {
                        button1.BackColor = Color.White;
                        button1.ForeColor = Color.Black;
                    }
                    string btn2 = button2.Text;
                    var lst2 = ctrCTHD.findCTHD(btn2);
                    if (lst2.Count == 0)
                    {
                        button2.BackColor = Color.White;
                        button2.ForeColor = Color.Black;
                    }
                    string btn3 = button3.Text;
                    var lst3 = ctrCTHD.findCTHD(btn3);
                    if (lst3.Count == 0)
                    {
                        button3.BackColor = Color.White;
                        button3.ForeColor = Color.Black;
                    }
                    string btn4 = button4.Text;
                    var lst4 = ctrCTHD.findCTHD(btn4);
                    if (lst4.Count == 0)
                    {
                        button4.BackColor = Color.White;
                        button4.ForeColor = Color.Black;
                    }
                    string btn5 = button5.Text;
                    var lst5 = ctrCTHD.findCTHD(btn5);
                    if (lst5.Count == 0)
                    {
                        button5.BackColor = Color.White;
                        button5.ForeColor = Color.Black;
                    }
                    string btn6 = button6.Text;
                    var lst6 = ctrCTHD.findCTHD(btn6);
                    if (lst6.Count == 0)
                    {
                        button6.BackColor = Color.White;
                        button6.ForeColor = Color.Black;
                    }
                    string btn7 = button7.Text;
                    var lst7 = ctrCTHD.findCTHD(btn7);
                    if (lst7.Count == 0)
                    {
                        button7.BackColor = Color.White;
                        button7.ForeColor = Color.Black;
                    }
                    string btn8 = button8.Text;
                    var lst8 = ctrCTHD.findCTHD(btn8);
                    if (lst8.Count == 0)
                    {
                        button8.BackColor = Color.White;
                        button8.ForeColor = Color.Black;
                    }
                    string btn9 = button9.Text;
                    var lst9 = ctrCTHD.findCTHD(btn9);
                    if (lst9.Count == 0)
                    {
                        button9.BackColor = Color.White;
                        button9.ForeColor = Color.Black;
                    }
                    string btn10 = button10.Text;
                    var lst10 = ctrCTHD.findCTHD(btn10);
                    if (lst10.Count == 0)
                    {
                        button10.BackColor = Color.White;
                        button10.ForeColor = Color.Black;
                    }
                    string btn11 = button11.Text;
                    var lst11 = ctrCTHD.findCTHD(btn11);
                    if (lst11.Count == 0)
                    {
                        button11.BackColor = Color.White;
                        button11.ForeColor = Color.Black;
                    }
                    string btn12 = button12.Text;
                    var lst12 = ctrCTHD.findCTHD(btn12);
                    if (lst12.Count == 0)
                    {
                        button12.BackColor = Color.White;
                        button12.ForeColor = Color.Black;
                    }
                    HOADON s = new HOADON
                    {
                        MAHD = cbbMaHD.Text,
                        THANHTIEN = int.Parse(txtbTongTien.Text),
                        KHUYENMAI = (KHUYENMAI)cbbGiamGia.SelectedItem,
                        BAN = (BAN)cbbBan.SelectedItem,
                        TRANGTHAI = "Đã thanh toán",
                        MANV = Const.maNV,
                        NGAYDEN = DateTime.Parse(lbTime.Text),
                    };
                    ctrHD.add(s);
                    MessageBox.Show("Thêm hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbbMaMA.Text = "";
                    cbbTenMA.Text = "";
                    numUDSoLuongMonAn.Value = 0;
                    cbbMaHD.Text = "";
                    cbbBan.Text = "";
                    cbbGiamGia.Text = "";
                    txtbTongTien.Text = "0";
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // xac dinh doi tuong can xoa
            int index = dtCTHD.CurrentCell.RowIndex;
            string macthd = dtCTHD.Rows[index].Cells[6].Value + "";
            chitiethoadon s = ctrCTHD.find(int.Parse(macthd));
            if (s != null)
            {
                DialogResult h = MessageBox.Show("Bạn có muốn xóa món ăn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (h == DialogResult.Yes)
                {
                    ctrCTHD.delete(s);
                    loadChiTietHD();
                    string btn1 = button1.Text;
                    var lst1 = ctrCTHD.findCTHD(btn1);
                    if (lst1.Count == 0)
                    {
                        button1.BackColor = Color.White;
                        button1.ForeColor = Color.Black;
                    }
                    string btn2 = button2.Text;
                    var lst2 = ctrCTHD.findCTHD(btn2);
                    if (lst2.Count == 0)
                    {
                        button2.BackColor = Color.White;
                        button2.ForeColor = Color.Black;
                    }
                    string btn3 = button3.Text;
                    var lst3 = ctrCTHD.findCTHD(btn3);
                    if (lst3.Count == 0)
                    {
                        button3.BackColor = Color.White;
                        button3.ForeColor = Color.Black;
                    }
                    string btn4 = button4.Text;
                    var lst4 = ctrCTHD.findCTHD(btn4);
                    if (lst4.Count == 0)
                    {
                        button4.BackColor = Color.White;
                        button4.ForeColor = Color.Black;
                    }
                    string btn5 = button5.Text;
                    var lst5 = ctrCTHD.findCTHD(btn5);
                    if (lst5.Count == 0)
                    {
                        button5.BackColor = Color.White;
                        button5.ForeColor = Color.Black;
                    }
                    string btn6 = button6.Text;
                    var lst6 = ctrCTHD.findCTHD(btn6);
                    if (lst6.Count == 0)
                    {
                        button6.BackColor = Color.White;
                        button6.ForeColor = Color.Black;
                    }
                    string btn7 = button7.Text;
                    var lst7 = ctrCTHD.findCTHD(btn7);
                    if (lst7.Count == 0)
                    {
                        button7.BackColor = Color.White;
                        button7.ForeColor = Color.Black;
                    }
                    string btn8 = button8.Text;
                    var lst8 = ctrCTHD.findCTHD(btn8);
                    if (lst8.Count == 0)
                    {
                        button8.BackColor = Color.White;
                        button8.ForeColor = Color.Black;
                    }
                    string btn9 = button9.Text;
                    var lst9 = ctrCTHD.findCTHD(btn9);
                    if (lst9.Count == 0)
                    {
                        button9.BackColor = Color.White;
                        button9.ForeColor = Color.Black;
                    }
                    string btn10 = button10.Text;
                    var lst10 = ctrCTHD.findCTHD(btn10);
                    if (lst10.Count == 0)
                    {
                        button10.BackColor = Color.White;
                        button10.ForeColor = Color.Black;
                    }
                    string btn11 = button11.Text;
                    var lst11 = ctrCTHD.findCTHD(btn11);
                    if (lst11.Count == 0)
                    {
                        button11.BackColor = Color.White;
                        button11.ForeColor = Color.Black;
                    }
                    string btn12 = button12.Text;
                    var lst12 = ctrCTHD.findCTHD(btn12);
                    if (lst12.Count == 0)
                    {
                        button12.BackColor = Color.White;
                        button12.ForeColor = Color.Black;
                    }
                    cbbMaMA.Text = "";
                    cbbTenMA.Text = "";
                    numUDSoLuongMonAn.Value = 0;
                    cbbMaHD.Text = "";
                    cbbBan.Text = "";
                    cbbGiamGia.Text = "";
                    txtbTongTien.Text = "0";
                }

            }
        }

        private void dtma_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void button14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void numUDSoLuongMonAn_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
