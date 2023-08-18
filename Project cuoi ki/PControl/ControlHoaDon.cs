using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_cuoi_ki.PControl
{
    internal class ControlHoaDon
    {
        QuanlybanthucannhanhEntities db = CUtilDB.qlta;

        public List<HOADON> findAll()
        {
            var hd = from t in db.HOADONs select t;
            return hd.ToList();
        }
        public HOADON find(string s)
        {
            return db.HOADONs.Find(s);
        }

        public void delete(HOADON s)
        {
            db.HOADONs.Remove(s);
            db.SaveChanges();
        }

        public void add(HOADON s)
        {
            db.HOADONs.Add(s);
            db.SaveChanges();
        }

        public void update(HOADON s)
        {
            db.HOADONs.AddOrUpdate(s);
            db.SaveChanges();
        }

        public List<HOADON> finddate(DateTime a)
        {
            return db.HOADONs.Where(t => t.NGAYDEN == a).ToList();
        }

    }
}
