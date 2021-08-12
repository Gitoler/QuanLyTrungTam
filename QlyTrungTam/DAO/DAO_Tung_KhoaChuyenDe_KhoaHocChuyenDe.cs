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
    class DAO_Tung_KhoaChuyenDe_KhoaHocChuyenDe
    {
        private static DAO_Tung_KhoaChuyenDe_KhoaHocChuyenDe instance;

        public static DAO_Tung_KhoaChuyenDe_KhoaHocChuyenDe Instance
        {
            get
            {
                if (instance == null) instance = new DAO_Tung_KhoaChuyenDe_KhoaHocChuyenDe();
                return instance;
            }
            private set { instance = value; }
        }

        private DAO_Tung_KhoaChuyenDe_KhoaHocChuyenDe() { }
      
        public DataTable XemKhoaHocCD()
        {
            string query = "select * from khoadaotaochuyende ";

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            return result;
        }
        public DataTable XemKhoaHocCDWithID(DTO_Tung_KhoaDaoTaoChuyenDe kh)
        {
            string query = "select * from khoahoc where makhoahoc = @kh ";

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query, new object[] { kh.MaKhoaHoc });

            return result;
        }
        public int ThemKhoaHocCD(DTO_Tung_KhoaDaoTaoChuyenDe kh)
        {
            string query = "insert into khoadaotaochuyende( makhoahoc ) values( @makh )";

            int rerult = DAO_DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[] {
                    kh.MaKhoaHoc
                });

            return rerult;
        }
        


    }
}
