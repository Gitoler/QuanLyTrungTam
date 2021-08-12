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
    class DAO_Vy_HocPhanKyThuat
    {
        private static DAO_Vy_HocPhanKyThuat instance;

        public static DAO_Vy_HocPhanKyThuat Instance
        {
            get
            {
                if (instance == null) instance = new DAO_Vy_HocPhanKyThuat();
                return instance;
            }
            private set { instance = value; }
        }
        private DAO_Vy_HocPhanKyThuat() { }

        public DataTable XemHocPhan()
        {
            string query = "select * from hocphankythuat";

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            return result;
        }

        public DataTable XemHocPhanWithID(DTO_Vy_HocPhanKyThuat hp)
        {
            string query = "select * from hocphankythuat where mahpkythuat = " + hp.MaHocPhan.ToString();

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            return result;
        }


        public int CapNhatCTKhoaHoc(DTO_Vy_HocPhanKyThuat kh)
        {
            string query = "update hocphankythuat set namhoc = @nam , hocky = @hocky , lichhoc = @lich , phong = @phong , mamonhoc = @mon , magiaovien = @gv , machitietkhoakythuat = @ct where mahpkythuat = @idhp ";

            int rerult = DAO_DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[] {
                    kh.Nam,
                    kh.HocKy,
                    kh.LichHoc,
                    kh.Phong,
                    kh.MaMonHoc,
                    kh.MaGiaoVien,
                    kh.MaChiTietKhoa,
                    kh.MaHocPhan
                });

            return rerult;
        }

        public int ThemHPKyThuat(DTO_Vy_HocPhanKyThuat kh)
        {
            string query = "insert into hocphankythuat(namhoc, hocky, lichhoc, phong, mamonhoc, magiaovien, machitietkhoakythuat) values ( @nam , @hocky , @lich , @phong , @mon , @gv , @ct )";

            int rerult = DAO_DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[] {
                    kh.Nam,
                    kh.HocKy,
                    kh.LichHoc,
                    kh.Phong,
                    kh.MaMonHoc,
                    kh.MaGiaoVien,
                    kh.MaChiTietKhoa,
                });

            return rerult;
        }
    }
}
