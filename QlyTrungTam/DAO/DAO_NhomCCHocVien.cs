using QlyTrungTam.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DAO
{
    class DAO_NhomCCHocVien
    {
        private static DAO_NhomCCHocVien instance;
        public static DAO_NhomCCHocVien Instance
        {
            get
            {
                if (instance == null) instance = new DAO_NhomCCHocVien();
                return DAO_NhomCCHocVien.instance;
            }
            private set { instance = value; }
        }


        public List<NhomCCHocVien> GetNhomCCHocVienList()
        {

            List<NhomCCHocVien> NhomCCHocVienList = new List<NhomCCHocVien>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetNhomCCHocVienList");
            foreach (DataRow item in data.Rows)
            {
                NhomCCHocVien NhomCCHocVien = new NhomCCHocVien(item);
                NhomCCHocVienList.Add(NhomCCHocVien);
            }

            return NhomCCHocVienList;

        }

        public List<NhomCCHocVien> SearchNhomCCHocVienListByName(string hocvienname)
        {
            string query = string.Format("select hv.MaHocVien, hv.TenHocVien, kh.MaKhoaHoc, kh.TenKhoaHoc, kh.NgayBatDau, nhpkt.TenNhomHocPhan, cthdnky.YCCapChungChi, cthdnky.MaChiTietHDNHPKT from KhoaHoc kh, KhoaDaoTaoKyThuat kdtkt, NhomHPKyThuat nhpkt, HocVien hv, HoaDon hd, ChiTietHoaDon cthd, ChiTietHoaDonNhomHPKyThuat cthdnky, ChiTietKhoaKyThuat ctkkt where cthdnky.MaChiTietKhoaKyThuat = ctkkt.MaChiTietKhoaKyThuat and cthdnky.MaChiTietHDNHPKT = cthd.MaChiTietHD and cthd.MaHoaDon = hd.MaHoaDon and hd.MaHocVien = hv.MaHocVien and nhpkt.MaNhomHocPhan = ctkkt.MaNhomHocPhan and hd.MaKhoaHoc = kdtkt.MaKhoaHoc and kdtkt.MaKhoaHoc = kh.MaKhoaHoc and hv.tenhocvien like N'%{0}%'", hocvienname);
            List<NhomCCHocVien> NhomCCHocVienList = new List<NhomCCHocVien>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                NhomCCHocVien NhomCCHocVien = new NhomCCHocVien(item);
                NhomCCHocVienList.Add(NhomCCHocVien);
            }

            return NhomCCHocVienList;

        }

        public bool UpdateNhomCCHocVien(int chitiethoadon_id, int tinhtrang)
        {
            int result;
            try
            {
                result = DAO_DataProvider.Instance.ExecuteNonQuery("UpdateNhomCCHocVien @macthoadon , @yccapchungchi ", new object[] { chitiethoadon_id, tinhtrang });
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        private DAO_NhomCCHocVien() { }
    }
}
