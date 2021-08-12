using QlyTrungTam.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DAO
{
    class DAO_HocVienHocPhanKyThuat
    {
        private static DAO_HocVienHocPhanKyThuat instance;
        public static DAO_HocVienHocPhanKyThuat Instance
        {
            get
            {
                if (instance == null) instance = new DAO_HocVienHocPhanKyThuat();
                return DAO_HocVienHocPhanKyThuat.instance;
            }
            private set { instance = value; }
        }



        public List<HocVienHocPhanKyThuat> GetHocVienHocPhanKyThuatListByIDHocVien(int idkhoahoc, int idhocvien)
        {

            List<HocVienHocPhanKyThuat> hocvienkythuatList = new List<HocVienHocPhanKyThuat>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetHocVienHocPhanKyThuatListByIDHocVien @makhoahoc , @mahocvien", new object[] { idkhoahoc, idhocvien });
            foreach (DataRow item in data.Rows)
            {
                HocVienHocPhanKyThuat GiaoVienHocPhanChungChi = new HocVienHocPhanKyThuat(item);
                hocvienkythuatList.Add(GiaoVienHocPhanChungChi);
            }

            return hocvienkythuatList;

        }

        private DAO_HocVienHocPhanKyThuat() { }
    }
}
