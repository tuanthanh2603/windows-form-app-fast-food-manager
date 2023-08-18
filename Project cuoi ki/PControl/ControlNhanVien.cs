using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_cuoi_ki.PControl
{
    internal class ControlNhanVien
    {
        QuanlybanthucannhanhEntities db = CUtilDB.qlta;

        public List<NHANVIEN> findAll()
        {
            var nv = from t in db.NHANVIENs select t;
            return nv.ToList();
        }
        public NHANVIEN find(string s)
        {
            return db.NHANVIENs.Find(s);
        }

        public void delete(NHANVIEN s)
        {
            db.NHANVIENs.Remove(s);
            db.SaveChanges();
        }

        public void add(NHANVIEN s)
        {
            db.NHANVIENs.Add(s);
            db.SaveChanges();
        }

        public void update(NHANVIEN s)
        {
            db.NHANVIENs.AddOrUpdate(s);
            db.SaveChanges();
        }
        public List<NHANVIEN> findNV(string dieukien)
        {
            return db.NHANVIENs.Where(t => t.MANV == dieukien || t.TENNV.Contains(dieukien) || t.LOAINHANVIEN.TENLNV.Contains(dieukien) || t.SDT.Contains(dieukien)).ToList();
        }
        public NHANVIEN kiemTraDangNhap(string userName, string passWord)
        {
            try
            {

                var nv = (from user in db.NHANVIENs
                          where user.MANV == userName
                          where user.SDT == passWord
                          select user).SingleOrDefault();

                return nv;
            }
            catch { throw; }
        }
        public NHANVIEN kiemTraTenDangNhap(string userName)
        {
            try
            {
                var nv = (from user in db.NHANVIENs
                          where user.MANV == userName
                          select user).SingleOrDefault();
                return nv;
            }
            catch { throw; }
        }
        public List<NHANVIEN> quyenNhanVien()
        {
            var lst = from s in db.NHANVIENs
                      where s.MALNV == "002"
                      select s;
            return lst.ToList();
        }
    }
}
