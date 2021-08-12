using QlyTrungTam.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DAO
{
    class DAO_GiaoVienHocPhanChungChi
    {
        private static DAO_GiaoVienHocPhanChungChi instance;
        public static DAO_GiaoVienHocPhanChungChi Instance
        {
            get
            {
                if (instance == null) instance = new DAO_GiaoVienHocPhanChungChi();
                return DAO_GiaoVienHocPhanChungChi.instance;
            }
            private set { instance = value; }
        }


        public List<GiaoVienHocPhanChungChi> GetGiaoVienHocPhanChungChiList()
        {

            List<GiaoVienHocPhanChungChi>giaovienhocphanchungchiList = new List<GiaoVienHocPhanChungChi>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetGiaoVienHocPhanChungChiList");
            foreach (DataRow item in data.Rows)
            {
                GiaoVienHocPhanChungChi GiaoVienHocPhanChungChi = new GiaoVienHocPhanChungChi(item);
                giaovienhocphanchungchiList.Add(GiaoVienHocPhanChungChi);
            }

            return giaovienhocphanchungchiList;

        }

        public List<GiaoVienHocPhanChungChi> GetGiaoVienHocPhanChungChiListByIDGiaoVien(int idgiaovien)
        {

            List<GiaoVienHocPhanChungChi> giaovienhocphanchungchiList = new List<GiaoVienHocPhanChungChi>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetGiaoVienHocPhanChungChiListByIDGiaoVien @magiaovien", new object[] { idgiaovien});
            foreach (DataRow item in data.Rows)
            {
                GiaoVienHocPhanChungChi GiaoVienHocPhanChungChi = new GiaoVienHocPhanChungChi(item);
                giaovienhocphanchungchiList.Add(GiaoVienHocPhanChungChi);
            }

            return giaovienhocphanchungchiList;

        }

        public List<GiaoVienHocPhanChungChi> GetGiaoVienHocPhanChungChiListByIDKhoaHoc(int idkhoahoc, int idgiaovien)
        {

            List<GiaoVienHocPhanChungChi> giaovienhocphanchungchiList = new List<GiaoVienHocPhanChungChi>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetGiaoVienHocPhanChungChiListByIDKhoaHoc @makhoahoc , @magiaovien", new object[] { idkhoahoc, idgiaovien});
            foreach (DataRow item in data.Rows)
            {
                GiaoVienHocPhanChungChi GiaoVienHocPhanChungChi = new GiaoVienHocPhanChungChi(item);
                giaovienhocphanchungchiList.Add(GiaoVienHocPhanChungChi);
            }

            return giaovienhocphanchungchiList;

        }

        public List<GiaoVienHocPhanChungChi> GetGiaoVienHocPhanChungChiListByIDHPCC(int idkhoahoc,int idhpcc, int idgiaovien)
        {

            List<GiaoVienHocPhanChungChi> giaovienhocphanchungchiList = new List<GiaoVienHocPhanChungChi>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetGiaoVienHocPhanChungChiListByIDHPCC @makhoahoc , @mahpcc , @magiaovien", new object[] { idkhoahoc, idhpcc, idgiaovien });
            foreach (DataRow item in data.Rows)
            {
                GiaoVienHocPhanChungChi GiaoVienHocPhanChungChi = new GiaoVienHocPhanChungChi(item);
                giaovienhocphanchungchiList.Add(GiaoVienHocPhanChungChi);
            }

            return giaovienhocphanchungchiList;

        }

        public List<GiaoVienHocPhanChungChi> GetGiaoVienHocPhanChungChiListByIDHocVien(int idkhoahoc, int idhpcc, int idgiaovien, int idhocvien)
        {

            List<GiaoVienHocPhanChungChi> giaovienhocphanchungchiList = new List<GiaoVienHocPhanChungChi>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetGiaoVienHocPhanChungChiListByIDHocVien @makhoahoc , @mahpcc , @magiaovien , @mahocvien", new object[] { idkhoahoc, idhpcc, idgiaovien, idhocvien });
            foreach (DataRow item in data.Rows)
            {
                GiaoVienHocPhanChungChi GiaoVienHocPhanChungChi = new GiaoVienHocPhanChungChi(item);
                giaovienhocphanchungchiList.Add(GiaoVienHocPhanChungChi);
            }

            return giaovienhocphanchungchiList;

        }
        public List<GiaoVienHocPhanChungChi> SearchGiaoVienHocPhanChungChiListByName(string hocvienname)
        {

            List<GiaoVienHocPhanChungChi> giaovienhocphanchungchiList = new List<GiaoVienHocPhanChungChi>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("SearchGiaoVienHocPhanChungChiListByName @hocvienname", new object[] { hocvienname});
            foreach (DataRow item in data.Rows)
            {
                GiaoVienHocPhanChungChi GiaoVienHocPhanChungChi = new GiaoVienHocPhanChungChi(item);
                giaovienhocphanchungchiList.Add(GiaoVienHocPhanChungChi);
            }

            return giaovienhocphanchungchiList;

        }

        public bool UpdateGiaoVienHocPhanChungChi(int id, int diem)
        {
            int result;
            try
            {
                result = DAO_DataProvider.Instance.ExecuteNonQuery("UpdateGiaoVienHocPhanChungChi @id , @diem ", new object[] { id, diem });
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        private DAO_GiaoVienHocPhanChungChi() { }
    }
}
