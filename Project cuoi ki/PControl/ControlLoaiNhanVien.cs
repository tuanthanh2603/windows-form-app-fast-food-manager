using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_cuoi_ki.PControl
{
    internal class ControlLoaiNhanVien
    {
        QuanlybanthucannhanhEntities db = CUtilDB.qlta;

        public List<LOAINHANVIEN> findAll()
        {
            var nv = from t in db.LOAINHANVIENs select t;
            return nv.ToList();
        }
        public LOAINHANVIEN find(string s)
        {
            return db.LOAINHANVIENs.Find(s);
        }

        public void delete(LOAINHANVIEN s)
        {
            db.LOAINHANVIENs.Remove(s);
            db.SaveChanges();
        }

        public void add(LOAINHANVIEN s)
        {
            db.LOAINHANVIENs.Add(s);
            db.SaveChanges();
        }

        public void update(LOAINHANVIEN s)
        {
            db.LOAINHANVIENs.AddOrUpdate(s);
            db.SaveChanges();
        }
    }
}
