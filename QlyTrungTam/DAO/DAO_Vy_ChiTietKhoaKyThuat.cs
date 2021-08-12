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
    class DAO_Vy_ChiTietKhoaKyThuat
    {
        private static DAO_Vy_ChiTietKhoaKyThuat instance;

        public static DAO_Vy_ChiTietKhoaKyThuat Instance
        {
            get
            {
                if (instance == null) instance = new DAO_Vy_ChiTietKhoaKyThuat();
                return instance;
            }
            private set { instance = value; }
        }

        private DAO_Vy_ChiTietKhoaKyThuat() { }

        public DataTable XemCTKH()
        {
            string query = "select * from chitietkhoakythuat";

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            return result;
        }

        public DataTable XemCTKHWithID(DTO_Vy_ChiTietKhoaKyThuat ct)
        {
            string query = "select * from chitietkhoakythuat where machitietkhoakythuat = " + ct.MaChiTietKhoaHoc.ToString();

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            return result;
        }

        public DataTable XemCTKHWithIDHP(DTO_Vy_ChiTietKhoaKyThuat ct)
        {
            string query = "select * from chitietkhoakythuat where manhomhocphan = " + ct.MaNhomHocPhan.ToString();

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            return result;
        }

        public int ThemCTKhoaHoc(DTO_Vy_ChiTietKhoaKyThuat kh)
        {
            string query = "insert into chitietkhoakythuat(makhoahoc, manhomhocphan) values( @mk , @mahp )";

            int rerult = DAO_DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[] {
                    kh.MaKhoaHoc,
                    kh.MaNhomHocPhan,
                });

            return rerult;
        }

        public int CapNhatCTKhoaHoc(DTO_Vy_ChiTietKhoaKyThuat kh)
        {
            string query = "update chitietkhoakythuat set makhoahoc = @ten , manhomhocphan = @nbd where machitietkhoakythuat = @idkh ";

            int rerult = DAO_DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[] {
                    kh.MaKhoaHoc,
                    kh.MaNhomHocPhan,
                    kh.MaChiTietKhoaHoc,
                });

            return rerult;
        }
    }
}
