using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class DTO_Vy_NhanVien
    {
        private static string _maNhanVien;

        public string MaNhanVien
        {
            get { return _maNhanVien; }
            set { _maNhanVien = value; }
        }

        private static string _tenNhanVien;

        public string TenNhanVien
        {
            get { return _tenNhanVien; }
            set { _tenNhanVien = value; }
        }

        private static string _diaChi;

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }

        private static string _sdt;

        public string SDT
        {
            get { return _sdt; }
            set { _sdt = value; }
        }

        private static string _eMail;

        public string EMail
        {
            get { return _eMail; }
            set { _eMail = value; }
        }

        public DTO_Vy_NhanVien(string manhanvien, string tennhanvien, string diachi, string sdt, string email)
        {
            MaNhanVien = manhanvien;
            TenNhanVien = tennhanvien;
            DiaChi = diachi;
            SDT = sdt;
            EMail = email;
        }
    }
}
