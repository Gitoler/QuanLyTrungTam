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
    class DAO_KhoaChungChi_KhoaHocChungChi
    {
        private static DAO_KhoaChungChi_KhoaHocChungChi instance;

        public static DAO_KhoaChungChi_KhoaHocChungChi Instance
        {
            get
            {
                if (instance == null) instance = new DAO_KhoaChungChi_KhoaHocChungChi();
                return instance;
            }
            private set { instance = value; }
        }

        private DAO_KhoaChungChi_KhoaHocChungChi() { }

        public DataTable XemKhoaHocCC()
        {
            string query = " select a.MaKhoaHoc, b.TenKhoaHoc, b.NgayBatDau, a.MaNhomChungChi, a.SoLuongHPCC, b.MaNhanVien, b.MoTa " +
                " from KhoaDaoTaoChungChi a, KhoaHoc b " +
                " where a.MaKhoaHoc = b.MaKhoaHoc ";

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            return result;
        }
        public string GetIDNhanVien()
        {
            string query = "select MaNhanVien from NhanVien where email = '" + DTO_Account.Instance.UserName + "'";

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            string ret = result.Rows[0]["MaNhanVien"].ToString();

            return ret;
        }

        public DataTable XemKhoaHocCCWithID(DTO_KhoaChungChi_KhoaHoc kh, DTO_KhoaChungChi_KhoaHocChungChi cc)
        {
            string query = " select a.MaKhoaHoc, b.TenKhoaHoc, b.NgayBatDau, a.MaNhomChungChi, a.SoLuongHPCC, b.MaNhanVien, b.MoTa " +
                " from KhoaDaoTaoChungChi a, KhoaHoc b " +
                " where a.MaKhoaHoc = b.MaKhoaHoc AND a.MaKhoaHoc = @mh ";

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query, new object[] { kh.MaKhoaHoc });

            return result;
        }

        public int CapNhatKhoaHoc(DTO_KhoaChungChi_KhoaHoc kh, DTO_KhoaChungChi_KhoaHocChungChi cc)
        {
            string query1 = "update KhoaDaoTaoChungChi set SoLuongHPCC = @sl , manhomchungchi = @mn where maKhoahoc = @idkh ";
            string query2  = "update KhoaHoc set NgayBatDau = @nbd , manhanvien = @idnv , mota = @mt , TenKhoaHoc = @ten where maKhoahoc = @idkh ";

            int rerult1 = DAO_DataProvider.Instance.ExecuteNonQuery(
                query1,
                new object[] {
                    cc.SoLuongHocPhan,
                    cc.ChungChi,
                    cc.MaKhoaHoc
                });
            int rerult2 = DAO_DataProvider.Instance.ExecuteNonQuery(
                query2,
                new object[] {
                    kh.NgayBatDau,
                    kh.MaNhanVien,
                    kh.MoTa,
                    kh.TenKhoaHoc,
                    kh.MaKhoaHoc
                });
            return rerult1 + rerult2;
        }
        public int ThemKhoaHoc(DTO_KhoaChungChi_KhoaHoc kh, DTO_KhoaChungChi_KhoaHocChungChi cc)
        {
            string query = " insert into KhoaHoc(TenKhoaHoc, NgayBatDau, MoTa, MaLoaiKhoaHoc, MaNhanVien) " +
                " values ( @tkh , @nbd , @mt , @ml , @mnv )";
            
            int result = DAO_DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[] {
                    kh.TenKhoaHoc,
                    kh.NgayBatDau,
                    kh.MoTa.ToString(),
                    2,
                    kh.MaNhanVien
                });
            
            if(result == 0)
            {
                return 0;
            }

            string query2 = " insert into KhoaDaoTaoChungChi(MaKhoaHoc, SoLuongHPCC, MaNhomChungChi) " +
                " values ( dbo.GETMAX() , @nbd , @mt )";

            int result2 = DAO_DataProvider.Instance.ExecuteNonQuery(
                query2,
                new object[] {
                    cc.SoLuongHocPhan,
                    cc.ChungChi
                });

            return result2;
        }
    }
}
