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
    class DAO_Vy_NhomChuyenDe
    {
        private static DAO_Vy_NhomChuyenDe instance;

        public static DAO_Vy_NhomChuyenDe Instance
        {
            get
            {
                if (instance == null) instance = new DAO_Vy_NhomChuyenDe();
                return instance;
            }
            private set { instance = value; }
        }
        private DAO_Vy_NhomChuyenDe() { }

        public DataTable XemNhomChuyenDe()
        {
            string query = "select * from nhomchuyende";

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            return result;
        }

        public DataTable XemNhomChuyenDeWithID(DTO_Vy_NhomChuyenDe hp)
        {
            string query = "select * from nhomchuyende where manhomchuyende = " + hp.MaNhomChuyenDe.ToString();

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            return result;
        }

        public int CapNhatNhomChuyenDe(DTO_Vy_NhomChuyenDe kh)
        {
            string query = "update nhomchuyende set tennhomchuyende = @ten where manhomchuyende = @ma ";

            int rerult = DAO_DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[] {
                    kh.TenNhomChuyenDe,
                    kh.MaNhomChuyenDe,
                });

            return rerult;
        }

        public int ThemNhomChuyenDe(DTO_Vy_NhomChuyenDe kh)
        {
            string query = "insert into nhomchuyende(tennhomchuyende) values ( @ten )";

            int rerult = DAO_DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[] {
                    kh.TenNhomChuyenDe,
                });

            return rerult;
        }
    }
}
