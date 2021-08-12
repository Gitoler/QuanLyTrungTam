using QlyTrungTam.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DAO
{
    class DAO_GiaoVienTotNghiep
    {
        private static DAO_GiaoVienTotNghiep instance;
        public static DAO_GiaoVienTotNghiep Instance
        {
            get
            {
                if (instance == null) instance = new DAO_GiaoVienTotNghiep();
                return DAO_GiaoVienTotNghiep.instance;
            }
            private set { instance = value; }
        }


        public List<GiaoVienTotNghiep> GetGiaoVienTotNghiepList()
        {

            List<GiaoVienTotNghiep> giaovientotnghiepList = new List<GiaoVienTotNghiep>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetGiaoVienTotNghiepList");
            foreach (DataRow item in data.Rows)
            {
                GiaoVienTotNghiep GiaoVienTotNghiep = new GiaoVienTotNghiep(item);
                giaovientotnghiepList.Add(GiaoVienTotNghiep);
            }

            return giaovientotnghiepList;

        }

        public List<GiaoVienTotNghiep> GetGiaoVienTotNghiepListByIDKhoaHoc(int idkhoahoc)
        {

            List<GiaoVienTotNghiep> giaovientotnghiepList = new List<GiaoVienTotNghiep>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetGiaoVienTotNghiepListByIDKhoaHoc @makhoahoc", new object[] { idkhoahoc});
            foreach (DataRow item in data.Rows)
            {
                GiaoVienTotNghiep GiaoVienTotNghiep = new GiaoVienTotNghiep(item);
                giaovientotnghiepList.Add(GiaoVienTotNghiep);
            }

            return giaovientotnghiepList;

        }

        public List<GiaoVienTotNghiep> GetGiaoVienTotNghiepListByLanThi(int idkhoahoc, int lanthi)
        {

            List<GiaoVienTotNghiep> giaovientotnghiepList = new List<GiaoVienTotNghiep>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetGiaoVienTotNghiepListByLanThi @makhoahoc , @lanthi", new object[] { idkhoahoc, lanthi });
            foreach (DataRow item in data.Rows)
            {
                GiaoVienTotNghiep GiaoVienTotNghiep = new GiaoVienTotNghiep(item);
                giaovientotnghiepList.Add(GiaoVienTotNghiep);
            }

            return giaovientotnghiepList;

        }

        public List<GiaoVienTotNghiep> GetGiaoVienTotNghiepListByIDHocVien(int idkhoahoc, int lanthi, int idhocvien)
        {

            List<GiaoVienTotNghiep> giaovientotnghiepList = new List<GiaoVienTotNghiep>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetGiaoVienTotNghiepListByIDHocVien @makhoahoc , @lanthi , @mahocvien", new object[] { idkhoahoc, lanthi, idhocvien });
            foreach (DataRow item in data.Rows)
            {
                GiaoVienTotNghiep GiaoVienTotNghiep = new GiaoVienTotNghiep(item);
                giaovientotnghiepList.Add(GiaoVienTotNghiep);
            }

            return giaovientotnghiepList;

        }
        public List<GiaoVienTotNghiep> SearchGiaoVienTotNghiepListByName(string hocvienname)
        {

            List<GiaoVienTotNghiep> giaovientotnghiepList = new List<GiaoVienTotNghiep>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("SearchGiaoVienTotNghiepListByName @hocvienname", new object[] { hocvienname });
            foreach (DataRow item in data.Rows)
            {
                GiaoVienTotNghiep GiaoVienTotNghiep = new GiaoVienTotNghiep(item);
                giaovientotnghiepList.Add(GiaoVienTotNghiep);
            }

            return giaovientotnghiepList;

        }

        public bool UpdateGiaoVienTotNghiep(int id, int diem)
        {
            int result;
            try
            {
                result = DAO_DataProvider.Instance.ExecuteNonQuery("UpdateGiaoVienTotNghiep @id , @diem ", new object[] { id, diem });
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        private DAO_GiaoVienTotNghiep() { }
    }
}
