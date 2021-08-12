using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class DTO_Vy_HocPhanChuyenDe
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

        private static int _maCD;

        public int MaChuyenDe
        {
            get { return _maCD; }
            set { _maCD = value; }
        }

        private static int _maGV;

        public int MaGiaoVien
        {
            get { return _maGV; }
            set { _maGV = value; }
        }

        private static int _maKH;

        public int MaKhoaHoc
        {
            get { return _maKH; }
            set { _maKH = value; }
        }

        public DTO_Vy_HocPhanChuyenDe(int maHP, int nam, int hocky, string lich, string phong, int maCD, int maGV, int maKH)
        {
            MaHocPhan = maHP;
            Nam = nam;
            HocKy = hocky;
            LichHoc = lich;
            Phong = phong;
            MaChuyenDe = maCD;
            MaGiaoVien = maGV;
            MaKhoaHoc = maKH;
        }
    }
}
