using QlyTrungTam.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DAO
{
    class DAO_LichThiHocPhanKyThuat
    {
        private static DAO_LichThiHocPhanKyThuat instance;
        public static DAO_LichThiHocPhanKyThuat Instance
        {
            get
            {
                if (instance == null) instance = new DAO_LichThiHocPhanKyThuat();
                return DAO_LichThiHocPhanKyThuat.instance;
            }
            private set { instance = value; }
        }


        public List<LichThiHocPhanKyThuat> GetLichThiHocPhanKyThuatList()
        {

            List<LichThiHocPhanKyThuat> lichthihocphankythuatList = new List<LichThiHocPhanKyThuat>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetLichThiHocPhanKyThuatList");
            foreach (DataRow item in data.Rows)
            {
                LichThiHocPhanKyThuat LichThiHocPhanKyThuat = new LichThiHocPhanKyThuat(item);
                lichthihocphankythuatList.Add(LichThiHocPhanKyThuat);
            }

            return lichthihocphankythuatList;

        }

        public List<LichThiHocPhanKyThuat> GetLichThiHocPhanKyThuatListByHPKT(int idhpkt)
        {

            List<LichThiHocPhanKyThuat> lichthihocphankythuatList = new List<LichThiHocPhanKyThuat>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetLichThiHocPhanKyThuatListByHPKT @mahpkt", new object[] { idhpkt});
            foreach (DataRow item in data.Rows)
            {
                LichThiHocPhanKyThuat LichThiHocPhanKyThuat = new LichThiHocPhanKyThuat(item);
                lichthihocphankythuatList.Add(LichThiHocPhanKyThuat);
            }

            return lichthihocphankythuatList;

        }


        public bool InsertLichThiHocPhanKyThuat(int makhoahoc, string phongthi, int lanthi, DateTime ngaythi)
        {
            int result = DAO_DataProvider.Instance.ExecuteNonQuery("InsertLichThiHocPhanKyThuat @makhoahoc , @phongthi , @lanthi , @ngaythi", new object[] { makhoahoc, phongthi, lanthi, ngaythi });
            return result > 0;
        }
        public bool UpdateLichThiHocPhanKyThuat(int makhoahoc, string phongthi, int lanthi, DateTime ngaythi)
        {
            int result = DAO_DataProvider.Instance.ExecuteNonQuery("UpdateLichThiHocPhanKyThuat @makhoahoc , @phongthi , @lanthi , @ngaythi", new object[] { makhoahoc, phongthi, lanthi, ngaythi });
            return result > 0;
        }


        private DAO_LichThiHocPhanKyThuat() { }
    }
}
