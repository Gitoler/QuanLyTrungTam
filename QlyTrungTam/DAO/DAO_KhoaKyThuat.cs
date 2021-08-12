using QlyTrungTam.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DAO
{
    class DAO_KhoaKyThuat
    {
        private static DAO_KhoaKyThuat instance;
        public static DAO_KhoaKyThuat Instance
        {
            get
            {
                if (instance == null) instance = new DAO_KhoaKyThuat();
                return DAO_KhoaKyThuat.instance;
            }
            private set { instance = value; }
        }


        public List<KhoaKyThuat> GetKhoaKyThuatList()
        {

            List<KhoaKyThuat> khoakythuatList = new List<KhoaKyThuat>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetKhoaKyThuatList");
            foreach (DataRow item in data.Rows)
            {
                KhoaKyThuat KhoaKyThuat = new KhoaKyThuat(item);
                khoakythuatList.Add(KhoaKyThuat);
            }

            return khoakythuatList;

        }

        public List<KhoaKyThuat> GetKhoaKyThuatListByIDLoai(int idloaikythuat)
        {

            List<KhoaKyThuat> khoakythuatList = new List<KhoaKyThuat>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetKhoaKyThuatListByLoai(" + idloaikythuat +")");
            foreach (DataRow item in data.Rows)
            {
                KhoaKyThuat KhoaKyThuat = new KhoaKyThuat(item);
                khoakythuatList.Add(KhoaKyThuat);
            }

            return khoakythuatList;

        }

        private DAO_KhoaKyThuat() { }
    }
}
