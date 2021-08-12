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
    class DAO_Tung_KhoaChuyenDe_HocPhanChuyenDe
    {
        private static DAO_Tung_KhoaChuyenDe_HocPhanChuyenDe instance;

        public static DAO_Tung_KhoaChuyenDe_HocPhanChuyenDe Instance
        {
            get
            {
                if (instance == null) instance = new DAO_Tung_KhoaChuyenDe_HocPhanChuyenDe();
                return instance;
            }
            private set { instance = value; }
        }

        private DAO_Tung_KhoaChuyenDe_HocPhanChuyenDe() { }
        public DataTable XemHPCD()
        {
            string query = "select * from HocPhanChuyenDe";

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
        public DataTable XemHPCD_WithID(int hp)
        {
            string query = "select * from hocphanchuyende where mahpchuyende = @hp";

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query, new object[] { hp });

            return result;
        }
        public int ThemHPCD(DTO_Tung_HocPhanChuyenDe mahp)
        {
            string query = "insert into hocphanchuyende( namhoc , hocky , lichhoc , phong , machuyende , magiaovien , makhoahoc) values( @namhoc , @hocky , @lichhoc , @phong , @macd , @magv , @makh )";

            int rerult = DAO_DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[] {
                   mahp.NamHoc,
                   mahp.HocKy,
                   mahp.LichHoc,
                   mahp.Phong,
                   mahp.MaChuyenDe,
                   mahp.MaGiaoVien,
                   mahp.MaKhoaHoc,
                }); ;

            return rerult;
        }
        public int CapNhatHPCD(DTO_Tung_HocPhanChuyenDe kh)
        {
            
                string query = "update hocphanchuyende set namhoc = @nam , hocky = @hocky , lichhoc = @lich , phong = @phong , machuyende = @macd , magiaovien = @gv , makhoahoc = @makhoa where mahpchuyende = @mahp ";

                int rerult = DAO_DataProvider.Instance.ExecuteNonQuery(
                    query,
                    new object[] {
                    kh.NamHoc,
                    kh.HocKy,
                    kh.LichHoc,
                    kh.Phong,
                    kh.MaChuyenDe,
                    kh.MaGiaoVien,
                    kh.MaKhoaHoc,
                    kh.MaHPChuyenDe
                    });

                return rerult;
            
        }

    }
}
