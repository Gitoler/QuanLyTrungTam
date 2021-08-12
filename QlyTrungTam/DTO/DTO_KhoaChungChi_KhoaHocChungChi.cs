using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class DTO_KhoaChungChi_KhoaHocChungChi
    {
        private static int _makhoahoc;

        public int MaKhoaHoc
        {
            get { return _makhoahoc; }
            set { _makhoahoc = value; }
        }

        private static int _chungchi;

        public int ChungChi
        {
            get { return _chungchi; }
            set { _chungchi = value; }
        }

        private static int _soluonghocphan;

        public int SoLuongHocPhan
        {
            get { return _soluonghocphan; }
            set { _soluonghocphan = value; }
        }
        public DTO_KhoaChungChi_KhoaHocChungChi(int makhoahoc, int chungchi, int soluonghocphan)
        {
            MaKhoaHoc = makhoahoc;
            ChungChi = chungchi;
            SoLuongHocPhan = soluonghocphan;
        }
    }
}
