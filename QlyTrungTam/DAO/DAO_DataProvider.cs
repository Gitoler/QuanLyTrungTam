using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QlyTrungTam.DAO
{
    class DAO_DataProvider
    {
        private static DAO_DataProvider instance;

        public static DAO_DataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DAO_DataProvider();
                return instance;
            }
            private set { instance = value; }
        }

        private DAO_DataProvider() { }


        private string strCon = @"Data Source=DESKTOP-OP4TATH\SQLEXPRESS;Initial Catalog=PTTK;Integrated Security=True";

        public DataTable ExecuteQuery(string query, object[] param = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection conn = new SqlConnection(strCon))
            {
                conn.Open();
                SqlCommand com = new SqlCommand(query, conn);

                if (param != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            com.Parameters.AddWithValue(item, param[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(com);
                adapter.Fill(data);

                conn.Close();

                return data;
            }
        }

        public int ExecuteNonQuery(string query, object[] param = null)
        {
            int data = 0;
            using (SqlConnection conn = new SqlConnection(strCon))
            {
                conn.Open();
                SqlCommand com = new SqlCommand(query, conn);

                if (param != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            com.Parameters.AddWithValue(item, param[i]);
                            i++;
                        }
                    }
                }

                data = com.ExecuteNonQuery();

                conn.Close();

                return data;
            }
        }
    }
}
