using QlyTrungTam.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DAO
{
    class DAO_HocVienHocPhanChungChi
    {
        private static DAO_HocVienHocPhanChungChi instance;
        public static DAO_HocVienHocPhanChungChi Instance
        {
            get
            {
                if (instance == null) instance = new DAO_HocVienHocPhanChungChi();
                return DAO_HocVienHocPhanChungChi.instance;
            }
            private set { instance = value; }
        }



        public List<HocVienHocPhanChungChi> GetHocVienHocPhanChungChiListByIDHocVien(int idkhoahoc, int idhocvien)
        {

            List<HocVienHocPhanChungChi> hocvienhocphanchungchiList = new List<HocVienHocPhanChungChi>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetHocVienHocPhanChungChiListByIDHocVien @makhoahoc , @mahocvien", new object[] { idkhoahoc, idhocvien });
            foreach (DataRow item in data.Rows)
            {
                HocVienHocPhanChungChi GiaoVienHocPhanChungChi = new HocVienHocPhanChungChi(item);
                hocvienhocphanchungchiList.Add(GiaoVienHocPhanChungChi);
            }

            return hocvienhocphanchungchiList;

        }

        private DAO_HocVienHocPhanChungChi() { }
    }
}
