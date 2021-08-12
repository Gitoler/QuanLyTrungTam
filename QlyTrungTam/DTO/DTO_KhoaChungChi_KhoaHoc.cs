using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class DTO_KhoaChungChi_KhoaHoc
    {
        private static int _makhoahoc;

        public int MaKhoaHoc
        {
            get { return _makhoahoc; }
            set { _makhoahoc = value; }
        }

        private static string _tenkhoahoc;

        public string TenKhoaHoc
        {
            get { return _tenkhoahoc; }
            set { _tenkhoahoc = value; }
        }

        private static string _ngaybatdau;

        public string NgayBatDau
        {
            get { return _ngaybatdau; }
            set { _ngaybatdau = value; }
        }

        private static int _manhanvien;

        public int MaNhanVien
        {
            get { return _manhanvien; }
            set { _manhanvien = value; }
        }

        private static string _mota;

        public string MoTa
        {
            get { return _mota; }
            set { _mota = value; }
        }

        public DTO_KhoaChungChi_KhoaHoc(int makhoahoc, string tenkhoahoc, string ngaybatdau, string mota, int manhanvien)
        {
            MaKhoaHoc = makhoahoc;
            TenKhoaHoc = tenkhoahoc;
            NgayBatDau = ngaybatdau;
            MaNhanVien = manhanvien;
            MoTa = mota;
        }
    }
}
