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
    class DAO_Vy_NhomChungChi
    {
        private static DAO_Vy_NhomChungChi instance;

        public static DAO_Vy_NhomChungChi Instance
        {
            get
            {
                if (instance == null) instance = new DAO_Vy_NhomChungChi();
                return instance;
            }
            private set { instance = value; }
        }
        private DAO_Vy_NhomChungChi() { }

        public DataTable XemNhomChuyenChungChi()
        {
            string query = "select * from nhomchungchi";

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            return result;
        }

        public DataTable XemNhomChungChiWithID(DTO_Vy_NhomChungChi hp)
        {
            string query = "select * from nhomchungchi where manhomchungchi = " + hp.MaNhomChungChi.ToString();

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            return result;
        }

        public int CapNhatNhomChungChi(DTO_Vy_NhomChungChi kh)
        {
            string query = "update nhomchungchi set tennhomchungchi = @ten where manhomchungchi = @ma ";

            int rerult = DAO_DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[] {
                    kh.TenNhomChungChi,
                    kh.MaNhomChungChi,
                });

            return rerult;
        }

        public int ThemNhomChungChi(DTO_Vy_NhomChungChi kh)
        {
            string query = "insert into nhomchungchi(tennhomchungchi) values ( @ten )";

            int rerult = DAO_DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[] {
                    kh.TenNhomChungChi,
                });

            return rerult;
        }
    }
}
