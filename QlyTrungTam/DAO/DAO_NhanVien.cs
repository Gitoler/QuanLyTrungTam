using QlyTrungTam.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DAO
{
    class DAO_NhanVien
    {
        private static DAO_NhanVien instance;
        public static DAO_NhanVien Instance
        {
            get
            {
                if (instance == null) instance = new DAO_NhanVien();
                return DAO_NhanVien.instance;
            }
            private set { instance = value; }
        }


        public List<NhanVien> GetNhanVienList()
        {

            List<NhanVien> nhanvienList = new List<NhanVien>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetNhanVienList");
            foreach (DataRow item in data.Rows)
            {
                NhanVien NhanVien = new NhanVien(item);
                nhanvienList.Add(NhanVien);
            }

            return nhanvienList;

        }
        public List<NhanVien> SearchNhanVienListByName(string NhanVienname)
        {

            List<NhanVien> nhanvienList = new List<NhanVien>();
            string query = string.Format("select * from NhanVien where TenNhanVien like N'%{0}%'", NhanVienname);
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                NhanVien NhanVien = new NhanVien(item);
                nhanvienList.Add(NhanVien);
            }

            return nhanvienList;

        }

        public bool InsertNhanVien(string name, string sdt, string email, string diachi)
        {
            int result;
            try
            {
                result = DAO_DataProvider.Instance.ExecuteNonQuery("InsertNhanVien @ten , @sdt , @email , @diachi ", new object[] { name, sdt, email, diachi });
                return result > 0;
            }
            catch 
            {
                return false;
            }
        }

        public bool DeleteNhanVien(int id)
        {
            int result;
            try
            {
                result = DAO_DataProvider.Instance.ExecuteNonQuery("DeleteNhanVien @id ", new object[] { id });
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateNhanVien(int id, string name, string sdt, string email, string diachi)
        {
            int result;
            try
            {
                result = DAO_DataProvider.Instance.ExecuteNonQuery("UpdateNhanVien @id , @ten , @sdt , @email , @diachi ", new object[] { id, name, sdt, email, diachi });
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        private DAO_NhanVien() { }
    }
}
