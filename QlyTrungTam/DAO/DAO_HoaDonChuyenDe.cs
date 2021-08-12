using QlyTrungTam.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DAO
{
    class DAO_HoaDonChuyenDe
    {
        private static DAO_HoaDonChuyenDe instance;
        public static DAO_HoaDonChuyenDe Instance
        {
            get
            {
                if (instance == null) instance = new DAO_HoaDonChuyenDe();
                return DAO_HoaDonChuyenDe.instance;
            }
            private set { instance = value; }
        }


        public List<HoaDonChuyenDe> GetHoaDonChuyenDeList()
        {

            List<HoaDonChuyenDe> hoadonchuyendeList = new List<HoaDonChuyenDe>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetHoaDonChuyenDeList");
            foreach (DataRow item in data.Rows)
            {
                HoaDonChuyenDe HoaDonChuyenDe = new HoaDonChuyenDe(item);
                hoadonchuyendeList.Add(HoaDonChuyenDe);
            }

            return hoadonchuyendeList;

        }

        public List<HoaDonChuyenDe> GetHoaDonChuyenDeListByMaHoaDon(int mahoadon)
        {

            List<HoaDonChuyenDe> hoadonchuyendeList = new List<HoaDonChuyenDe>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetHoaDonChuyenDeListByMaHoaDon " + mahoadon);
            foreach (DataRow item in data.Rows)
            {
                HoaDonChuyenDe HoaDonChuyenDe = new HoaDonChuyenDe(item);
                hoadonchuyendeList.Add(HoaDonChuyenDe);
            }

            return hoadonchuyendeList;

        }
        public bool InsertHoaDonChuyenDe(int price, int idhoadon)
        {
            string query = string.Format("INSERT INTO HoaDonChuyenDe (Gia, MaHoaDon) VALUES ({0}, {1} )", price, idhoadon);
            int result = DAO_DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


        private DAO_HoaDonChuyenDe() { }
    }
}
