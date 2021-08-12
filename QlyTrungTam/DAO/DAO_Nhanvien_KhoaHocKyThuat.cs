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
    class DAO_Nhanvien_KhoaHocKyThuat
    {
        private static DAO_Nhanvien_KhoaHocKyThuat instance;

        public static DAO_Nhanvien_KhoaHocKyThuat Instance
        {
            get
            {
                if (instance == null) instance = new DAO_Nhanvien_KhoaHocKyThuat();
                return instance;
            }
            private set { instance = value; }
        }

        private DAO_Nhanvien_KhoaHocKyThuat() { }

        public DataTable XemKhoaHocKT()
        {
            string query = "select * from khoadaotaokythuat";

            DataTable result = DAO_DBConnect.Instance.ExecuteQuery(query);

            return result;
        }

        public DataTable XemKhoaHocKTWithID(DTO_Nhanvien_KhoaHocKyThuat kh)
        {
            string query = "select * from khoadaotaokythuat where makhoahoc = @kh ";

            DataTable result = DAO_DBConnect.Instance.ExecuteQuery(query, new object[] { kh.MaKhoaHoc });

            return result;
        }

        public int CapNhatKhoaHoc(DTO_Nhanvien_KhoaHocKyThuat kh)
        {
            string query = "update khoadaotaokythuat set tenkhoahoc = @ten , ngaybatdau = @nbd , soluongnhomhp = @sl , manhanvien = @idnv , mota = @mt where makhoahoc = @idkh ";

            int rerult = DAO_DBConnect.Instance.ExecuteNonQuery(
                query, 
                new object[] { 
                    kh.TenKhoaHoc, 
                    kh.NgayBatDau, 
                    kh.SoLuongNhomHP, 
                    kh.MaNhanVien, 
                    kh.MoTa.ToString(), 
                    kh.MaKhoaHoc 
                });

            return rerult;
        }

        public int ThemKhoaHoc(DTO_Nhanvien_KhoaHocKyThuat kh)
        {
            string query = "insert into khoadaotaokythuat(tenkhoahoc, ngaybatdau, soluongnhomhp, manhanvien, mota) values( @ten , @nbd , @sl , @idnv , @mt )";

            int rerult = DAO_DBConnect.Instance.ExecuteNonQuery(
                query,
                new object[] {
                    kh.TenKhoaHoc,
                    kh.NgayBatDau,
                    kh.SoLuongNhomHP,
                    kh.MaNhanVien,
                    kh.MoTa.ToString(),
                });

            return rerult;
        }
    }
}
