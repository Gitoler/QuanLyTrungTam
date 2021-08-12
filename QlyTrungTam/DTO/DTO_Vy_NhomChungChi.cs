using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class DTO_Vy_NhomChungChi
    {
        private static int _maNhomCC;

        public int MaNhomChungChi
        {
            get { return _maNhomCC; }
            set { _maNhomCC = value; }
        }


        private static string _tenNhomCC;

        public string TenNhomChungChi
        {
            get { return _tenNhomCC; }
            set { _tenNhomCC = value; }
        }

        public DTO_Vy_NhomChungChi(int maNhomCC, string tenNhomCC)
        {
            MaNhomChungChi = maNhomCC;
            TenNhomChungChi = tenNhomCC;
        }
    }
}
