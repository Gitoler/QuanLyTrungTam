using QlyTrungTam.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DAO
{
    class DAO_ChiTietKhoaKyThuat
    {
        private static DAO_ChiTietKhoaKyThuat instance;
        public static DAO_ChiTietKhoaKyThuat Instance
        {
            get
            {
                if (instance == null) instance = new DAO_ChiTietKhoaKyThuat();
                return DAO_ChiTietKhoaKyThuat.instance;
            }
            private set { instance = value; }
        }


        public List<ChiTietKhoaKyThuat> GetChiTietKhoaKyThuatList()
        {

            List<ChiTietKhoaKyThuat> chitietkhoakythuatList = new List<ChiTietKhoaKyThuat>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetChiTietKhoaKyThuatList");
            foreach (DataRow item in data.Rows)
            {
                ChiTietKhoaKyThuat ChiTietKhoaKyThuat = new ChiTietKhoaKyThuat(item);
                chitietkhoakythuatList.Add(ChiTietKhoaKyThuat);
            }

            return chitietkhoakythuatList;

        }

        public List<ChiTietKhoaKyThuat> GetChiTietKhoaKyThuatListByIDKhoaHoc( int idkhoahoc)
        {

            List<ChiTietKhoaKyThuat> chitietkhoakythuatList = new List<ChiTietKhoaKyThuat>();
            DataTable data = DAO_DataProvider.Instance.ExecuteQuery("USP_GetChiTietKhoaKyThuatListByIDKhoaHoc " + idkhoahoc);
            foreach (DataRow item in data.Rows)
            {
                ChiTietKhoaKyThuat ChiTietKhoaKyThuat = new ChiTietKhoaKyThuat(item);
                chitietkhoakythuatList.Add(ChiTietKhoaKyThuat);
            }

            return chitietkhoakythuatList;

        }


        private DAO_ChiTietKhoaKyThuat() { }
    }
}
