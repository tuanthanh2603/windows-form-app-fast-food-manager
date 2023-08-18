using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_cuoi_ki.PControl
{
    internal class ControlChiTietHD
    {
        QuanlybanthucannhanhEntities db = CUtilDB.qlta;

        public List<chitiethoadon> findAll()
        {
            var cthd = from t in db.chitiethoadons select t;
            return cthd.ToList();
        }
        public chitiethoadon find(int s)
        {
            return db.chitiethoadons.Find(s);
        }
        public chitiethoadon findban(string s)
        {
            return db.chitiethoadons.Find(s);
        }



        public void delete(chitiethoadon s)
        {
            db.chitiethoadons.Remove(s);
            db.SaveChanges();
        }

        public void add(chitiethoadon s)
        {
            db.chitiethoadons.Add(s);
            db.SaveChanges();
        }

        public void update(chitiethoadon s)
        {
            db.chitiethoadons.AddOrUpdate(s);
            db.SaveChanges();
        }
        public List<chitiethoadon> findCTHD(string a)
        {
            return db.chitiethoadons.Where(t => t.MABN == a).ToList();
        }
        public List<chitiethoadon> loadTen(string a)
        {
            return db.chitiethoadons.Where(t => t.MAMA == a).ToList();

        }
        public List<chitiethoadon> loc(string a)
        {
            a = "Ban 1";
            return db.chitiethoadons.Where(t => t.MABN == a).ToList();

        }


    }
}
