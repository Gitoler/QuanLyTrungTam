using QlyTrungTam.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DAO
{
    class DAO_HocVien_ThongTinTaiKhoan
    {
        private static DAO_HocVien_ThongTinTaiKhoan instance;
        public static DAO_HocVien_ThongTinTaiKhoan Instance
        {
            get
            {
                if (instance == null) instance = new DAO_HocVien_ThongTinTaiKhoan();
                return instance;
            }
            private set { instance = value; }
        }

        public int Update_HocVien_ThongTinTaiKhoan(DTO_HocVien_ThongTinTaiKhoan tmp)
        {
            int result = 0;

            result = DAO_DataProvider.Instance.ExecuteNonQuery("UPDATE userpass " +
                                                            " SET pw = @p " +
                                                            " WHERE username = @us ", new object[] { tmp.Pw, tmp.Username});
            return result;
        }
        public DataTable Select_HocVien_ThongTinTaiKhoan()
        {
            DataTable result = new DataTable();

            result = DAO_DataProvider.Instance.ExecuteQuery( " select username, pw " +
                                                          " from userpass " +
                                                          " where username = @us ", new object[] {DTO.DTO_Account.Instance.UserName});
            return result;
        }
    }
}
