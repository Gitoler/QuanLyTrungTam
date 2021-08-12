using QlyTrungTam.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DAO
{
    class DAO_ChiTietHoaDon
    {
        private static DAO_ChiTietHoaDon instance;
        public static DAO_ChiTietHoaDon Instance
        {
            get
            {
                if (instance == null) instance = new DAO_ChiTietHoaDon();
                return DAO_ChiTietHoaDon.instance;
            }
            private set { instance = value; }
        }


        public List<ChiTietHoaDon> GetChiTietHoaDonList()
        {

            List<ChiTietHoaDon> chitiethoadonList = new List<ChiTietHoaDon>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetChiTietHoaDonList");
            foreach (DataRow item in data.Rows)
            {
                ChiTietHoaDon ChiTietHoaDon = new ChiTietHoaDon(item);
                chitiethoadonList.Add(ChiTietHoaDon);
            }

            return chitiethoadonList;

        }

        public List<ChiTietHoaDon> GetChiTietHoaDonListByMaHoaDon(int mahoadon)
        {

            List<ChiTietHoaDon> chitiethoadonList = new List<ChiTietHoaDon>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetChiTietHoaDonListByMaHoaDon " + mahoadon);
            foreach (DataRow item in data.Rows)
            {
                ChiTietHoaDon ChiTietHoaDon = new ChiTietHoaDon(item);
                chitiethoadonList.Add(ChiTietHoaDon);
            }

            return chitiethoadonList;

        }

        public List<ChiTietHoaDon> GetUnpayChiTietHoaDonListByMaHoaDon(int mahoadon)
        {

            List<ChiTietHoaDon> chitiethoadonList = new List<ChiTietHoaDon>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetUnpayChiTietHoaDonListByMaHoaDon " + mahoadon);
            foreach (DataRow item in data.Rows)
            {
                ChiTietHoaDon ChiTietHoaDon = new ChiTietHoaDon(item);
                chitiethoadonList.Add(ChiTietHoaDon);
            }

            return chitiethoadonList;

        }
        public bool InsertChiTietHoaDon(int price, int idhoadon)
        {
            string query = string.Format("INSERT INTO ChiTietHoaDon (Gia, MaHoaDon) VALUES ({0}, {1} )", price, idhoadon);
            int result = DAO_DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


        private DAO_ChiTietHoaDon() { }
    }
}
