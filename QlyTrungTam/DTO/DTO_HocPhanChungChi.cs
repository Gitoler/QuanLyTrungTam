using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class HocPhanChungChi
    {
        public HocPhanChungChi(DataRow row)
        {
            this.Hocphanchungchi_ID = (int)row["mahpcc"];
            this.Hocphanchungchi_GiaoVien_Name = row["tengiaovien"].ToString();
            this.Hocphanchungchi_GiaoVien_ID = (int)row["magiaovien"];
            this.Hocphanchungchi_MonHoc_ID = (int)row["mamonhoc"];
            this.Hocphanchungchi_MonHoc_Name = row["tenmonhoc"].ToString();
            this.Hocphanchungchi_KhoaHoc_ID = (int)row["makhoahoc"];
            this.Hocphanchungchi_KhoaHoc_Name = row["tenkhoahoc"].ToString();
            this.Hocphanchungchi_Phong = row["phong"].ToString();
            this.Hocphanchungchi_NamHoc = row["namhoc"].ToString();
            this.Hocphanchungchi_LichHoc = row["lichhoc"].ToString();
            this.Hocphanchungchi_HocKy = row["hocky"].ToString();
            this.Hocphanchungchi_NhomChungChi_Name = row["tennhomchungchi"].ToString();

        }
        public HocPhanChungChi(int id, int idgiaovien, string tengiaovien, int idmonhoc, string tenmonhoc, int idkhoahoc, string tenkhoahoc, string namhoc, string lichhoc, string hocky, string phong, string nhomchungchi)
        {
            this.Hocphanchungchi_ID = id;
            this.Hocphanchungchi_GiaoVien_Name = tengiaovien;
            this.Hocphanchungchi_GiaoVien_ID = idgiaovien;
            this.Hocphanchungchi_MonHoc_ID = idmonhoc;
            this.Hocphanchungchi_MonHoc_Name = tenmonhoc;
            this.Hocphanchungchi_KhoaHoc_ID = idkhoahoc;
            this.Hocphanchungchi_KhoaHoc_Name = tenkhoahoc;
            this.Hocphanchungchi_Phong = phong;
            this.Hocphanchungchi_NamHoc = namhoc;
            this.Hocphanchungchi_LichHoc = lichhoc;
            this.Hocphanchungchi_HocKy = hocky;
            this.Hocphanchungchi_NhomChungChi_Name = nhomchungchi;

        }
        private string hocphanchungchi_NhomChungChi_Name;
        private string hocphanchungchi_Phong;
        private string hocphanchungchi_GiaoVien_Name;
        private int hocphanchungchi_GiaoVien_ID;
        private string hocphanchungchi_KhoaHoc_Name;
        private int hocphanchungchi_KhoaHoc_ID;
        private string hocphanchungchi_LichHoc;
        private string hocphanchungchi_HocKy;
        private string hocphanchungchi_NamHoc;
        private int hocphanchungchi_ID;
        private int hocphanchungchi_MonHoc_ID;
        private string hocphanchungchi_MonHoc_Name;

        public string Hocphanchungchi_MonHoc_Name { get => hocphanchungchi_MonHoc_Name; set => hocphanchungchi_MonHoc_Name = value; }
        public int Hocphanchungchi_MonHoc_ID { get => hocphanchungchi_MonHoc_ID; set => hocphanchungchi_MonHoc_ID = value; }
        public int Hocphanchungchi_ID { get => hocphanchungchi_ID; set => hocphanchungchi_ID = value; }
        public string Hocphanchungchi_NamHoc { get => hocphanchungchi_NamHoc; set => hocphanchungchi_NamHoc = value; }
        public string Hocphanchungchi_HocKy { get => hocphanchungchi_HocKy; set => hocphanchungchi_HocKy = value; }
        public string Hocphanchungchi_LichHoc { get => hocphanchungchi_LichHoc; set => hocphanchungchi_LichHoc = value; }
        public int Hocphanchungchi_KhoaHoc_ID { get => hocphanchungchi_KhoaHoc_ID; set => hocphanchungchi_KhoaHoc_ID = value; }
        public string Hocphanchungchi_KhoaHoc_Name { get => hocphanchungchi_KhoaHoc_Name; set => hocphanchungchi_KhoaHoc_Name = value; }
        public int Hocphanchungchi_GiaoVien_ID { get => hocphanchungchi_GiaoVien_ID; set => hocphanchungchi_GiaoVien_ID = value; }
        public string Hocphanchungchi_GiaoVien_Name { get => hocphanchungchi_GiaoVien_Name; set => hocphanchungchi_GiaoVien_Name = value; }
        public string Hocphanchungchi_Phong { get => hocphanchungchi_Phong; set => hocphanchungchi_Phong = value; }
        public string Hocphanchungchi_NhomChungChi_Name { get => hocphanchungchi_NhomChungChi_Name; set => hocphanchungchi_NhomChungChi_Name = value; }
    }
}
