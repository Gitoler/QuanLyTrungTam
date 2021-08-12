using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class DTO_Vy_MonHoc
    {
        private static int _maMon;

        public int MaMonHoc
        {
            get { return _maMon; }
            set { _maMon = value; }
        }

        private static string _tenMon;

        public string TenMonHoc
        {
            get { return _tenMon; }
            set { _tenMon = value; }
        }

        private static string _loai;

        public string LoaiMonHoc
        {
            get { return _loai; }
            set { _loai = value; }
        }

        private static int _maNhomHP;

        public int MaNhomHocPhan
        {
            get { return _maNhomHP; }
            set { _maNhomHP = value; }
        }

        private static int _maNhomCC;

        public int MaNhomChungChi
        {
            get { return _maNhomCC; }
            set { _maNhomCC = value; }
        }

        public DTO_Vy_MonHoc(int maMon, string tenMon, string loai, int maNhomHP, int maNhomCC)
        {
            MaMonHoc = maMon;
            TenMonHoc = tenMon;
            LoaiMonHoc = loai;
            MaNhomHocPhan = maNhomHP;
            MaNhomChungChi = maNhomCC;
        }
    }
}
