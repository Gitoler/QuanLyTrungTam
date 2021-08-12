using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class DTO_Vy_LichThiHPKT
    {
        private static int _maLichThi;

        public int MaLichThi
        {
            get { return _maLichThi; }
            set { _maLichThi = value; }
        }

        private static string _ngayThi;

        public string NgayThi
        {
            get { return _ngayThi; }
            set { _ngayThi = value; }
        }

        private static int _lanThi;

        public int LanThi
        {
            get { return _lanThi; }
            set { _lanThi = value; }
        }

        private static string _phong;

        public string PhongThi
        {
            get { return _phong; }
            set { _phong = value; }
        }

        private static int _maHPKT;

        public int MaHPKT
        {
            get { return _maHPKT; }
            set { _maHPKT = value; }
        }

        private static int _maNV;

        public int MaNV
        {
            get { return _maNV; }
            set { _maNV = value; }
        }

        public DTO_Vy_LichThiHPKT(int mathi, string ngaythi, int lanthi, string phong, int maHPKT, int maNV)
        {
            MaLichThi = mathi;
            NgayThi = ngaythi;
            LanThi = lanthi;
            PhongThi = phong;
            MaHPKT = maHPKT;
            MaNV = maNV;
        }
    }
}
