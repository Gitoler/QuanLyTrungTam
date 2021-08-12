using QlyTrungTam.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DAO
{
    class DAO_LichThiTotNghiep
    {
        private static DAO_LichThiTotNghiep instance;
        public static DAO_LichThiTotNghiep Instance
        {
            get
            {
                if (instance == null) instance = new DAO_LichThiTotNghiep();
                return DAO_LichThiTotNghiep.instance;
            }
            private set { instance = value; }
        }


        public List<LichThiTotNghiep> GetLichThiTotNghiepList()
        {

            List<LichThiTotNghiep> lichthitotnghiepList = new List<LichThiTotNghiep>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetLichThiTotNghiepList");
            foreach (DataRow item in data.Rows)
            {
                LichThiTotNghiep LichThiTotNghiep = new LichThiTotNghiep(item);
                lichthitotnghiepList.Add(LichThiTotNghiep);
            }

            return lichthitotnghiepList;

        }
        public List<LichThiTotNghiep> GetLichThiTotNghiepLanThiListByIDKhoaHoc(int idkhoahoc)
        {

            List<LichThiTotNghiep> lichthitotnghiepList = new List<LichThiTotNghiep>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetLichThiTotNghiepLanThiListByIDKhoaHoc @makhoahoc", new object[] {idkhoahoc });
            foreach (DataRow item in data.Rows)
            {
                LichThiTotNghiep LichThiTotNghiep = new LichThiTotNghiep(item);
                lichthitotnghiepList.Add(LichThiTotNghiep);
            }

            return lichthitotnghiepList;

        }


        public bool InsertLichThiTotNghiep(int makhoahoc, string phongthi, int lanthi, DateTime ngaythi)
        {
            int result = DAO_DataProvider.Instance.ExecuteNonQuery("InsertLichThiTotNghiep @makhoahoc , @phongthi , @lanthi , @ngaythi", new object[] { makhoahoc, phongthi , lanthi , ngaythi });
            return result > 0;
        }
        public bool UpdateLichThiTotNghiep(int makhoahoc, string phongthi, int lanthi, DateTime ngaythi)
        {
            int result = DAO_DataProvider.Instance.ExecuteNonQuery("UpdateLichThiTotNghiep @makhoahoc , @phongthi , @lanthi , @ngaythi", new object[] { makhoahoc, phongthi, lanthi, ngaythi });
            return result > 0;
        }


        private DAO_LichThiTotNghiep() { }
    }
}
