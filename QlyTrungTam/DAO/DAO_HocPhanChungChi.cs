using QlyTrungTam.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DAO
{
    class DAO_HocPhanChungChi
    {
        private static DAO_HocPhanChungChi instance;
        public static DAO_HocPhanChungChi Instance
        {
            get
            {
                if (instance == null) instance = new DAO_HocPhanChungChi();
                return DAO_HocPhanChungChi.instance;
            }
            private set { instance = value; }
        }


        public List<HocPhanChungChi> GetHocPhanChungChiList()
        {

            List<HocPhanChungChi> hocphanchungchiList = new List<HocPhanChungChi>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetHocPhanChungChiList");
            foreach (DataRow item in data.Rows)
            {
                HocPhanChungChi HocPhanChungChi = new HocPhanChungChi(item);
                hocphanchungchiList.Add(HocPhanChungChi);
            }

            return hocphanchungchiList;

        }

        public List<HocPhanChungChi> GetHocPhanChungChiListByMaKhoaHoc(int idkhoahoc, int idgiaovien)
        {

            List<HocPhanChungChi> hocphanchungchiList = new List<HocPhanChungChi>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetHocPhanChungChiListByMaKhoaHoc @makhoahoc , @magiaovien", new object[] { idkhoahoc, idgiaovien});
            foreach (DataRow item in data.Rows)
            {
                HocPhanChungChi HocPhanChungChi = new HocPhanChungChi(item);
                hocphanchungchiList.Add(HocPhanChungChi);
            }

            return hocphanchungchiList;

        }
        public List<HocPhanChungChi> SearchHocPhanChungChiListByName(string HocPhanChungChiname)
        {

            List<HocPhanChungChi> hocphanchungchiList = new List<HocPhanChungChi>();
            string query = string.Format("select * from HocPhanChungChi where TenHocPhanChungChi like N'%{0}%'", HocPhanChungChiname);
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                HocPhanChungChi HocPhanChungChi = new HocPhanChungChi(item);
                hocphanchungchiList.Add(HocPhanChungChi);
            }

            return hocphanchungchiList;

        }

        public bool InsertHocPhanChungChi(string name, string sdt, string email)
        {
            int result;
            try
            {
                result = DAO_DataProvider.Instance.ExecuteNonQuery("InsertHocPhanChungChi @ten , @sdt , @email ", new object[] { name, sdt, email });
                return result > 0;
            }
            catch
            {
                return false;
            }

        }

        public bool DeleteHocPhanChungChi(int id)
        {
            int result;
            try
            {
                result = DAO_DataProvider.Instance.ExecuteNonQuery("DeleteHocPhanChungChi @id ", new object[] { id });
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateHocPhanChungChi(int id, string name, string sdt, string email)
        {
            int result;
            try
            {
                result = DAO_DataProvider.Instance.ExecuteNonQuery("UpdateHocPhanChungChi @id , @ten , @sdt , @email ", new object[] { id, name, sdt, email });
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        private DAO_HocPhanChungChi() { }
    }
}
