using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QlyTrungTam.DTO;

namespace QlyTrungTam.DAO
{
    class DAO_Vy_KhoaDaoTaoKyThuat
    {
        private static DAO_Vy_KhoaDaoTaoKyThuat instance;

        public static DAO_Vy_KhoaDaoTaoKyThuat Instance
        {
            get
            {
                if (instance == null) instance = new DAO_Vy_KhoaDaoTaoKyThuat();
                return instance;
            }
            private set { instance = value; }
        }

        private DAO_Vy_KhoaDaoTaoKyThuat() { }

        public DataTable XemKhoaHocKT()
        {
            string query = "select * from khoadaotaokythuat";

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            return result;
        }

        public DataTable XemKhoaHocKTWithID(DTO_Vy_KhoaDaoTaoKyThuat kh)
        {
            string query = "select * from khoadaotaokythuat where makhoahoc = @kh ";

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query, new object[] { kh.MaKhoaHoc });

            return result;
        }

        public int CapNhatKhoaHoc(DTO_Vy_KhoaDaoTaoKyThuat kh)
        {
            string query = "update khoadaotaokythuat set soluongnhomhp = @sl where makhoahoc = @idkh ";

            int rerult = DAO_DataProvider.Instance.ExecuteNonQuery(
                query, 
                new object[] { 
                    kh.SoLuongNhomHP, 
                    kh.MaKhoaHoc 
                });

            return rerult;
        }

        public int ThemKhoaHoc(DTO_Vy_KhoaDaoTaoKyThuat kh)
        {
            string query = "insert into khoadaotaokythuat(makhoahoc, soluongnhomhp) values( @makh , @sl )";

            int rerult = DAO_DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[] {
                    kh.MaKhoaHoc,
                    kh.SoLuongNhomHP
                });

            return rerult;
        }
    }
}
