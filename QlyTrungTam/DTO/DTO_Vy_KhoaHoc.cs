using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class DTO_Vy_KhoaHoc
    {
        private static int _maKhoaHoc;

        public int MaKhoaHoc
        {
            get { return _maKhoaHoc; }
            set { _maKhoaHoc = value; }
        }

        private static string _tenKhoaHoc;

        public string TenKhoaHoc
        {
            get { return _tenKhoaHoc; }
            set { _tenKhoaHoc = value; }
        }

        private static string _ngayBatDau;

        public string NgayBatDau
        {
            get { return _ngayBatDau; }
            set { _ngayBatDau = value; }
        }

        private static int _maLoai;

        public int MaLoai
        {
            get { return _maLoai; }
            set { _maLoai = value; }
        }

        private static string _moTa;

        public string MoTa
        {
            get { return _moTa; }
            set { _moTa = value; }
        }

        private static int _maNhanVien;

        public int MaNhanVien
        {
            get { return _maNhanVien; }
            set { _maNhanVien = value; }
        }

        public DTO_Vy_KhoaHoc(int maKhoaHoc, string tenKhoaHoc, string ngayBatDau, string moTa, int maLoai, int maNhanVien)
        {
            MaKhoaHoc = maKhoaHoc;
            TenKhoaHoc = tenKhoaHoc;
            NgayBatDau = ngayBatDau;
            MaLoai = maLoai;
            MaNhanVien = maNhanVien;
            MoTa = moTa;
        }
    }
}
