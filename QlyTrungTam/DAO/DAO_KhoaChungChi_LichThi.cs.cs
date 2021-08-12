using QlyTrungTam.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DAO
{
    class DAO_KhoaChungChi_LichThi
    {
        private static DAO_KhoaChungChi_LichThi instance;

        public static DAO_KhoaChungChi_LichThi Instance
        {
            get
            {
                if (instance == null) instance = new DAO_KhoaChungChi_LichThi();
                return instance;
            }
            private set { instance = value; }
        }
        private DAO_KhoaChungChi_LichThi() { }
        public DataTable XemLichThi()
        {
            string query = " select a.MaLichThiHPCC, a.PhongThi, a.NgayThi, a.MaNhanVien, a.MaHPCC, c.TenMonHoc, d.TenNhomChungChi " +
                            " from LichThiHPCC a, HocPhanChungChi b, MonHoc c, NhomChungChi d " +
                            " where a.MaHPCC = b.MaHPCC AND b.MaMonHoc = c.MaMonHoc AND c.MaNhomChungChi = d.MaNhomChungChi ";

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            return result;
        }

        public DataTable XemLichThiWithID(DTO_KhoaChungChi_LichThi lt)
        {
            string query = " select a.MaLichThiHPCC, a.PhongThi, a.NgayThi, a.MaNhanVien, a.MaHPCC, c.TenMonHoc, d.TenNhomChungChi " +
                            " from LichThiHPCC a, HocPhanChungChi b, MonHoc c, NhomChungChi d " +
                            " where a.MaHPCC = b.MaHPCC AND b.MaMonHoc = c.MaMonHoc AND c.MaNhomChungChi = d.MaNhomChungChi AND a.MaLichThiHPCC = @mlt  ";

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query, new object[] { lt.MaLichThi });

            return result;
        }
        public DataTable SelectHocPhan()
        {
            string query = "select MaHPCC from HocPhanChungChi";

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            return result;
        }
        public int SuaLT(DTO_KhoaChungChi_LichThi lt, DTO_KhoaChungChi_HocPhan hp)
        {
            string query = "update LichThiHPCC set NgayThi = @nt , PhongThi = @pt , MaHPCC = @mph where MaLichThiHPCC = @idlt  ";

            int rerult = DAO_DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[] {
                    lt.NgayThi,
                    lt.PhongThi,
                    hp.MaHocPhan,
                    lt.MaLichThi
                });

            return rerult;
        }
        public int ThemLT(DTO_KhoaChungChi_LichThi lt)
        {
            string query = " insert into LichThiHPCC(NgayThi, PhongThi, MaHPCC, MaNhanVien) " +
                " values ( @nt , @p , @mhp , @mnv )";

            int rerult = DAO_DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[] {
                    lt.NgayThi,
                    lt.PhongThi,
                    lt.MaHocPhan,
                    lt.MaNhanVien
                });

            return rerult;
        }
    }
}
