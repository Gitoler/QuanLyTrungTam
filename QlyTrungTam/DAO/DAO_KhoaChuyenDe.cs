using QlyTrungTam.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DAO
{
    class DAO_KhoaChuyenDe
    {
        private static DAO_KhoaChuyenDe instance;
        public static DAO_KhoaChuyenDe Instance
        {
            get
            {
                if (instance == null) instance = new DAO_KhoaChuyenDe();
                return DAO_KhoaChuyenDe.instance;
            }
            private set { instance = value; }
        }


        public List<KhoaChuyenDe> GetKhoaChuyenDeList()
        {

            List<KhoaChuyenDe> khoachuyendeList = new List<KhoaChuyenDe>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetKhoaChuyenDeList");
            foreach (DataRow item in data.Rows)
            {
                KhoaChuyenDe KhoaChuyenDe = new KhoaChuyenDe(item);
                khoachuyendeList.Add(KhoaChuyenDe);
            }

            return khoachuyendeList;

        }


        private DAO_KhoaChuyenDe() { }
    }
}
