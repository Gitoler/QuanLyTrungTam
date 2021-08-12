using QlyTrungTam.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DAO
{
    class DAO_HoaDon
    {
        private static DAO_HoaDon instance;
        public static DAO_HoaDon Instance
        {
            get
            {
                if (instance == null) instance = new DAO_HoaDon();
                return DAO_HoaDon.instance;
            }
            private set { instance = value; }
        }


        public List<HoaDon> GetHoaDonList()
        {

            List<HoaDon> hoadonList = new List<HoaDon>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetHoaDonList");
            foreach (DataRow item in data.Rows)
            {
                HoaDon HoaDon = new HoaDon(item);
                hoadonList.Add(HoaDon);
            }

            return hoadonList;

        }

        public int  GetUnpayMaHoaDonByMaHocVien(int mahocvien, int makhoahoc)
        {

            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("select * from hoadon hd , chitiethoadon cthd where hd.mahoadon = cthd.mahoadon and cthd.tinhtrang = 0 and hd.mahocvien = " + mahocvien + " and hd.makhoahoc = " + makhoahoc);
            int tmp = data.Rows.Count -1;
            if(tmp >= 0)
            {
                HoaDon hoadon = new HoaDon(data.Rows[tmp]);
                return hoadon.Hoadon_ID;
            }

            return -1;
        }

        public int GetUnpayMaHoaDonKyThuatByMaHocVien(int mahocvien, int makhoahoc)
        {

            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("select * from hoadon hd, hoadonkythuat hdkt where hd.MaHoaDon = hdkt.MaHoaDon and hd.mahocvien = " + mahocvien + "  and hd.makhoahoc = " + makhoahoc);
            int tmp = data.Rows.Count - 1;
            if (tmp >= 0)
            {
                HoaDon hoadon = new HoaDon(data.Rows[tmp]);
                return hoadon.Hoadon_ID;
            }

            return -1;
        }


        public bool InsertHoaDon(int idhocvien, int idkhoahoc)
        {
            string query = string.Format("INSERT INTO HOADON (NgayTao, MaHocVien , MaKhoaHoc) VALUES (GetDate(), N'{0}' , N'{1}')", idhocvien, idkhoahoc);
            int result = DAO_DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool InsertHoaDonKyThuatCC(int idhocvien, int idkhoahoc)
        {
            int result = DAO_DataProvider.Instance.ExecuteNonQuery("InsertHoaDonKythuatCC @mahocvien , @makhoahoc", new object[] { idhocvien, idkhoahoc });
            return result > 0;
        }
        public bool InsertHoaDonCC(int idhocvien, int idkhoahoc)
        {
            int result = DAO_DataProvider.Instance.ExecuteNonQuery("InsertHoaDonCC @mahocvien , @makhoahoc", new object[] { idhocvien, idkhoahoc});
            return result > 0;
        }
        public bool UpdateHoaDon(int idhocvien, int idkhoahoc)
        {
            int mahoadon = GetUnpayMaHoaDonByMaHocVien(idhocvien, idkhoahoc);
            string query = string.Format("Update HOADON SET TinhTrang = 1 Where mahoadon = " + mahoadon);
            int result = DAO_DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteHoaDon(int idhocvien, int idkhoahoc)
        {
            int mahoadon = GetUnpayMaHoaDonByMaHocVien(idhocvien, idkhoahoc);
            int result = DAO_DataProvider.Instance.ExecuteNonQuery("DeleteHoaDon @mahoadon", new object[] { mahoadon});
            return result > 0;
        }

        public bool DeleteHoaDonChiTietNhomKyThuat(int idhocvien, int idkhoahoc)
        {
            int mahoadon = GetUnpayMaHoaDonByMaHocVien(idhocvien, idkhoahoc);
            int result = DAO_DataProvider.Instance.ExecuteNonQuery("DeleteHoaDon @mahoadon", new object[] { mahoadon });
            return result > 0;
        }



        private DAO_HoaDon() { }
    }
}
