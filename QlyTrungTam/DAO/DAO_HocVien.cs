using QlyTrungTam.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DAO
{
    class DAO_HocVien
    {
        private static DAO_HocVien instance;
        public static DAO_HocVien Instance
        {
            get
            {
                if (instance == null) instance = new DAO_HocVien();
                return DAO_HocVien.instance;
            }
            private set { instance = value; }
        }


        public List<HocVien> GetHocVienList()
        {

            List<HocVien> hocvienList = new List<HocVien>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetHocVienList");
            foreach( DataRow item in data.Rows)
            {
                HocVien hocvien = new HocVien(item);
                hocvienList.Add(hocvien);
            }

            return hocvienList;

        }

        public List<HocVien> GetHocVienListByMaHPCC(int idhpcc)
        {

            List<HocVien> hocvienList = new List<HocVien>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetHocVienListByMaHPCC @mahpcc", new object[] {idhpcc });
            foreach (DataRow item in data.Rows)
            {
                HocVien hocvien = new HocVien(item);
                hocvienList.Add(hocvien);
            }

            return hocvienList;

        }

        public List<HocVien> GetHocVienListByMaHPKT(int idhpkt)
        {

            List<HocVien> hocvienList = new List<HocVien>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetHocVienListByMaHPKT @mahpkt", new object[] { idhpkt });
            foreach (DataRow item in data.Rows)
            {
                HocVien hocvien = new HocVien(item);
                hocvienList.Add(hocvien);
            }

            return hocvienList;

        }

        public List<HocVien> GetHocVienListByLanThi(int idhpkt, int lanthi)
        {

            List<HocVien> hocvienList = new List<HocVien>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetHocVienListByLanThi @mahpkt , @lanthi", new object[] { idhpkt, lanthi });
            foreach (DataRow item in data.Rows)
            {
                HocVien hocvien = new HocVien(item);
                hocvienList.Add(hocvien);
            }

            return hocvienList;

        }

        public List<HocVien> GetHocVienTotNghiepListByLanThi(int idkhoahoc, int lanthi)
        {

            List<HocVien> hocvienList = new List<HocVien>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetHocVienTotNghiepListByLanThi @makhoahoc , @lanthi", new object[] { idkhoahoc, lanthi });
            foreach (DataRow item in data.Rows)
            {
                HocVien hocvien = new HocVien(item);
                hocvienList.Add(hocvien);
            }

            return hocvienList;

        }
        public List<HocVien> SearchHocVienListByName(string hocvienname)
        {

            List<HocVien> hocvienList = new List<HocVien>();
            string query = string.Format("select * from HocVien where TenHocVien like N'%{0}%'", hocvienname);
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                HocVien hocvien = new HocVien(item);
                hocvienList.Add(hocvien);
            }

            return hocvienList;

        }

        public bool InsertHocVien(string name, string sdt, string email)
        {
            int result;
            try
            {
                result = DAO_DataProvider.Instance.ExecuteNonQuery("InsertHocVien @ten , @sdt , @email ", new object[] { name, sdt, email });
                return result > 0;
            }
            catch
            {
                return false;
            }

        }

        public bool DeleteHocVien(int id)
        {
            int result;
            try
            {
                result = DAO_DataProvider.Instance.ExecuteNonQuery("DeleteHocVien @id ", new object[] { id });
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateHocVien(int id, string name, string sdt, string email)
        {
            int result;
            try
            {
                result = DAO_DataProvider.Instance.ExecuteNonQuery("UpdateHocVien @id , @ten , @sdt , @email ", new object[] {id, name, sdt, email });
                return result > 0;
            }
            catch
            {
                return false;
            }
        }
        public int GetIDHocVienByUserName()
        {

            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("select * from HocVien where EMail = '" + DTO_Account.Instance.UserName + "'");
            int tmp = data.Rows.Count - 1;
            if (tmp >= 0)
            {
                HocVien hocvien = new HocVien(data.Rows[tmp]);
                return hocvien.Hocvien_ID;
            }

            return -1;
        }

        private DAO_HocVien() { }
    }
}
