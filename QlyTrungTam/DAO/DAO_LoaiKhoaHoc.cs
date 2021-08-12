using QlyTrungTam.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DAO
{
    class DAO_LoaiKhoaHoc
    {
        private static DAO_LoaiKhoaHoc instance;
        public static DAO_LoaiKhoaHoc Instance
        {
            get
            {
                if (instance == null) instance = new DAO_LoaiKhoaHoc();
                return DAO_LoaiKhoaHoc.instance;
            }
            private set { instance = value; }
        }


        public List<LoaiKhoaHoc> GetLoaiKhoaHocList()
        {

            List<LoaiKhoaHoc> loaikhoahocList = new List<LoaiKhoaHoc>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetLoaiKhoaHocList");
            foreach (DataRow item in data.Rows)
            {
                LoaiKhoaHoc LoaiKhoaHoc = new LoaiKhoaHoc(item);
                loaikhoahocList.Add(LoaiKhoaHoc);
            }

            return loaikhoahocList;

        }

        public List<LoaiKhoaHoc> GetLoaiKhoaHocDiemList()
        {

            List<LoaiKhoaHoc> loaikhoahocList = new List<LoaiKhoaHoc>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetLoaiKhoaHocDiemList");
            foreach (DataRow item in data.Rows)
            {
                LoaiKhoaHoc LoaiKhoaHoc = new LoaiKhoaHoc(item);
                loaikhoahocList.Add(LoaiKhoaHoc);
            }

            return loaikhoahocList;

        }


        private DAO_LoaiKhoaHoc() { }
    }
}
