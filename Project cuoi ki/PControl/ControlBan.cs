using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_cuoi_ki.PControl
{
    internal class ControlBan
    {
        QuanlybanthucannhanhEntities db = CUtilDB.qlta;

        public List<BAN> findAll()
        {
            var hd = from t in db.BANs select t;
            return hd.ToList();
        }
        public BAN find(string s)
        {
            return db.BANs.Find(s);
        }
    }
}
