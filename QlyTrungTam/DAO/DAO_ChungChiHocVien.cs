using QlyTrungTam.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DAO
{
    class DAO_ChungChiHocVien
    {
        private static DAO_ChungChiHocVien instance;
        public static DAO_ChungChiHocVien Instance
        {
            get
            {
                if (instance == null) instance = new DAO_ChungChiHocVien();
                return DAO_ChungChiHocVien.instance;
            }
            private set { instance = value; }
        }


        public List<ChungChiHocVien> GetChungChiHocVienList()
        {

            List<ChungChiHocVien> ChungChiHocVienList = new List<ChungChiHocVien>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetChungChiHocVienList");
            foreach (DataRow item in data.Rows)
            {
                ChungChiHocVien ChungChiHocVien = new ChungChiHocVien(item);
                ChungChiHocVienList.Add(ChungChiHocVien);
            }

            return ChungChiHocVienList;

        }

        public List<ChungChiHocVien> SearchChungChiHocVienListByName(string hocvienname)
        {

            List<ChungChiHocVien> ChungChiHocVienList = new List<ChungChiHocVien>();
            string query = string.Format("select hv.MaHocVien, hv.TenHocVien, kh.MaKhoaHoc, kh.TenKhoaHoc, kh.NgayBatDau, ncc.TenNhomChungChi, hdcc.YCCapChungChi, hdcc.MaHoaDon from HocVien hv,HoaDon hd,  HoaDonChungChi hdcc, KhoaHoc kh, KhoaDaoTaoChungChi kdtcc, NhomChungChi ncc where hv.MaHocVien = hd.MaHocVien and hd.MaHoaDon = hdcc.MaHoaDon and hd.MaKhoaHoc = kh.MaKhoaHoc and hd.TinhTrang = 1 and kh.MaKhoaHoc = kdtcc.MaKhoaHoc and ncc.MaNhomChungChi = kdtcc.MaNhomChungChi and hv.tenhocvien like N'%{0}%'", hocvienname);
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ChungChiHocVien ChungChiHocVien = new ChungChiHocVien(item);
                ChungChiHocVienList.Add(ChungChiHocVien);
            }

            return ChungChiHocVienList;

        }

        public bool InsertChungChiHocVien(int tinhtrang)
        {
            int result = DAO_DataProvider.Instance.ExecuteNonQuery("InsertChungChiHocVien @yccapchungchi ", new object[] { tinhtrang });
            return result > 0;
        }

        public bool DeleteChungChiHocVien(int id)
        {
            int result;
            try
            {
                result = DAO_DataProvider.Instance.ExecuteNonQuery("DeleteChungChiHocVien @id ", new object[] { id });
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateChungChiHocVien(int hoadon_id,int tinhtrang)
        {
            int result;
            try
            {
                result = DAO_DataProvider.Instance.ExecuteNonQuery("UpdateChungChiHocVien @mahoadon , @yccapchungchi ", new object[] {hoadon_id, tinhtrang });
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        private DAO_ChungChiHocVien() { }
    }
}
