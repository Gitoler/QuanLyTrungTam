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
    class DAO_Vy_HocPhanChuyenDe
    {
        private static DAO_Vy_HocPhanChuyenDe instance;

        public static DAO_Vy_HocPhanChuyenDe Instance
        {
            get
            {
                if (instance == null) instance = new DAO_Vy_HocPhanChuyenDe();
                return instance;
            }
            private set { instance = value; }
        }
        private DAO_Vy_HocPhanChuyenDe() { }

        public DataTable XemHocPhan()
        {
            string query = "select * from hocphanchuyende";

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            return result;
        }

        public DataTable XemHocPhanWithID(DTO_Vy_HocPhanChuyenDe hp)
        {
            string query = "select * from hocphanchuyende where mahpchuyende = " + hp.MaHocPhan.ToString();

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            return result;
        }


        public int CapNhatHPChuyenDe(DTO_Vy_HocPhanChuyenDe kh)
        {
            string query = "update hocphanchuyende set namhoc = @nam , hocky = @hocky , lichhoc = @lich , phong = @phong , machuyende = @maCD , magiaovien = @gv , makhoahoc = @maKH where mahpchuyende = @idhp ";

            int rerult = DAO_DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[] {
                    kh.Nam,
                    kh.HocKy,
                    kh.LichHoc,
                    kh.Phong,
                    kh.MaChuyenDe,
                    kh.MaGiaoVien,
                    kh.MaKhoaHoc,
                    kh.MaHocPhan
                });

            return rerult;
        }

        public int ThemHPCD(DTO_Vy_HocPhanChuyenDe kh)
        {
            string query = "insert into hocphanchuyende(namhoc, hocky, lichhoc, phong, machuyende, magiaovien, makhoahoc) values ( @nam , @hocky , @lich , @phong , @cd , @gv , @kh )";

            int rerult = DAO_DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[] {
                    kh.Nam,
                    kh.HocKy,
                    kh.LichHoc,
                    kh.Phong,
                    kh.MaChuyenDe,
                    kh.MaGiaoVien,
                    kh.MaKhoaHoc,
                });

            return rerult;
        }
    }
}

