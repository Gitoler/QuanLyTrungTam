using QlyTrungTam.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DAO
{
    class DAO_KhoaHoc
    {
        private static DAO_KhoaHoc instance;
        public static DAO_KhoaHoc Instance
        {
            get
            {
                if (instance == null) instance = new DAO_KhoaHoc();
                return DAO_KhoaHoc.instance;
            }
            private set { instance = value; }
        }


        public List<KhoaHoc> GetKhoaHocListByIDHocVien(int idhocvien)
        {

            List<KhoaHoc> khoahocList = new List<KhoaHoc>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetKhoaHocListByIDHocVien @mahocvien", new object[] { idhocvien });
            foreach (DataRow item in data.Rows)
            {
                KhoaHoc KhoaHoc = new KhoaHoc(item);
                khoahocList.Add(KhoaHoc);
            }

            return khoahocList;

        }
        public List<KhoaHoc> GetKhoaHocListByIDLoaiHocVien(int id, int idhocvien)
        {

            List<KhoaHoc> khoahocList = new List<KhoaHoc>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetKhoaHocListByIDLoaiHocVien @maloaikhoahoc , @mahocvien", new object[] {id,  idhocvien });
            foreach (DataRow item in data.Rows)
            {
                KhoaHoc KhoaHoc = new KhoaHoc(item);
                khoahocList.Add(KhoaHoc);
            }

            return khoahocList;

        }

        public List<KhoaHoc> GetKhoaHocListByIDLoai(int idloaikhoahoc)
        {

            List<KhoaHoc> khoahocList = new List<KhoaHoc>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetKhoaHocListByLoai " + idloaikhoahoc);
            foreach (DataRow item in data.Rows)
            {
                KhoaHoc KhoaHoc = new KhoaHoc(item);
                khoahocList.Add(KhoaHoc);
            }

            return khoahocList;

        }

        public List<KhoaHoc> GetKhoaHocChungChiListByIDGiaoVien(int idgiaovien)
        {

            List<KhoaHoc> khoahocList = new List<KhoaHoc>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetKhoaHocChungChiListByIDGiaoVien " + idgiaovien);
            foreach (DataRow item in data.Rows)
            {
                KhoaHoc KhoaHoc = new KhoaHoc(item);
                khoahocList.Add(KhoaHoc);
            }

            return khoahocList;

        }

        public List<KhoaHoc> GetKhoaHocKyThuatListByIDGiaoVien(int idgiaovien)
        {

            List<KhoaHoc> khoahocList = new List<KhoaHoc>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetKhoaHocKyThuatListByIDGiaoVien " + idgiaovien);
            foreach (DataRow item in data.Rows)
            {
                KhoaHoc KhoaHoc = new KhoaHoc(item);
                khoahocList.Add(KhoaHoc);
            }

            return khoahocList;

        }

        public List<KhoaHoc> GetKhoaHocTotNghiep()
        {

            List<KhoaHoc> khoahocList = new List<KhoaHoc>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetKhoaHocTotNghiep");
            foreach (DataRow item in data.Rows)
            {
                KhoaHoc KhoaHoc = new KhoaHoc(item);
                khoahocList.Add(KhoaHoc);
            }

            return khoahocList;

        }

        private DAO_KhoaHoc() { }
    }
}
