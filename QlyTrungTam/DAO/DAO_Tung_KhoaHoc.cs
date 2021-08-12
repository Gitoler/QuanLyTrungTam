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
    class DAO_Tung_KhoaHoc
    {
        private static DAO_Tung_KhoaHoc instance;

        public static DAO_Tung_KhoaHoc Instance
        {
            get
            {
                if (instance == null) instance = new DAO_Tung_KhoaHoc();
                return instance;
            }
            private set { instance = value; }
        }

        private DAO_Tung_KhoaHoc() { }

        public DataTable XemKhoaHocChuyenDe()
        {
            string query = "select * from khoahoc where maloaikhoahoc = 3 ";

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            return result;
        }
        public DataTable XemKhoaHocKyThuat()
        {
            string query = "select * from khoahoc where maloaikhoahoc = 1";

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            return result;
        }

        public int DemKhoaHoc()
        {
            string query = "select max(makhoahoc) as makhoahoc from khoahoc";

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            int id = Convert.ToInt32(result.Rows[0]["makhoahoc"]);

            return id;
        }

        public DataTable XemKhoaHocWithID(DTO_Tung_KhoaHoc mh)
        {
            string query = "select * from khoahoc where makhoahoc = " + mh.MaKhoaHoc.ToString();

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            return result;
        }

        public int CapNhatKhoaHoc(DTO_Tung_KhoaHoc kh)
        {
            string query = "update khoahoc set tenkhoahoc = @ten , ngaybatdau = @ngay , mota = @mota , maloaikhoahoc = @maloai , manhanvien = @manhanvien where makhoahoc = @makhoahoc ";

            int rerult = DAO_DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[] {
                    kh.TenKhoaHoc,
                    kh.NgayBatDau,
                    kh.MoTa,
                    kh.MaLoai,
                    kh.MaNhanVien,
                    kh.MaKhoaHoc
                });

            return rerult;
        }

        public int ThemKhoaHoc(DTO_Tung_KhoaHoc kh)
        {

            string query = "insert into khoahoc( tenkhoahoc , ngaybatdau , mota , maloaikhoahoc , manhanvien ) values( @ten , @ngaybatdau , @mota , @maloaikhoahoc , @manhanvien )";

            int rerult = DAO_DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[] {
                    kh.TenKhoaHoc,
                    kh.NgayBatDau,
                    kh.MoTa,
                    kh.MaLoai,
                    kh.MaNhanVien,
                });

            return rerult;
        }
    }
}
