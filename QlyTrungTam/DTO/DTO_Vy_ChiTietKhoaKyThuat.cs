using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class DTO_Vy_ChiTietKhoaKyThuat
    {
        private static int _mact;

        public int MaChiTietKhoaHoc
        {
            get { return _mact; }
            set { _mact = value; }
        }

        private static int _maKhoaHoc;

        public int MaKhoaHoc
        {
            get { return _maKhoaHoc; }
            set { _maKhoaHoc = value; }
        }

        private static int _maNhomHP;

        public int MaNhomHocPhan
        {
            get { return _maNhomHP; }
            set { _maNhomHP = value; }
        }

        public DTO_Vy_ChiTietKhoaKyThuat(int maCT, int maKH, int maNhomHP)
        {
            MaChiTietKhoaHoc = maCT;
            MaKhoaHoc = maKH;
            MaNhomHocPhan = maNhomHP;
        }
    }
}
