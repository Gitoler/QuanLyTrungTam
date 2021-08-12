using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class DTO_Vy_KhoaDaoTaoKyThuat
    {
        private static int _maKhoaHoc;

        public int MaKhoaHoc
        {
            get { return _maKhoaHoc; }
            set { _maKhoaHoc = value; }
        }


        private static int _soLuongNhomHP;

        public int SoLuongNhomHP
        {
            get { return _soLuongNhomHP; }
            set { _soLuongNhomHP = value; }
        }

        public DTO_Vy_KhoaDaoTaoKyThuat(int maKhoaHoc, int soLuongNhomHP)
        {
            MaKhoaHoc = maKhoaHoc;
            SoLuongNhomHP = soLuongNhomHP;
        }
    }
}
