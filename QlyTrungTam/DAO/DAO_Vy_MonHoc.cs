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
    class DAO_Vy_MonHoc
    {
        private static DAO_Vy_MonHoc instance;

        public static DAO_Vy_MonHoc Instance
        {
            get
            {
                if (instance == null) instance = new DAO_Vy_MonHoc();
                return instance;
            }
            private set { instance = value; }
        }

        private DAO_Vy_MonHoc() { }


        public DataTable XemMonHoc()
        {
            string query = "select * from monhoc";

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            return result;
        }

        public DataTable XemMonHocWithID(DTO_Vy_MonHoc mh)
        {
            string query = "select * from monhoc where mamonhoc = " + mh.MaMonHoc.ToString();

            DataTable result = DAO_DataProvider.Instance.ExecuteQuery(query);

            return result;
        }

        public int CapNhatMonHoc(DTO_Vy_MonHoc mh)
        {
            string query = "update monhoc set tenmonhoc = @ten , loaimonhoc = @loai , manhomhocphan = @hp , manhomchungchi = @cc where mamonhoc = @ma ";

            int result = DAO_DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[]
                {
                    mh.TenMonHoc,
                    mh.LoaiMonHoc,
                    mh.MaNhomHocPhan,
                    mh.MaNhomChungChi,
                    mh.MaMonHoc
                });

            return result;
        }

        public int ThemMonHoc(DTO_Vy_MonHoc mh)
        {
            string query = "insert into monhoc(tenmonhoc, loaimonhoc, manhomhocphan, manhomchungchi) values( @ten , @loai , @hp , @cc )";

            int result = DAO_DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[]
                {
                    mh.TenMonHoc,
                    mh.LoaiMonHoc,
                    mh.MaNhomHocPhan,
                    mh.MaNhomChungChi
                }
                );

            return result;
        }
    }
}
