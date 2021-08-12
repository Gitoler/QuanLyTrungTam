using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class DTO_Vy_DiemHocPhanChungChi
    {
        private static int _maDiem;

        public int MaDiem
        {
            get { return _maDiem; }
            set { _maDiem = value; }
        }

        private static int _diem;

        public int Diem
        {
            get { return _diem; }
            set { _diem = value; }
        }

        private static int _maHV;

        public int MaHocVien
        {
            get { return _maHV; }
            set { _maHV = value; }
        }

        private static int _maHP;

        public int MaHocPhan
        {
            get { return _maHP; }
            set { _maHP = value; }
        }

        private static int _maNhomCC;

        public int MaNhomChungChi
        {
            get { return _maNhomCC; }
            set { _maNhomCC = value; }
        }

        public DTO_Vy_DiemHocPhanChungChi(int maDiem, int diem, int maHV, int maHP)
        {
            MaDiem = maDiem;
            Diem = diem;
            MaHocVien = maHV;
            MaHocPhan = maHP;
        }
    }
}
