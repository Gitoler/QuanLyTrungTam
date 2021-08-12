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
    class DAO_Vy_NhomHPKyThuat
    {
        private static DAO_Vy_NhomHPKyThuat instance;

        public static DAO_Vy_NhomHPKyThuat Instance
        {
            get
            {
                if (instance == null) instance = new DAO_Vy_NhomHPKyThuat();
                return instance;
            }
            private set { instance = value; }
        }
        private DAO_Vy_NhomHPKyThuat() { }

        public DataTable XemNhomHPKyThuat()
        {
            string query = "select * from nhomhpkythuat";

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            return result;
        }

        public DataTable XemNhomHPKyThuatWithID(DTO_Vy_NhomHPKyThuat hp)
        {
            string query = "select * from nhomhpkythuat where manhomhocphan = " + hp.MaNhomHocPhan.ToString();

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            return result;
        }

        public int CapNhatNhomHP(DTO_Vy_NhomHPKyThuat kh)
        {
            string query = "update nhomhpkythuat set tennhomhocphan = @ten , loai = @loai where manhomhocphan = @idnhom ";

            int rerult = DAO_DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[] {
                    kh.TenNhomHocPhan,
                    kh.Loai,
                    kh.MaNhomHocPhan
                });

            return rerult;
        }

        public int ThemNhomHP(DTO_Vy_NhomHPKyThuat kh)
        {
            string query = "insert into nhomhpkythuat(tennhomhocphan, loai) values( @ten , @loai )";

            int rerult = DAO_DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[] {
                    kh.TenNhomHocPhan,
                    kh.Loai
                });

            return rerult;
        }
    }
}
