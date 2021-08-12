using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class DTO_Tung_KhoaDaoTaoChuyenDe
    {
        private static int _makhoahoc;

        public int MaKhoaHoc
        {
            get { return _makhoahoc; }
            set { _makhoahoc = value; }
        }
        public DTO_Tung_KhoaDaoTaoChuyenDe(int makhoahoc)
        {
            MaKhoaHoc = makhoahoc;
            
        }
    }
}
