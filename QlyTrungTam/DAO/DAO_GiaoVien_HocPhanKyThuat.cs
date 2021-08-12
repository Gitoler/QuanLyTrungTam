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
    class DAO_GiaoVien_HocPhanKyThuat
    {
        private static DAO_GiaoVien_HocPhanKyThuat instance;

        public static DAO_GiaoVien_HocPhanKyThuat Instance
        {
            get
            {
                if (instance == null) instance = new DAO_GiaoVien_HocPhanKyThuat();
                return instance;
            }
            private set { instance = value; }
        }

        private DAO_GiaoVien_HocPhanKyThuat() { }

        public DataTable XemKhoaHocKT()
        {
            string query = "select * from hocphankythuat,,";

            DataTable result = DAO_DBConnect.Instance.ExecuteQuery(query);

            return result;
        }

        public DataTable XemKhoaHocKTWithID(DTO_Nhanvien_KhoaHocKyThuat kh)
        {
            string query = "select * from hocphankythuat where makhoahoc = @kh ";

            DataTable result = DAO_DBConnect.Instance.ExecuteQuery(query, new object[] { kh.MaKhoaHoc });

            return result;
        }

        public int CapNhatKhoaHoc(DTO_Nhanvien_KhoaHocKyThuat kh)
        {
            string query = "update hocphankythuat set tenkhoahoc = @ten , ngaybatdau = @nbd , soluongnhomhp = @sl , manhanvien = @idnv , mota = @mt where makhoahoc = @idkh ";

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
            string query = "insert into hocphankythuat(tenkhoahoc, ngaybatdau, soluongnhomhp, manhanvien, mota) values( @ten , @nbd , @sl , @idnv , @mt )";

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
        public DataTable SelectHPKT()
        {
            string query = "select MaHPKyThuat from HocPhanKyThuat";

            DataTable result = DAO_DBConnect.Instance.ExecuteQuery(query);

            return result;
        }
        public DataTable XemHPKT_WithID(int hp)
        {
            string query = "select * from hocphankythuat where mahpkythuat = @hp";

            DataTable result = DAO_DBConnect.Instance.ExecuteQuery(query, new object[] { hp });

            return result;
        }
        public int ThemDiemKT(DTO_DiemHocPhanKiThuat diem)
        {
            string query = "insert into diemhocphankithuat(diem, mahocvien, mahpkythuat) values( @diem , @mahocvien , @mahpkt )";

            int rerult = DAO_DBConnect.Instance.ExecuteNonQuery(
                query,
                new object[] {
                   diem.Diem,
                   diem.MaHocVien,
                   diem.MaHPKyThuat,
                }); ;

            return rerult;
        }
        public DataTable XemDiemHPKT_WithID(int hp)
        {
            string query = "select * from DiemHocPhanKiThuat where madiemhpkt = @hp";

            DataTable result = DAO_DBConnect.Instance.ExecuteQuery(query, new object[] { hp });

            return result;
        }
        public int TimMaHV_QuaMaDHPKT(int hp)
        {
            string query = "select * from DiemHocPhanKiThuat where madiemhpkt = @hp";
            DataTable result = DAO_DBConnect.Instance.ExecuteQuery(query, new object[] { hp });
            int mahocvien = Convert.ToInt32(result.Rows[0]["MaHocVien"].ToString());
            return mahocvien;
        }
        public int CapNhatDiemHPKT(DTO_DiemHocPhanKiThuat diem)
        {
            string query = "update diemhocphankithuat set diem = @diem , mahocvien = @mahocvien ,mahpkythuat = @mahpkt  where madiemhpkt = @madiem ";

            int rerult = DAO_DBConnect.Instance.ExecuteNonQuery(
                query,
                new object[] {
                    diem.Diem,
                   diem.MaHocVien,
                   diem.MaHPKyThuat,
    
                   diem.MaDiemHPKT,
                });

            return rerult;
        }
        public DataTable XemHPKT()
        {
            string query = "select DKT.MaDiemHPKT, KT.MaHPKyThuat, KH.TenKhoaHoc, MH.TenMonHoc , KT.NamHoc , KT.HocKy , KT.LichHoc , GV.TenGiaoVien, HV.TenHocVien ,DKT.Diem from (((( HocVien HV join DiemHocPhanKiThuat DKT on HV.MaHocVien = DKT.MaHocVien ) join HocPhanKyThuat KT on KT.MaHPKyThuat = DKT.MaHPKyThuat) join GiaoVien GV on GV.MaGiaoVien = KT.MaGiaoVien) join MonHoc MH on MH.MaMonHoc = KT.MaMonHoc) join KhoaHoc KH on KH.MaKhoaHoc = KT.MaChiTietKhoaKyThuat";

            DataTable result = DAO_DBConnect.Instance.ExecuteQuery(query);
            return result;
        }
    }
}
