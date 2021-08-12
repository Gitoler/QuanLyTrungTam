using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class DTO_Vy_GiaoVien
    {
        private static int _maGV;

        public int MaGiaoVien
        {
            get { return _maGV; }
            set { _maGV = value; }
        }

        private static string _tenGV;

        public string TenGiaoVien
        {
            get { return _tenGV; }
            set { _tenGV = value; }
        }

        private static string _dc;

        public string DiaChi
        {
            get { return _dc; }
            set { _dc = value; }
        }

        private static string _sdt;

        public string SDT
        {
            get { return _sdt; }
            set { _sdt = value; }
        }

        private static string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public DTO_Vy_GiaoVien(int maGv, string tenGv, string dc, string sdt, string email)
        {
            MaGiaoVien = maGv;
            TenGiaoVien = tenGv;
            DiaChi = dc;
            SDT = sdt;
            Email = email;
        }
    }
}
