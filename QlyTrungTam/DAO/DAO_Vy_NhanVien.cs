using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QlyTrungTam.DAO
{
    class DAO_Vy_NhanVien
    {
        private static DAO_Vy_NhanVien instance;

        public static DAO_Vy_NhanVien Instance
        {
            get
            {
                if (instance == null) instance = new DAO_Vy_NhanVien();
                return instance;
            }
            private set { instance = value; }
        }

        private DAO_Vy_NhanVien() { }


        public DataTable XemIDNhanVien()
        {
            string query = "select manhanvien from nhanvien";

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            return result;
        }
    }
}
