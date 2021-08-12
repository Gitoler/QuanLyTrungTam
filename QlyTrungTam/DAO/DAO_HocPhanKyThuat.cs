using QlyTrungTam.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DAO
{
    class DAO_HocPhanKyThuat
    {
        private static DAO_HocPhanKyThuat instance;
        public static DAO_HocPhanKyThuat Instance
        {
            get
            {
                if (instance == null) instance = new DAO_HocPhanKyThuat();
                return DAO_HocPhanKyThuat.instance;
            }
            private set { instance = value; }
        }


        public List<HocPhanKyThuat> GetHocPhanKyThuatList()
        {

            List<HocPhanKyThuat> hocphankythuatList = new List<HocPhanKyThuat>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetHocPhanKyThuatList");
            foreach (DataRow item in data.Rows)
            {
                HocPhanKyThuat HocPhanKyThuat = new HocPhanKyThuat(item);
                hocphankythuatList.Add(HocPhanKyThuat);
            }

            return hocphankythuatList;

        }

        public List<HocPhanKyThuat> GetHocPhanKyThuatListByMaKhoaHoc(int idkhoahoc, int idgiaovien)
        {

            List<HocPhanKyThuat> hocphankythuatList = new List<HocPhanKyThuat>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetHocPhanKyThuatListByMaKhoaHoc @makhoahoc , @magiaovien", new object[] { idkhoahoc, idgiaovien });
            foreach (DataRow item in data.Rows)
            {
                HocPhanKyThuat HocPhanKyThuat = new HocPhanKyThuat(item);
                hocphankythuatList.Add(HocPhanKyThuat);
            }

            return hocphankythuatList;

        }
        public List<HocPhanKyThuat> SearchHocPhanKyThuatListByName(string HocPhanKyThuatname)
        {

            List<HocPhanKyThuat> hocphankythuatList = new List<HocPhanKyThuat>();
            string query = string.Format("select * from HocPhanKyThuat where TenHocPhanKyThuat like N'%{0}%'", HocPhanKyThuatname);
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                HocPhanKyThuat HocPhanKyThuat = new HocPhanKyThuat(item);
                hocphankythuatList.Add(HocPhanKyThuat);
            }

            return hocphankythuatList;

        }

        public bool InsertHocPhanKyThuat(string name, string sdt, string email)
        {
            int result;
            try
            {
                result = DAO_DataProvider.Instance.ExecuteNonQuery("InsertHocPhanKyThuat @ten , @sdt , @email ", new object[] { name, sdt, email });
                return result > 0;
            }
            catch
            {
                return false;
            }

        }

        public bool DeleteHocPhanKyThuat(int id)
        {
            int result;
            try
            {
                result = DAO_DataProvider.Instance.ExecuteNonQuery("DeleteHocPhanKyThuat @id ", new object[] { id });
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateHocPhanKyThuat(int id, string name, string sdt, string email)
        {
            int result;
            try
            {
                result = DAO_DataProvider.Instance.ExecuteNonQuery("UpdateHocPhanKyThuat @id , @ten , @sdt , @email ", new object[] { id, name, sdt, email });
                return result > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
