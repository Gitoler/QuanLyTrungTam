using QlyTrungTam.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DAO
{
    class DAO_KhoaChungChi
    {
        private static DAO_KhoaChungChi instance;
        public static DAO_KhoaChungChi Instance
        {
            get
            {
                if (instance == null) instance = new DAO_KhoaChungChi();
                return DAO_KhoaChungChi.instance;
            }
            private set { instance = value; }
        }


        public List<KhoaChungChi> GetKhoaChungChiList()
        {

            List<KhoaChungChi> khoachungchiList = new List<KhoaChungChi>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetKhoaChungChiList");
            foreach (DataRow item in data.Rows)
            {
                KhoaChungChi KhoaChungChi = new KhoaChungChi(item);
                khoachungchiList.Add(KhoaChungChi);
            }

            return khoachungchiList;

        }


        private DAO_KhoaChungChi() { }
    }
}
