using QlyTrungTam.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QlyTrungTam.DAO
{
    class DAO_HocVien_ThongTinCaNhan
    {
        private static DAO_HocVien_ThongTinCaNhan instance;
        public static DAO_HocVien_ThongTinCaNhan Instance
        {
            get
            {
                if (instance == null) instance = new DAO_HocVien_ThongTinCaNhan();
                return instance;
            }
            private set { instance = value; }
        }

        public int Update_HocVien_ThongTinCaNhan(DTO_HocVien_ThongTinCaNhan tmp)
        {
            int result = 0;

            result = DAO_DataProvider.Instance.ExecuteNonQuery("UPDATE HOCVIEN " +
                                                            " SET TenHocVien = @thv , DiaChi = @dc , SDT = @sdt " +
                                                            " WHERE MaHocVien = @mhv ", new object[] { tmp.TenHV, tmp.DiaChi, tmp.SDT, tmp.MaHV });
            return result;
        }
        public DataTable Select_HocVien_ThongTinCaNhan()
        {
            DataTable result = new DataTable();

            result = DAO_DataProvider.Instance.ExecuteQuery(   " Select * " +
                                                            " FROM HOCVIEN " +
                                                            " WHERE EMail = '" + DTO_Account.Instance.UserName + "'");
            return result;
        }

        private DAO_HocVien_ThongTinCaNhan() { }
    }
}
