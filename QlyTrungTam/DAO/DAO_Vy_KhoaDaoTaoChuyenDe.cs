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
    class DAO_Vy_KhoaDaoTaoChuyenDe
    {
        private static DAO_Vy_KhoaDaoTaoChuyenDe instance;

        public static DAO_Vy_KhoaDaoTaoChuyenDe Instance
        {
            get
            {
                if (instance == null) instance = new DAO_Vy_KhoaDaoTaoChuyenDe();
                return instance;
            }
            private set { instance = value; }
        }

        private DAO_Vy_KhoaDaoTaoChuyenDe() { }

        public DataTable XemKhoaHocCĐ()
        {
            string query = "select * from khoadaotaokythuat";

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            return result;
        }

        public DataTable XemKhoaHocCCWithID(DTO_Vy_KhoaDaoTaoChuyenDe kh)
        {
            string query = "select * from khoadaotaokythuat where makhoahoc = @kh ";

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query, new object[] { kh.MaKhoaHoc });

            return result;
        }

        public int ThemKhoaHoc(DTO_Vy_KhoaDaoTaoChuyenDe kh)
        {
            string query = "insert into khoadaotaochuyende(makhoahoc) values( @makh )";

            int rerult = DAO_DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[] {
                    kh.MaKhoaHoc,
                });

            return rerult;
        }
    }
}
