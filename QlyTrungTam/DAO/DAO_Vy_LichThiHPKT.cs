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
    class DAO_Vy_LichThiHPKT
    {
        private static DAO_Vy_LichThiHPKT instance;

        public static DAO_Vy_LichThiHPKT Instance
        {
            get
            {
                if (instance == null) instance = new DAO_Vy_LichThiHPKT();
                return instance;
            }
            private set { instance = value; }
        }

        private DAO_Vy_LichThiHPKT() { }


        public DataTable XemLichThi()
        {
            string query = "select * from lichthihpkt";

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            return result;
        }

        public DataTable XemLichThiWithID(DTO_Vy_LichThiHPKT ct)
        {
            string query = "select * from lichthihpkt where malichthihpkt = " + ct.MaLichThi.ToString();

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            return result;
        }

        public int ThemLichThi(DTO_Vy_LichThiHPKT kh)
        {
            string query = "insert into lichthiHPKT(ngaythi, lanthi, phongthi, mahpkythuat, manhanvien) values( @ngaythi , @lanthi , @phong , @mahp , @manv )";

            int rerult = DAO_DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[] {
                    kh.NgayThi,
                    kh.LanThi,
                    kh.PhongThi,
                    kh.MaHPKT,
                    kh.MaNV
                });

            return rerult;
        }

        public int CapNhatLichThi(DTO_Vy_LichThiHPKT kh)
        {
            string query = "update lichthihpkt set ngaythi = @ngaythi , lanthi = @lanthi , phongthi = @phong , mahpkythuat = @mahp , manhanvien = @manv where malichthihpkt = @id ";

            int rerult = DAO_DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[] {
                    kh.NgayThi,
                    kh.LanThi,
                    kh.PhongThi,
                    kh.MaHPKT,
                    kh.MaNV,
                    kh.MaLichThi
                });

            return rerult;
        }
    }
}
