using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_cuoi_ki.PControl
{
    internal class ControlLoaiMonAn
    {
        QuanlybanthucannhanhEntities db = CUtilDB.qlta;

        public List<LOAIMONAN> findAll()
        {
            var dsLoaiMA = from t in db.LOAIMONANs select t;
            return dsLoaiMA.ToList();
        }
        public LOAIMONAN find(string malma)
        {
            return db.LOAIMONANs.Find(malma);
        }

        public void delete(LOAIMONAN s)
        {
            db.LOAIMONANs.Remove(s);
            db.SaveChanges();
        }

        public void add(LOAIMONAN s)
        {
            db.LOAIMONANs.Add(s);
            db.SaveChanges();
        }

        public void update(LOAIMONAN s)
        {
            db.LOAIMONANs.AddOrUpdate(s);
            db.SaveChanges();
        }

    }
}
