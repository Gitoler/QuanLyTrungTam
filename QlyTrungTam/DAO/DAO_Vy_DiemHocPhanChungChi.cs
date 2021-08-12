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
    class DAO_Vy_DiemHocPhanChungChi
    {
        private static DAO_Vy_DiemHocPhanChungChi instance;

        public static DAO_Vy_DiemHocPhanChungChi Instance
        {
            get
            {
                if (instance == null) instance = new DAO_Vy_DiemHocPhanChungChi();
                return instance;
            }
            private set { instance = value; }
        }

        private DAO_Vy_DiemHocPhanChungChi() { }


        public DataTable XemDiemHocPhanChungChi()
        {
            string query = "select * from diemhocphanchungchi";

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            return result;
        }

        public DataTable XemDiemHocPhanChungChiWithID(DTO_Vy_DiemHocPhanChungChi mh)
        {
            string query = "select * from diemhocphanchungchi where madiemhpcc = " + mh.MaDiem.ToString();

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            return result;
        }

        public int ThemDiemHPCC(DTO_Vy_DiemHocPhanChungChi kh)
        {
            string query = "insert into diemhocphanchungchi(diem, mahocvien, mahpcc) values( @diem , @mahv , @mahpcc )";

            int rerult = DAO_DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[] {
                    kh.Diem,
                    kh.MaHocVien,
                    kh.MaHocPhan,
                });

            return rerult;
        }

        public int SuaDiemHPCC(DTO_Vy_DiemHocPhanChungChi kh)
        {
            string query = "update diemhocphanchungchi set diem = @diem , mahocvien = @mahv , mahpcc = @mahp where madiemhpcc = @madiem ";

            int rerult = DAO_DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[] {
                    kh.Diem,
                    kh.MaHocVien,
                    kh.MaHocPhan,
                    kh.MaDiem
                });

            return rerult;
        }
    }
}
