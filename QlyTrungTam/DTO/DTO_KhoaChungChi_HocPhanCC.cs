using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class DTO_KhoaChungChi_HocPhanCC
    {
        private static int _mahocphan;

        public int MaHocPhan
        {
            get { return _mahocphan; }
            set { _mahocphan = value; }
        }

        private static int _khoa;

        public int Khoa
        {
            get { return _khoa; }
            set { _khoa = value; }
        }

        private static int _nhomchungchi;

        public int NhomChungChi
        {
            get { return _nhomchungchi; }
            set { _nhomchungchi = value; }
        }

        private static int _monhoc;

        public int MonHoc
        {
            get { return _monhoc; }
            set { _monhoc = value; }
        }

        private static int _nam;

        public int Nam
        {
            get { return _nam; }
            set { _nam = value; }
        }

        private static int _hocki;

        public int HocKi
        {
            get { return _hocki; }
            set { _hocki = value; }
        }

        private static string _lichhoc;

        public string LichHoc
        {
            get { return _lichhoc; }
            set { _lichhoc = value; }
        }

        private static int _giaovien;

        public int GiaoVien
        {
            get { return _giaovien; }
            set { _giaovien = value; }
        }

        private static string _phonghoc;

        public string PhongHoc
        {
            get { return _phonghoc; }
            set { _phonghoc = value; }
        }

        public DTO_KhoaChungChi_HocPhanCC(int mahocphan, int khoa, int nhomchungchi,
                                        int monhoc, int nam, int hocki, string lichhoc, int giaovien, string phonghoc)
        {
            MaHocPhan = mahocphan;
            Khoa = khoa;
            NhomChungChi = nhomchungchi;
            MonHoc = monhoc;
            Nam = nam;
            HocKi = hocki;
            LichHoc = lichhoc;
            GiaoVien = giaovien;
            PhongHoc = phonghoc;
        }
    }
}
