using QlyTrungTam.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DAO
{
    class DAO_GiaoVienHocPhanKyThuat
    {
        private static DAO_GiaoVienHocPhanKyThuat instance;
        public static DAO_GiaoVienHocPhanKyThuat Instance
        {
            get
            {
                if (instance == null) instance = new DAO_GiaoVienHocPhanKyThuat();
                return DAO_GiaoVienHocPhanKyThuat.instance;
            }
            private set { instance = value; }
        }


        public List<GiaoVienHocPhanKyThuat> GetGiaoVienHocPhanKyThuatList()
        {

            List<GiaoVienHocPhanKyThuat> giaovienhocphankythuatList = new List<GiaoVienHocPhanKyThuat>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetGiaoVienHocPhanKyThuatList");
            foreach (DataRow item in data.Rows)
            {
                GiaoVienHocPhanKyThuat GiaoVienHocPhanKyThuat = new GiaoVienHocPhanKyThuat(item);
                giaovienhocphankythuatList.Add(GiaoVienHocPhanKyThuat);
            }

            return giaovienhocphankythuatList;

        }

        public List<GiaoVienHocPhanKyThuat> GetGiaoVienHocPhanKyThuatListByIDGiaoVien(int idgiaovien)
        {

            List<GiaoVienHocPhanKyThuat> giaovienhocphankythuatList = new List<GiaoVienHocPhanKyThuat>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetGiaoVienHocPhanKyThuatListByIDGiaoVien @magiaovien", new object[] { idgiaovien });
            foreach (DataRow item in data.Rows)
            {
                GiaoVienHocPhanKyThuat GiaoVienHocPhanKyThuat = new GiaoVienHocPhanKyThuat(item);
                giaovienhocphankythuatList.Add(GiaoVienHocPhanKyThuat);
            }

            return giaovienhocphankythuatList;

        }

        public List<GiaoVienHocPhanKyThuat> GetGiaoVienHocPhanKyThuatListByIDKhoaHoc(int idkhoahoc, int idgiaovien)
        {

            List<GiaoVienHocPhanKyThuat> giaovienhocphankythuatList = new List<GiaoVienHocPhanKyThuat>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetGiaoVienHocPhanKyThuatListByIDKhoaHoc @makhoahoc , @magiaovien", new object[] { idkhoahoc, idgiaovien });
            foreach (DataRow item in data.Rows)
            {
                GiaoVienHocPhanKyThuat GiaoVienHocPhanKyThuat = new GiaoVienHocPhanKyThuat(item);
                giaovienhocphankythuatList.Add(GiaoVienHocPhanKyThuat);
            }

            return giaovienhocphankythuatList;

        }

        public List<GiaoVienHocPhanKyThuat> GetGiaoVienHocPhanKyThuatListByIDHPKT(int idkhoahoc, int idhpkt, int idgiaovien)
        {

            List<GiaoVienHocPhanKyThuat> giaovienhocphankythuatList = new List<GiaoVienHocPhanKyThuat>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetGiaoVienHocPhanKyThuatListByIDHPKT @makhoahoc , @mahpkt , @magiaovien", new object[] { idkhoahoc, idhpkt, idgiaovien });
            foreach (DataRow item in data.Rows)
            {
                GiaoVienHocPhanKyThuat GiaoVienHocPhanKyThuat = new GiaoVienHocPhanKyThuat(item);
                giaovienhocphankythuatList.Add(GiaoVienHocPhanKyThuat);
            }

            return giaovienhocphankythuatList;

        }

        public List<GiaoVienHocPhanKyThuat> GetGiaoVienHocPhanKyThuatListByLanThi(int idkhoahoc, int idhpkt, int lanthi, int idgiaovien)
        {

            List<GiaoVienHocPhanKyThuat> giaovienhocphankythuatList = new List<GiaoVienHocPhanKyThuat>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetGiaoVienHocPhanKyThuatListByLanThi @makhoahoc , @mahpkt , @lanthi , @magiaovien", new object[] { idkhoahoc, idhpkt,lanthi, idgiaovien });
            foreach (DataRow item in data.Rows)
            {
                GiaoVienHocPhanKyThuat GiaoVienHocPhanKyThuat = new GiaoVienHocPhanKyThuat(item);
                giaovienhocphankythuatList.Add(GiaoVienHocPhanKyThuat);
            }

            return giaovienhocphankythuatList;

        }

        public List<GiaoVienHocPhanKyThuat> GetGiaoVienHocPhanKyThuatListByIDHocVien(int idkhoahoc, int idhpkt,int lanthi, int idgiaovien, int idhocvien)
        {

            List<GiaoVienHocPhanKyThuat> giaovienhocphankythuatList = new List<GiaoVienHocPhanKyThuat>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetGiaoVienHocPhanKyThuatListByIDHocVien @makhoahoc , @mahpkt , @lanthi , @magiaovien , @mahocvien", new object[] { idkhoahoc, idhpkt, lanthi, idgiaovien, idhocvien });
            foreach (DataRow item in data.Rows)
            {
                GiaoVienHocPhanKyThuat GiaoVienHocPhanKyThuat = new GiaoVienHocPhanKyThuat(item);
                giaovienhocphankythuatList.Add(GiaoVienHocPhanKyThuat);
            }

            return giaovienhocphankythuatList;

        }
        public List<GiaoVienHocPhanKyThuat> SearchGiaoVienHocPhanKyThuatListByName(string hocvienname)
        {

            List<GiaoVienHocPhanKyThuat> giaovienhocphankythuatList = new List<GiaoVienHocPhanKyThuat>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("SearchGiaoVienHocPhanKyThuatListByName @hocvienname", new object[] { hocvienname });
            foreach (DataRow item in data.Rows)
            {
                GiaoVienHocPhanKyThuat GiaoVienHocPhanKyThuat = new GiaoVienHocPhanKyThuat(item);
                giaovienhocphankythuatList.Add(GiaoVienHocPhanKyThuat);
            }

            return giaovienhocphankythuatList;

        }

        public bool UpdateGiaoVienHocPhanKyThuat(int id, int diem)
        {
            int result;
            try
            {
                result = DAO_DataProvider.Instance.ExecuteNonQuery("UpdateGiaoVienHocPhanKyThuat @id , @diem ", new object[] { id, diem });
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        private DAO_GiaoVienHocPhanKyThuat() { }
    }
}
