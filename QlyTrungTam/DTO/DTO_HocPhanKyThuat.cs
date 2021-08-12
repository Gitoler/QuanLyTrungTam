using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class HocPhanKyThuat
    {
        public HocPhanKyThuat(DataRow row)
        {
            this.Hocphankythuat_ID = (int)row["mahpkythuat"];
            this.Hocphankythuat_GiaoVien_Name = row["tengiaovien"].ToString();
            this.Hocphankythuat_GiaoVien_ID = (int)row["magiaovien"];
            this.Hocphankythuat_MonHoc_ID = (int)row["mamonhoc"];
            this.Hocphankythuat_MonHoc_Name = row["tenmonhoc"].ToString();
            this.Hocphankythuat_KhoaHoc_ID = (int)row["makhoahoc"];
            this.Hocphankythuat_KhoaHoc_Name = row["tenkhoahoc"].ToString();
            this.Hocphankythuat_Phong = row["phong"].ToString();
            this.Hocphankythuat_NamHoc = row["namhoc"].ToString();
            this.Hocphankythuat_LichHoc = row["lichhoc"].ToString();
            this.Hocphankythuat_HocKy = row["hocky"].ToString();
            this.Hocphankythuat_NhomKyThuat_Name = row["tennhomhocphan"].ToString();
            this.Hocphankythuat_NhomKyThuat_ID = (int)row["manhomhocphan"];

        }
        public HocPhanKyThuat(int id, int idgiaovien, string tengiaovien, int idmonhoc, string tenmonhoc, int idkhoahoc, string tenkhoahoc, string namhoc, string lichhoc, string hocky, string phong, string nhomkythuat, int idnhomkythuat)
        {
            this.Hocphankythuat_ID = id;
            this.Hocphankythuat_GiaoVien_Name = tengiaovien;
            this.Hocphankythuat_GiaoVien_ID = idgiaovien;
            this.Hocphankythuat_MonHoc_ID = idmonhoc;
            this.Hocphankythuat_MonHoc_Name = tenmonhoc;
            this.Hocphankythuat_KhoaHoc_ID = idkhoahoc;
            this.Hocphankythuat_KhoaHoc_Name = tenkhoahoc;
            this.Hocphankythuat_Phong = phong;
            this.Hocphankythuat_NamHoc = namhoc;
            this.Hocphankythuat_LichHoc = lichhoc;
            this.Hocphankythuat_HocKy = hocky;
            this.Hocphankythuat_NhomKyThuat_Name = nhomkythuat;
            this.Hocphankythuat_NhomKyThuat_ID = idnhomkythuat;

        }
        private int hocphankythuat_NhomKyThuat_ID;
        private string hocphankythuat_NhomKyThuat_Name;
        private string hocphankythuat_Phong;
        private string hocphankythuat_GiaoVien_Name;
        private int hocphankythuat_GiaoVien_ID;
        private string hocphankythuat_KhoaHoc_Name;
        private int hocphankythuat_KhoaHoc_ID;
        private string hocphankythuat_LichHoc;
        private string hocphankythuat_HocKy;
        private string hocphankythuat_NamHoc;
        private int hocphankythuat_ID;
        private int hocphankythuat_MonHoc_ID;
        private string hocphankythuat_MonHoc_Name;

        public string Hocphankythuat_MonHoc_Name { get => hocphankythuat_MonHoc_Name; set => hocphankythuat_MonHoc_Name = value; }
        public int Hocphankythuat_MonHoc_ID { get => hocphankythuat_MonHoc_ID; set => hocphankythuat_MonHoc_ID = value; }
        public int Hocphankythuat_ID { get => hocphankythuat_ID; set => hocphankythuat_ID = value; }
        public string Hocphankythuat_NamHoc { get => hocphankythuat_NamHoc; set => hocphankythuat_NamHoc = value; }
        public string Hocphankythuat_HocKy { get => hocphankythuat_HocKy; set => hocphankythuat_HocKy = value; }
        public string Hocphankythuat_LichHoc { get => hocphankythuat_LichHoc; set => hocphankythuat_LichHoc = value; }
        public int Hocphankythuat_KhoaHoc_ID { get => hocphankythuat_KhoaHoc_ID; set => hocphankythuat_KhoaHoc_ID = value; }
        public string Hocphankythuat_KhoaHoc_Name { get => hocphankythuat_KhoaHoc_Name; set => hocphankythuat_KhoaHoc_Name = value; }
        public int Hocphankythuat_GiaoVien_ID { get => hocphankythuat_GiaoVien_ID; set => hocphankythuat_GiaoVien_ID = value; }
        public string Hocphankythuat_GiaoVien_Name { get => hocphankythuat_GiaoVien_Name; set => hocphankythuat_GiaoVien_Name = value; }
        public string Hocphankythuat_Phong { get => hocphankythuat_Phong; set => hocphankythuat_Phong = value; }
        public string Hocphankythuat_NhomKyThuat_Name { get => hocphankythuat_NhomKyThuat_Name; set => hocphankythuat_NhomKyThuat_Name = value; }
        public int Hocphankythuat_NhomKyThuat_ID { get => hocphankythuat_NhomKyThuat_ID; set => hocphankythuat_NhomKyThuat_ID = value; }
    }
}
