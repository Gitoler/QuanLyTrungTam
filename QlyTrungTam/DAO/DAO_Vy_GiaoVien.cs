using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace QlyTrungTam.DAO
{
    class DAO_Vy_GiaoVien
    {
        private static DAO_Vy_GiaoVien instance;

        public static DAO_Vy_GiaoVien Instance
        {
            get
            {
                if (instance == null) instance = new DAO_Vy_GiaoVien();
                return instance;
            }
            private set { instance = value; }
        }
        private DAO_Vy_GiaoVien() { }

        public DataTable XemGiaoVien()
        {
            string query = "select * from giaovien";

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            return result;
        }
    }
}
