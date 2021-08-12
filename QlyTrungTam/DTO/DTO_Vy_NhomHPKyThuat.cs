using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class DTO_Vy_NhomHPKyThuat
    {

        private static int _maNhom;

        public int MaNhomHocPhan
        {
            get { return _maNhom; }
            set { _maNhom = value; }
        }

        private static string _tenNhom;

        public string TenNhomHocPhan
        {
            get { return _tenNhom; }
            set { _tenNhom = value; }
        }

        private static string _loai;

        public string Loai
        {
            get { return _loai; }
            set { _loai = value; }
        }


        public DTO_Vy_NhomHPKyThuat(int maNhom, string tenNhom, string loai)
        {
            MaNhomHocPhan = maNhom;
            TenNhomHocPhan = tenNhom;
            Loai = loai;
        }
    }
}
