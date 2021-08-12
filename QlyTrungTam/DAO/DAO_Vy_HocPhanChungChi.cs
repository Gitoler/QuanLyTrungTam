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
    class DAO_Vy_HocPhanChungChi
    {
        private static DAO_Vy_HocPhanChungChi instance;

        public static DAO_Vy_HocPhanChungChi Instance
        {
            get
            {
                if (instance == null) instance = new DAO_Vy_HocPhanChungChi();
                return instance;
            }
            private set { instance = value; }
        }
        private DAO_Vy_HocPhanChungChi() { }

        public DataTable XemHocPhan()
        {
            string query = " select MaHPCC, NamHoc, HocKy, LichHoc, Phong, a.MaMonHoc , MaGiaoVien, TenNhomChungChi, a.MaKhoaHoc " +
                            " from HocPhanChungChi a, MonHoc b, NhomChungChi c " +
                            " where a.MaMonHoc = b.MaMonHoc AND b.MaNhomChungChi = c.MaNhomChungChi ";

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            return result;
        }

        public DataTable XemHocPhanWithID(DTO_Vy_HocPhanChungChi hp)
        {
            string query = " select MaHPCC, NamHoc, HocKy, LichHoc, Phong, a.MaMonHoc , MaGiaoVien, TenNhomChungChi, a.MaKhoaHoc " +
                            " from HocPhanChungChi a, MonHoc b, NhomChungChi c " +
                            " where a.MaHPCC = @mhp AND a.MaMonHoc = b.MaMonHoc AND b.MaNhomChungChi = c.MaNhomChungChi ";

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query, new object[] { hp.MaHocPhan });

            return result;
        }
        public DataTable SelectKhoaHoc()
        {
            string query = "select MaKhoaHoc from KhoaDaoTaoChungChi";

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            return result;
        }
        public DataTable SelectMonHoc()
        {
            string query = "select MaMonHoc from monHoc";

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            return result;
        }

        public DataTable SelectGiaoVien()
        {
            string query = "select MaGiaoVien from GiaoVien";

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            return result;
        }
        public int CapNhatHPCC(DTO_Vy_HocPhanChungChi kh)
        {
            string query = "update HocPhanChungChi set namhoc = @nam , hocky = @hocky , lichhoc = @lich , phong = @phong , mamonhoc = @mon , magiaovien = @gv , makhoahoc = @khab where mahpcc = @idhp ";

            int rerult = DAO_DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[] {
                    kh.Nam,
                    kh.HocKi,
                    kh.LichHoc,
                    kh.PhongHoc,
                    kh.MonHoc,
                    kh.GiaoVien,
                    kh.Khoa,
                    kh.MaHocPhan
                });

            return rerult;
        }

        public int ThemCTKhoaHoc(DTO_Vy_HocPhanChungChi kh)
        {
            string query = "insert into HocPhanChungChi(namhoc, hocky, lichhoc, phong, mamonhoc, magiaovien, MaKhoaHoc) values ( @nam , @hocky , @lich , @phong , @mon , @gv , @mkh )";

            int rerult = DAO_DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[] {
                    kh.Nam,
                    kh.HocKi,
                    kh.LichHoc,
                    kh.PhongHoc,
                    kh.MonHoc,
                    kh.GiaoVien,
                    kh.Khoa
                });

            return rerult;
        }

        public DataTable XemHocPhanChungChi()
        {
            string query = "select * from hocphanchungchi";

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            return result;
        }

        public DataTable XemHocPhanChungChiID(DTO_Vy_HocPhanChungChi hp)
        {
            string query = "select * from hocphanchungchi where mahpcc = " + hp.MaHocPhan.ToString();

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            return result;
        }
    }
}
