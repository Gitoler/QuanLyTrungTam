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
    class DAO_GiaoVien_DiemThiTotNghiep
    {
        private static DAO_GiaoVien_DiemThiTotNghiep instance;

        public static DAO_GiaoVien_DiemThiTotNghiep Instance
        {
            get
            {
                if (instance == null) instance = new DAO_GiaoVien_DiemThiTotNghiep();
                return instance;
            }
            private set { instance = value; }
        }

        private DAO_GiaoVien_DiemThiTotNghiep() { }

        public DataTable XemDTTN()
        {
            string query = "select * from DiemThiTotNghiep";

            DataTable result = DAO_DBConnect.Instance.ExecuteQuery(query);
            return result;
        }
        public DataTable XemDTTN_WithID(int hp)
        {
            string query = "select * from diemthitotnghiep where madiemthitotnghiep = @hp";

            DataTable result = DAO_DBConnect.Instance.ExecuteQuery(query, new object[] { hp });

            return result;
        }
        public DataTable XemHV_WithID(int hp)
        {
            string query = "select * from hocvien where mahocvien = @hp";

            DataTable result = DAO_DBConnect.Instance.ExecuteQuery(query, new object[] { hp });

            return result;
        }
        public DataTable XemGV_WithID(int hp)
        {
            string query = "select * from GiaoVien where magiaovien = @hp";

            DataTable result = DAO_DBConnect.Instance.ExecuteQuery(query, new object[] { hp });

            return result;
        }
        public int ThemDiemTN(DTO_DiemThiTotNghiep diem)
        {
            string query = "insert into diemthitotnghiep(malichthitotnghiep, diem, mahocvien, magiaovien) values( @malich , @diem , @mahocvien , @magv )";

            int rerult = DAO_DBConnect.Instance.ExecuteNonQuery(
                query,
                new object[] {
                    diem.MaLichThiTotNghiep,
                   diem.Diem,
                   diem.MaHocVien,
                   diem.MaGiaoVien,
                }); ;

            return rerult;
        }
         public DataTable SelectTN()
        {
            string query = "select magiaovien from giaovien";

            DataTable result = DAO_DBConnect.Instance.ExecuteQuery(query);

            return result;
        }
        public DataTable SelectLichThi()
        {
            string query = "select malichthitotnghiep from lichthitotnghiep";

            DataTable result = DAO_DBConnect.Instance.ExecuteQuery(query);

            return result;
        }
        public int CapNhatDiemThiTN(DTO_DiemThiTotNghiep diem)
        {
            string query = "update diemthitotnghiep set diem = @diem  where madiemthitotnghiep = @madiem ";

            int rerult = DAO_DBConnect.Instance.ExecuteNonQuery(
                query,
                new object[] {
                    diem.Diem,
                    diem.MaDiemThiTotNghiep,  
                });

            return rerult;
        }
    }
}
