using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class DTO_Vy_NhomChuyenDe
    {
        private static int _maNhomCD;

        public int MaNhomChuyenDe
        {
            get { return _maNhomCD; }
            set { _maNhomCD = value; }
        }


        private static string _tenNhomCD;

        public string TenNhomChuyenDe
        {
            get { return _tenNhomCD; }
            set { _tenNhomCD = value; }
        }

        public DTO_Vy_NhomChuyenDe(int maNhomCD, string tenNhomCD)
        {
            MaNhomChuyenDe = maNhomCD;
            TenNhomChuyenDe = tenNhomCD;
        }
    }
}
