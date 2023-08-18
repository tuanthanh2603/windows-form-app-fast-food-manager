using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_cuoi_ki
{
    internal class CUtilDB
    {
        public static QuanlybanthucannhanhEntities qlta = new QuanlybanthucannhanhEntities();

        static CUtilDB()
        {
            if (qlta == null)
                qlta = new QuanlybanthucannhanhEntities();
        }
    }
}
