using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_cuoi_ki.PControl
{
    internal class ControlMonAn
    {
        QuanlybanthucannhanhEntities db = CUtilDB.qlta;

        public List<MONAN> findAll()
        {
            var rst = from s in db.MONANs select s;
            return rst.ToList();
        }

        public List<MONAN> findTen()
        {
            var rst = from s in db.MONANs select s;
            return rst.ToList();
        }

        public MONAN find(string mama)
        {
            return db.MONANs.Find(mama);
        }
        public List<MONAN> findMA ()
        {
            var rst = from s in db.MONANs select s;
            return rst.ToList();
        }
        public void add(MONAN s)
        {
            db.MONANs.Add(s);
            db.SaveChanges();
        }

        public void delete(MONAN s)
        {
            db.MONANs.Remove(s);
            db.SaveChanges();
        }

        public void update(MONAN s)
        {
            db.MONANs.AddOrUpdate(s);
            db.SaveChanges();
        }

        public List<MONAN> findMA(string dieukien)
        {
            return db.MONANs.Where(t => t.MAMA == dieukien || t.TENMA.Contains(dieukien) || t.LOAIMONAN.TENLMA.Contains(dieukien)).ToList();
        }
        public List<MONAN> findNH(string dieukien)
        {
            return db.MONANs.Where(t => t.MAMA == dieukien || t.TENMA.Contains(dieukien) || t.LOAIMONAN.TENLMA.Contains(dieukien)).ToList();
        }

        public List<MONAN> loadTen(string a)
        {
            return db.MONANs.Where(t => t.TENMA == a).ToList();
        }
    }
}
