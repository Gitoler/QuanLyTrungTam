using QlyTrungTam.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DAO
{
    class DAO_HoaDonNhomKyThuat
    {
        private static DAO_HoaDonNhomKyThuat instance;
        public static DAO_HoaDonNhomKyThuat Instance
        {
            get
            {
                if (instance == null) instance = new DAO_HoaDonNhomKyThuat();
                return DAO_HoaDonNhomKyThuat.instance;
            }
            private set { instance = value; }
        }


        public List<HoaDonNhomKyThuat> GetHoaDonNhomKyThuatList()
        {

            List<HoaDonNhomKyThuat> hoadonnhomkythuatList = new List<HoaDonNhomKyThuat>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetHoaDonNhomKyThuatList");
            foreach (DataRow item in data.Rows)
            {
                HoaDonNhomKyThuat HoaDonNhomKyThuat = new HoaDonNhomKyThuat(item);
                hoadonnhomkythuatList.Add(HoaDonNhomKyThuat);
            }

            return hoadonnhomkythuatList;

        }

        public List<HoaDonNhomKyThuat> GetHoaDonNhomKyThuatListByMaHoaDon(int mahoadon)
        {

            List<HoaDonNhomKyThuat> hoadonnhomkythuatList = new List<HoaDonNhomKyThuat>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetHoaDonNhomKyThuatListByMaHoaDon " + mahoadon);
            foreach (DataRow item in data.Rows)
            {
                HoaDonNhomKyThuat HoaDonNhomKyThuat = new HoaDonNhomKyThuat(item);
                hoadonnhomkythuatList.Add(HoaDonNhomKyThuat);
            }

            return hoadonnhomkythuatList;

        }

        public List<HoaDonNhomKyThuat> GetUnpayHoaDonNhomKyThuatListByMaHoaDon(int mahoadon)
        {

            List<HoaDonNhomKyThuat> hoadonnhomkythuatList = new List<HoaDonNhomKyThuat>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetUnpayHoaDonNhomKyThuatListByMaHoaDon " + mahoadon);
            foreach (DataRow item in data.Rows)
            {
                HoaDonNhomKyThuat HoaDonNhomKyThuat = new HoaDonNhomKyThuat(item);
                hoadonnhomkythuatList.Add(HoaDonNhomKyThuat);
            }

            return hoadonnhomkythuatList;

        }
        public int GetUnpayMaHoaDonChiTietNhomKyThuatByMaHoaDon(int idhoadon, int idchitietkhoakythuat)
        {

            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetMaHoaDonChiTietNhomKyThuatByMaHoaDon @mahoadon , @machitietkhoakythuat", new object[] { idhoadon, idchitietkhoakythuat });
            int tmp = data.Rows.Count - 1;
            if (tmp >= 0)
            {
                HoaDonNhomKyThuat hoadonchitietnhomkythuat = new HoaDonNhomKyThuat(data.Rows[tmp]);
                return hoadonchitietnhomkythuat.Hoadonnhomkythuat_ID;
            }

            return -1;
        }
        public bool InsertHoaDonNhomKyThuat(int idhoadon, int idchitietkhoakythuat)
        {
           int result = DAO_DataProvider.Instance.ExecuteNonQuery("InsertHoaDonNhomKyThuat @mahoadon , @machitietkhoakythuat", new object[] { idhoadon, idchitietkhoakythuat});
            return result > 0;
        }

        public bool InsertHoaDonCCNhomKyThuat(int idhoadon, int idchitietkhoakythuat)
        {
            int result = DAO_DataProvider.Instance.ExecuteNonQuery("InsertHoaDonCCNhomKyThuat @mahoadon , @machitietkhoakythuat", new object[] { idhoadon, idchitietkhoakythuat });
            return result > 0;
        }

        public bool DeleteHoaDonNhomKyThuat(int idchitiethoadonnhomkythuat)
        {
            int result = DAO_DataProvider.Instance.ExecuteNonQuery("DeleteHoaDonNhomKyThuat @machitiethoadonnhomkythuat", new object[] { idchitiethoadonnhomkythuat});
            return result > 0;
        }


        private DAO_HoaDonNhomKyThuat() { }
    }
}
