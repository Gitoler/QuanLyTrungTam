using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class DTO_Tung_HocPhanChuyenDe
    {
        private static int _mahocphanchuyende;

        public int MaHPChuyenDe
        {
            get { return _mahocphanchuyende; }
            set { _mahocphanchuyende = value; }
        }
        private static int _namhoc;

        public int NamHoc
        {
            get { return _namhoc; }
            set { _namhoc = value; }
        }
        private static string _hocky;

        public string HocKy
        {
            get { return _hocky; }
            set { _hocky = value; }
        }
        private static string _lichhoc;

        public string LichHoc
        {
            get { return _lichhoc; }
            set { _lichhoc = value; }
        }
        private static string _phong;

        public string Phong
        {
            get { return _phong; }
            set { _phong = value; }
        }

        private static int _machuyende;

        public int MaChuyenDe
        {
            get { return _machuyende; }
            set { _machuyende = value; }
        }
        private static int _magiaovien;

        public int MaGiaoVien
        {
            get { return _magiaovien; }
            set { _magiaovien = value; }
        }

        private static int _makhoahoc;

        public int MaKhoaHoc
        {
            get { return _makhoahoc; }
            set { _makhoahoc = value; }
        }
        public DTO_Tung_HocPhanChuyenDe(int mahocphanchuyende,int namhoc, string hocky, string lichhoc, string phong, int machuyende, int magiaovien ,int makhoahoc)
        {
            MaHPChuyenDe = mahocphanchuyende;
            NamHoc = namhoc;
            HocKy = hocky;
            LichHoc = lichhoc;
            Phong = phong;
            MaChuyenDe = machuyende;
            MaGiaoVien = magiaovien;
            MaKhoaHoc = makhoahoc;

        }

    }
}
