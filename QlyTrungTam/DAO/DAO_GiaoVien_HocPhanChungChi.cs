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
    class DAO_GiaoVien_HocPhanChungChi
    {
        private static DAO_GiaoVien_HocPhanChungChi instance;

        public static DAO_GiaoVien_HocPhanChungChi Instance
        {
            get
            {
                if (instance == null) instance = new DAO_GiaoVien_HocPhanChungChi();
                return instance;
            }
            private set { instance = value; }
        }

        private DAO_GiaoVien_HocPhanChungChi() { }


        public DataTable XemIDHPCC()
        {
            string query = "select mahpcc from hocphanchungchi";

            DataTable result = DAO_DBConnect.Instance.ExecuteQuery(query);

            return result;
        }

        public DataTable XemHPCC()
        {
            string query = "select DCC.MaDiemHPCC, CC.MaHPCC, KH.TenKhoaHoc, MH.TenMonHoc , CC.NamHoc , CC.HocKy , CC.LichHoc , GV.TenGiaoVien,HV.MaHocVien, HV.TenHocVien ,DCC.Diem from (((( HocVien HV join DiemHocPhanChungChi DCC on HV.MaHocVien = DCC.MaHocVien ) join HocPhanChungChi CC on CC.MaHPCC = DCC.MaHPCC) join GiaoVien GV on GV.MaGiaoVien = CC.MaGiaoVien) join MonHoc MH on MH.MaMonHoc = CC.MaMonHoc) join KhoaHoc KH on KH.MaKhoaHoc = CC.MaKhoaHoc";

            DataTable result = DAO_DBConnect.Instance.ExecuteQuery(query);
            return result;
        }
       

        public DataTable XemHPCC_WithID(int hp)
        {
            string query = "select * from hocphanchungchi where mahpcc = @hp";

            DataTable result = DAO_DBConnect.Instance.ExecuteQuery(query, new object[] { hp});

            return result;
        }
      
        public DataTable XemDiemHPCC_WithID(int hp)
        {
            string query = "select * from DiemHocPhanChungChi where madiemhpcc = @hp";

            DataTable result = DAO_DBConnect.Instance.ExecuteQuery(query, new object[] { hp});

            return result;
        }
       
        public DataTable XemMonHoc_WithID(int hp)
        {
            string query = "select * from monhoc where mamonhoc = @hp";

            DataTable result = DAO_DBConnect.Instance.ExecuteQuery(query, new object[] { hp });

            return result;
        }
        public DataTable XemKhoaHoc_WithID(int hp)
        {
            string query = "select * from khoahoc where makhoahoc = @hp";

            DataTable result = DAO_DBConnect.Instance.ExecuteQuery(query, new object[] { hp });

            return result;
        }

        public DataTable XemGiaoVien_WithID(int hp)
        {
            string query = "select * from GiaoVien where magiaovien = @hp";

            DataTable result = DAO_DBConnect.Instance.ExecuteQuery(query, new object[] { hp });

            return result;
        }
        public int TimMaHV_QuaMaDHPCC(int hp)
        {
            string query = "select * from DiemHocPhanChungChi where madiemhpcc = @hp";
            DataTable result = DAO_DBConnect.Instance.ExecuteQuery(query, new object[] { hp });
            int mahocvien = Convert.ToInt32(result.Rows[0]["MaHocVien"].ToString());
            return mahocvien;
        }
        public DataTable XemHocVien_WithID(int hp)
        {
            string query = "select * from DiemHocPhanChungChi where madiemhpcc = @hp";
            DataTable result = DAO_DBConnect.Instance.ExecuteQuery(query, new object[] { hp });
            int mahocvien = Convert.ToInt32(result.Rows[0]["MaHocVien"].ToString());
           
            string query2 = "select * from HocVien where mahocvien = @mahocvien";
            DataTable result2 = DAO_DBConnect.Instance.ExecuteQuery(query2, new object[] { mahocvien });

            return result2;
        }

        public int ThemDiem(DTO_DiemHocPhanChungChi diem)
        {
            string query = "insert into diemhocphanchungchi(diem, mahocvien, mahpcc) values( @diem , @mahocvien , @mahpcc )";

            int rerult = DAO_DBConnect.Instance.ExecuteNonQuery(
                query,
                new object[] {
                   diem.Diem,
                   diem.MaHocVien,
                   diem.MaHPCC,
                }); ;

            return rerult;
        }
       
        public int ThemHPCC(DTO_HocPhanChungChi hp)
        {
            string query = "insert into hocphanchungchi( namhoc, hocky, lichhoc, phong, mamonhoc, magiaovien, makhoahoc) values(  , @namhoc , @hocky , @lichhoc , @phong , @mamonhoc , @magiaovien , @makhoahoc )";

            int rerult = DAO_DBConnect.Instance.ExecuteNonQuery(
                query,
                new object[] {
                   hp.NamHoc,
                   hp.HocKy,
                   hp.LichHoc,
                   hp.Phong,
                   hp.MaMonHoc,
                   hp.MaGiaoVien,
                   hp.MaKhoaHoc
                }); ;

            return rerult;
        }
        public int CapNhatDiemHPCC(DTO_DiemHocPhanChungChi diem)
        {
            string query = "update diemhocphanchungchi set diem = @diem , mahocvien = @mahocvien ,mahpcc = @mahpcc   where madiemhpcc = @madiem ";

            int rerult = DAO_DBConnect.Instance.ExecuteNonQuery(
                query,
                new object[] {
                    diem.Diem,
                   diem.MaHocVien,
                   diem.MaHPCC,
                   diem.MaDiemHPCC,
                });

            return rerult;
        }
        public DataTable SelectHPCC()
        {
            string query = "select MaHPCC from HocPhanChungChi";

            DataTable result = DAO_DBConnect.Instance.ExecuteQuery(query);

            return result;
        }
       
        public DataTable SelectHV()
        {
            string query = "select MaHocVien from HocVien";

            DataTable result = DAO_DBConnect.Instance.ExecuteQuery(query);

            return result;
        }
    }
}
