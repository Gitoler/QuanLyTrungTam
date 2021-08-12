using QlyTrungTam.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DAO
{
    class DAO_GiaoVien
    {
        private static DAO_GiaoVien instance;
        public static DAO_GiaoVien Instance
        {
            get
            {
                if (instance == null) instance = new DAO_GiaoVien();
                return DAO_GiaoVien.instance;
            }
            private set { instance = value; }
        }


        public List<GiaoVien> GetGiaoVienList()
        {

            List<GiaoVien> giaovienList = new List<GiaoVien>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetGiaoVienList");
            foreach (DataRow item in data.Rows)
            {
                GiaoVien GiaoVien = new GiaoVien(item);
                giaovienList.Add(GiaoVien);
            }

            return giaovienList;

        }
        public List<GiaoVien> SearchGiaoVienListByName(string giaovienname)
        {

            List<GiaoVien> giaovienList = new List<GiaoVien>();
            string query = string.Format("select * from GiaoVien where tengiaovien like N'%{0}%'", giaovienname);
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                GiaoVien GiaoVien = new GiaoVien(item);
                giaovienList.Add(GiaoVien);
            }

            return giaovienList;

        }

        public bool InsertGiaoVien(string name, string sdt, string email, string adress)
        {
            int result;
            try
            {
                result = DAO_DataProvider.Instance.ExecuteNonQuery("InsertGiaoVien @ten , @sdt , @email , @diachi ", new object[] { name, sdt, email, adress });
                return result > 0;
            }
            catch { return false; } 
        }

        public bool DeleteGiaoVien(int id)
        {
            int result;
            try
            {
                result = DAO_DataProvider.Instance.ExecuteNonQuery("DeleteGiaoVien @id ", new object[] { id });
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateGiaoVien(int id, string name, string sdt, string email, string adress)
        {
            int result;
            try
            {
                result = DAO_DataProvider.Instance.ExecuteNonQuery("UpdateGiaoVien @id , @ten , @sdt , @email , @diachi ", new object[] { id, name, sdt, email, adress });
                return result > 0;
            }
            catch
            {
                return false;
            }
        }
        public int GetIDGiaoVienByUserName()
        {

            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("select * from GiaoVien where EMail = '" + DTO_Account.Instance.UserName + "'");
            int tmp = data.Rows.Count - 1;
            if (tmp >= 0)
            {
                GiaoVien giaovien = new GiaoVien(data.Rows[tmp]);
                return giaovien.Giaovien_ID;
            }

            return -1;
        }

        private DAO_GiaoVien() { }
    }
}
