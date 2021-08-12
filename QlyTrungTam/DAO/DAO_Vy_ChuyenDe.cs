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
    class DAO_Vy_ChuyenDe
    {
        private static DAO_Vy_ChuyenDe instance;

        public static DAO_Vy_ChuyenDe Instance
        {
            get
            {
                if (instance == null) instance = new DAO_Vy_ChuyenDe();
                return instance;
            }
            private set { instance = value; }
        }
        private DAO_Vy_ChuyenDe() { }

        public DataTable XemChuyenDe()
        {
            string query = "select * from chuyende";

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            return result;
        }

        public DataTable XemChuyenDeWithID(DTO_Vy_ChuyenDe hp)
        {
            string query = "select * from chuyende where machuyende = " + hp.MaChuyenDe.ToString();

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            return result;
        }

        public int CapNhatChuyenDe(DTO_Vy_ChuyenDe kh)
        {
            string query = "update chuyende set tenchuyende = @ten , manhomchuyende = @maNhom where machuyende = @ma ";

            int rerult = DAO_DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[] {
                    kh.TenChuyenDe,
                    kh.MaNhomChuyenDe,
                    kh.MaChuyenDe,
                });

            return rerult;
        }

        public int ThemChuyenDe(DTO_Vy_ChuyenDe kh)
        {
            string query = "insert into chuyende(tenchuyende, manhomchuyende) values ( @ten , @maNhom )";

            int rerult = DAO_DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[] {
                    kh.TenChuyenDe,
                    kh.MaNhomChuyenDe,
                });

            return rerult;
        }
    }
}
