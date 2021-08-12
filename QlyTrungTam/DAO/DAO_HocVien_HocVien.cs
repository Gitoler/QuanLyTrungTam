using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DAO
{
    class DAO_HocVien_HocVien
    {
        private static DAO_HocVien_HocVien instance;

        public static DAO_HocVien_HocVien Instance
        {
            get
            {
                if (instance == null) instance = new DAO_HocVien_HocVien();
                return instance;
            }
            private set { instance = value; }
        }

        public DataTable SelectKhoaHoc(int type)
        {
            string query = " select b.MaKhoaHoc, b.TenKhoaHoc, b.NgayBatDau, b.MoTa " +
                " from HoaDon a, KhoaHoc b " +
                " where a.MaKhoaHoc = b.MaKhoaHoc AND b.MaLoaiKhoaHoc =  " + type.ToString();

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            return result;
        }
        private DAO_HocVien_HocVien() { }
    }
}
