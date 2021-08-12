using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class DTO_KhoaChungChi_LichThi
    {
        private static int _malichthi;

        public int MaLichThi
        {
            get { return _malichthi; }
            set { _malichthi = value; }
        }
            
        private static string _ngaythi;

        public string NgayThi
        {
            get { return _ngaythi; }
            set { _ngaythi = value; }
        }

        private static int _mahocphan;

        public int MaHocPhan
        {
            get { return _mahocphan; }
            set { _mahocphan = value; }
        }

        private static int _manhanvien;

        public int MaNhanVien
        {
            get { return _manhanvien; }
            set { _manhanvien = value; }
        }

        private static string _phongthi;

        public string PhongThi
        {
            get { return _phongthi; }
            set { _phongthi = value; }
        }
        public DTO_KhoaChungChi_LichThi(int malichthi, string ngaythi, string phongthi, int mahocphan, int manhanvien)
        {
            MaLichThi = malichthi;
            NgayThi = ngaythi;
            PhongThi = phongthi;
            MaNhanVien = manhanvien;
            MaHocPhan = mahocphan;
        }
    }

    class DTO_KhoaChungChi_HocPhan
    {
        private static int _mahocphan;

        public int MaHocPhan
        {
            get { return _mahocphan; }
            set { _mahocphan = value; }
        }
        public DTO_KhoaChungChi_HocPhan(int mahocphan)
        {
            MaHocPhan = mahocphan;
        }
    }

    class DTO_KhoaChungChi_MonHoc
    {
        private static int _mamon;

        public int MaMon
        {
            get { return _mamon; }
            set { _mamon = value; }
        }

        public DTO_KhoaChungChi_MonHoc(int mamon)
        {
            MaMon = mamon;
        }
    }

    class DTO_KhoaChungChi_NhomChungChi
    {
        private static int _manhomchungchi;

        public int MaNhomChungChi
        {
            get { return _manhomchungchi; }
            set { _manhomchungchi = value; }
        }

        private static string _tennhomchungchi;

        public string TenNhomChungChi
        {
            get { return _tennhomchungchi; }
            set { _tennhomchungchi = value; }
        }

        public DTO_KhoaChungChi_NhomChungChi(int manhomchungchi, string tennhomchungchi)
        {
            MaNhomChungChi = manhomchungchi;
            TenNhomChungChi = tennhomchungchi;
        }
    }
}
