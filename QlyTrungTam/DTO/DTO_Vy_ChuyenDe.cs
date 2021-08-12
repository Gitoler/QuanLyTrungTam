using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class DTO_Vy_ChuyenDe
    {
        private static int _maCD;

        public int MaChuyenDe
        {
            get { return _maCD; }
            set { _maCD = value; }
        }


        private static string _tenCD;

        public string TenChuyenDe
        {
            get { return _tenCD; }
            set { _tenCD = value; }
        }

        private static int _maNhomCD;

        public int MaNhomChuyenDe
        {
            get { return _maNhomCD; }
            set { _maNhomCD = value; }
        }

        public DTO_Vy_ChuyenDe(int maCD, string tenCD, int maNhomCD)
        {
            MaChuyenDe = maCD;
            TenChuyenDe = tenCD;
            MaNhomChuyenDe = maNhomCD;
        }
    }
}
