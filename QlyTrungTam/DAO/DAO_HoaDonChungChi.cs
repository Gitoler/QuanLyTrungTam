using QlyTrungTam.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DAO
{
    class DAO_HoaDonChungChi
    {
        private static DAO_HoaDonChungChi instance;
        public static DAO_HoaDonChungChi Instance
        {
            get
            {
                if (instance == null) instance = new DAO_HoaDonChungChi();
                return DAO_HoaDonChungChi.instance;
            }
            private set { instance = value; }
        }


        public List<HoaDonChungChi> GetHoaDonChungChiList()
        {

            List<HoaDonChungChi> hoadonchungchiList = new List<HoaDonChungChi>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetHoaDonChungChiList");
            foreach (DataRow item in data.Rows)
            {
                HoaDonChungChi HoaDonChungChi = new HoaDonChungChi(item);
                hoadonchungchiList.Add(HoaDonChungChi);
            }

            return hoadonchungchiList;

        }

        public List<HoaDonChungChi> GetHoaDonChungChiListByMaHoaDon(int mahoadon)
        {

            List<HoaDonChungChi> hoadonchungchiList = new List<HoaDonChungChi>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetHoaDonChungChiListByMaHoaDon " + mahoadon);
            foreach (DataRow item in data.Rows)
            {
                HoaDonChungChi HoaDonChungChi = new HoaDonChungChi(item);
                hoadonchungchiList.Add(HoaDonChungChi);
            }

            return hoadonchungchiList;

        }
        public bool InsertHoaDonChungChi(int price, int idhoadon)
        {
            string query = string.Format("INSERT INTO HoaDonChungChi (Gia, MaHoaDon) VALUES ({0}, {1} )", price, idhoadon);
            int result = DAO_DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


        private DAO_HoaDonChungChi() { }
    }
}
