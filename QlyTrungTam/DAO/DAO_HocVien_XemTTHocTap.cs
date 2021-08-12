using QlyTrungTam.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DAO
{
    class DAO_HocVien_XemTTHocTap
    {
        private static DAO_HocVien_XemTTHocTap instance;
        public static DAO_HocVien_XemTTHocTap Instance
        {
            get
            {
                if (instance == null) instance = new DAO_HocVien_XemTTHocTap();
                return instance;
            }
            private set { instance = value; }
        }
        public DataTable Select_HocVien_NamHoc(int type = 1) // 1Kythuat 2ChungChi 3ChuyenDe 4ThiTotNghiep
        {
            DataTable result = new DataTable();

            if(type == 1)
            {
                result = DAO_DataProvider.Instance.ExecuteQuery("select distinct NamHoc FROM HocPhanKyThuat");
            }
            if (type == 2)
            {
                result = DAO_DataProvider.Instance.ExecuteQuery("select distinct NamHoc FROM HocPhanChungChi");
            }
            if (type == 3)
            {
                result = DAO_DataProvider.Instance.ExecuteQuery("select distinct NamHoc FROM HocPhanChuyenDe");
            }
            if (type == 4)
            {
                result = DAO_DataProvider.Instance.ExecuteQuery("select distinct YEAR(NgayThi) AS NamHoc FROM LichThiTotNghiep");
            }

            return result;
        }

        public DataTable Select_HocVien_LichThi(DTO_HocVien_XemTTHocTap a, int type = 1) // 1Kythuat 2ChungChi 3ChuyenDe 4ThiTotNghiep
        {
            DataTable result = new DataTable();
            if (type == 1)
            {
                result = DAO_DataProvider.Instance.ExecuteQuery(
                " select distinct g.MaHPKyThuat, h.NgayThi, h.PhongThi, h.LanThi " +
                " from Userpass u, HocVien a, HoaDon b, ChiTietHoaDon d, ChiTietHoaDonNhomHPKyThuat e, ChiTietKhoaKyThuat f, HocPhanKyThuat g, LichThiHPKT h " +
                " where u.Username = @username AND a.EMail = u.Username AND a.MaHocVien = b.MaHocVien" +
                " AND b.MaHoaDon = d.MaHoaDon AND d.MaChiTietHD = e.MaChiTietHDNHPKT AND f.MaChiTietKhoaKyThuat = e.MaChiTietKhoaKyThuat " +
                " AND f.MaChiTietKhoaKyThuat = g.MaChiTietKhoaKyThuat AND g.MaHPKyThuat = h.MaHPKyThuat AND g.HocKy = @hk AND g.NamHoc = @nh ", 
                    new object[] { DTO_Account.Instance.UserName, a.HocKi, a.NamHoc });
            }
            if (type == 2)
            {
                result = DAO_DataProvider.Instance.ExecuteQuery(" select e.MaHPCC, f.PhongThi, f.NgayThi " +
                    " from Userpass u, HocVien a, HoaDon b, ChiTietHoaDon d, ChiTietHoaDonHPChungChi e, LichThiHPCC f, HocPhanChungChi g " +
                    " where u.Username = @username AND a.EMail = u.Username AND a.MaHocVien = b.MaHocVien " +
                    " AND b.MaHoaDon = d.MaHoaDon AND d.MaChiTietHD = e.MaChiTietHDHPCC AND e.MaHPCC = f.MaHPCC AND e.MaHPCC = g.MaHPCC" +
                    " AND g.NamHoc = @nh AND g.HocKy = @hk ",
                    new object[] { DTO_Account.Instance.UserName, a.NamHoc, a.HocKi });
            }
            if (type == 4)
            {
                result = DAO_DataProvider.Instance.ExecuteQuery(
                " select c.MaLichThiTotNghiep, c.MaKhoaHoc, c.NgayThi, c.PhongThi, c.LanThi " +
                " from Userpass u, HocVien a, DiemThiTotNghiep b , LichThiTotNghiep c " +
                " where u.Username = @user AND a.EMail = u.Username " +
                " AND a.MaHocVien = b.MaHocVien AND b.MaLichThiTotNghiep = c.MaLichThiTotNghiep AND YEAR(c.NgayThi) = @nh ", 
                    new object[] {DTO_Account.Instance.UserName, a.NamHoc });
            }

            return result;
        }

        public DataTable Select_HocVien_Diem(DTO_HocVien_XemTTHocTap a, int type = 1) // 1Kythuat 2ChungChi 3ChuyenDe 4ThiTotNghiep
        {
            DataTable result = new DataTable();
            if (type == 1)
            {
                result = DAO_DataProvider.Instance.ExecuteQuery(
                    " select d.MaMonHoc, d.MaHPKyThuat, c.Diem " +
                    " from USERPASS a, HocVien b, DiemHocPhanKiThuat c, HocPhanKyThuat d " +
                    " where a.Username = b.EMail AND a.Username = @usn " +
                    " AND b.MaHocVien = c.MaHocVien AND c.MaHPKyThuat = d.MaHPKyThuat AND d.NamHoc = @nh AND d.HocKy = @hk ",
                    new object[] { DTO_Account.Instance.UserName, a.NamHoc, a.HocKi });
            }
            if (type == 2)
            {
                result = DAO_DataProvider.Instance.ExecuteQuery(
                    " select d.MaKhoaHoc, d.MaMonHoc, d.MaHPCC, c.Diem " +
                    " from USERPASS a, HocVien b, DiemHocPhanChungChi c, HocPhanChungChi d " +
                    " where a.Username = b.EMail AND a.Username = @usn " +
                    " AND b.MaHocVien = c.MaHocVien AND c.MaHPCC = d.MaHPCC AND d.NamHoc = @nh AND d.HocKy = @hk ",
                    new object[] { DTO_Account.Instance.UserName, a.NamHoc, a.HocKi });
            }
            if (type == 4)
            {
                result = DAO_DataProvider.Instance.ExecuteQuery(
                    " select d.MaLichThiTotNghiep, d.NgayThi, d.PhongThi, c.Diem " +
                    " from USERPASS a, HocVien b, DiemThiTotNghiep c, LichThiTotNghiep d " +
                    " where a.Username = b.EMail AND a.Username = @usn " +
                    " AND b.MaHocVien = c.MaHocVien AND c.MaLichThiTotNghiep = d.MaLichThiTotNghiep ",
                    new object[] { DTO_Account.Instance.UserName});
            }

            return result;
        }

        public DataTable Select_HocVien_LichHoc(DTO_HocVien_XemTTHocTap a, int type = 1) // 1Kythuat 2ChungChi 3ChuyenDe 4ThiTotNghiep
        {
            DataTable result = new DataTable();
            if (type == 1)
            {
                result = DAO_DataProvider.Instance.ExecuteQuery(
                    " select g.MaMonHoc, g.MaHPKyThuat, g.LichHoc, g.Phong " +
                    " from USERPASS a, HocVien b, HoaDon c, ChiTietHoaDon d, ChiTietHoaDonNhomHPKyThuat e, ChiTietKhoaKyThuat f, HocPhanKyThuat g " +
                    " where a.Username = b.EMail AND a.Username = @usn" +
                    " AND b.MaHocVien = c.MaHocVien AND c.MaHoaDon = d.MaHoaDon AND d.MaChiTietHD = e.MaChiTietHDNHPKT " +
                    " AND e.MaChiTietKhoaKyThuat = f.MaChiTietKhoaKyThuat AND g.MaChiTietKhoaKyThuat = f.MaChiTietKhoaKyThuat " +
                    " AND g.NamHoc = @nh AND g.HocKy = @hk ",
                    new object[] { DTO_Account.Instance.UserName, a.NamHoc, a.HocKi });
            }
            if (type == 2)
            {
                result = DAO_DataProvider.Instance.ExecuteQuery(
                    " select f.MaHPCC, f.MaMonHoc, f.MaGiaoVien, f.LichHoc, f.Phong " +
                    " from USERPASS a, HocVien b, HoaDon c, ChiTietHoaDon d, ChiTietHoaDonHPChungChi e, HocPhanChungChi f " +
                    " where a.Username = b.EMail AND a.Username = @username" +
                    " AND b.MaHocVien = c.MaHocVien AND c.MaHoaDon = d.MaHoaDon AND d.MaChiTietHD = e.MaChiTietHDHPCC AND e.MaHPCC = f.MaHPCC " +
                    " AND f.NamHoc = @nh AND f.HocKy = @lh ",
                    new object[] { DTO_Account.Instance.UserName, a.NamHoc, a.HocKi });
            }
            if (type == 3)
            {
                result = DAO_DataProvider.Instance.ExecuteQuery(
                    " select f.MaHPChuyenDe, f.MaChuyenDe, f.MaGiaoVien, f.LichHoc, f.Phong " +
                    " from USERPASS a, HocVien b, HoaDon c, ChiTietHoaDon d, ChiTietHoaDonHPChuyenDe e, HocPhanChuyenDe f " +
                    " where a.Username = b.EMail AND a.Username = @username " +
                    " AND b.MaHocVien = c.MaHocVien AND c.MaHoaDon = d.MaHoaDon AND d.MaChiTietHD = e.MaChiTietHDHPCD AND e.MaHPCD = f.MaHPChuyenDe " +
                    " AND f.NamHoc = @nh AND f.HocKy = @lh ",
                    new object[] { DTO_Account.Instance.UserName, a.NamHoc, a.HocKi });
            }

            return result;
        }
        public DAO_HocVien_XemTTHocTap() { }
    }
}
