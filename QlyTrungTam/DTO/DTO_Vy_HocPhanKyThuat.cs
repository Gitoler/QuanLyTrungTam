using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class DTO_Vy_HocPhanKyThuat
    {
        private static int _maHP;

        public int MaHocPhan
        {
            get { return _maHP; }
            set { _maHP = value; }
        }

        private static int _nam;

        public int Nam
        {
            get { return _nam; }
            set { _nam = value; }
        }

        private static int _hocKy;

        public int HocKy
        {
            get { return _hocKy; }
            set { _hocKy = value; }
        }

        private static string _lich;

        public string LichHoc
        {
            get { return _lich; }
            set { _lich = value; }
        }

        private static string _phong;

        public string Phong
        {
            get { return _phong; }
            set { _phong = value; }
        }

        private static int _maMon;

        public int MaMonHoc
        {
            get { return _maMon; }
            set { _maMon = value; }
        }

        private static int _maGV;

        public int MaGiaoVien
        {
            get { return _maGV; }
            set { _maGV = value; }
        }

        private static int _maCTKhoa;

        public int MaChiTietKhoa
        {
            get { return _maCTKhoa; }
            set { _maCTKhoa = value; }
        }

        public DTO_Vy_HocPhanKyThuat(int maHP, int nam, int hocky, string lich, string phong, int mamon, int maGV, int maCT)
        {
            MaHocPhan = maHP;
            Nam = nam;
            HocKy = hocky;
            LichHoc = lich;
            Phong = phong;
            MaMonHoc = mamon;
            MaGiaoVien = maGV;
            MaChiTietKhoa = maCT;
        }
    }
}
