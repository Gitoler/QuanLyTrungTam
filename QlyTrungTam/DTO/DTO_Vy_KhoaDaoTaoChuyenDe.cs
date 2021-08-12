using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class DTO_Vy_KhoaDaoTaoChuyenDe
    {
        private static int _maKhoaHoc;

        public int MaKhoaHoc
        {
            get { return _maKhoaHoc; }
            set { _maKhoaHoc = value; }
        }


        public DTO_Vy_KhoaDaoTaoChuyenDe(int maKhoaHoc)
        {
            MaKhoaHoc = maKhoaHoc;
        }
    }
}
