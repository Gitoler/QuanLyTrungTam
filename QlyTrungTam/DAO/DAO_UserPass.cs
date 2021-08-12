using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QlyTrungTam.DTO;

namespace QlyTrungTam.DAO
{
    class DAO_UserPass
    {
        private static DAO_UserPass instance;

        public static DAO_UserPass Instance
        {
            get
            {
                if (instance == null) instance = new DAO_UserPass();
                return instance;
            }
            private set { instance = value; }
        }

        private DAO_UserPass() { }

        public string Login(DTO_Account user)
        {
            string query = "select vaitro from userpass where username = '" + user.UserName + "' and pw = '" + user.PassWord + "'";

            DataTable data = DAO_DataProvider.Instance.ExecuteQuery(query);

            string result = "";

            if (data != null)
            {
                if (data.Rows.Count > 0)
                {
                    result = data.Rows[0]["VAITRO"].ToString();

                }
            }

            return result;
        }
    }
}
