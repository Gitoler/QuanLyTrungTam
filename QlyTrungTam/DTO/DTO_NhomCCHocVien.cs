using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class NhomCCHocVien
    {
        public NhomCCHocVien(int id, int hoadon_id, string hocvien_name, int khoahoc_id, string khoahoc_name, DateTime khoahoc_lauching, string chungchi_name, int chungchi_status)
        {
            this.Hocvien_ID = id;
            this.Hocvien_Name = hocvien_name;
            this.Hocvien_KhoaKyThuat_ID = khoahoc_id;
            this.Hocvien_KhoaKyThuat_Name = khoahoc_name;
            this.Hocvien_KhoaKyThuat_Lauching = khoahoc_lauching;
            this.Hocvien_NhomCC_Name = chungchi_name;
            this.Hocvien_NhomCC_Status = chungchi_status;
            this.Hocvien_HDNHomCC_ID = hoadon_id;

        }

        public NhomCCHocVien(DataRow row)
        {
            this.Hocvien_HDNHomCC_ID = (int)row["machitiethdnhpkt"];
            this.Hocvien_ID = (int)row["mahocvien"];
            this.Hocvien_Name = row["tenhocvien"].ToString();
            this.Hocvien_KhoaKyThuat_ID = (int)row["makhoahoc"];
            this.Hocvien_KhoaKyThuat_Name = row["tenkhoahoc"].ToString();
            this.Hocvien_KhoaKyThuat_Lauching = (DateTime)row["ngaybatdau"];
            this.Hocvien_NhomCC_Name = row["tennhomhocphan"].ToString();
            this.Hocvien_NhomCC_Status = (int)row["yccapchungchi"];
        }
        private int hocvien_HDNHomCC_ID;
        private int hocvien_NhomCC_Status;
        private string hocvien_NhomCC_Name;
        private DateTime hocvien_KhoaKyThuat_Lauching;
        private string hocvien_KhoaKyThuat_Name;
        private int hocvien_KhoaKyThuat_ID;
        private string hocvien_Name;
        private int hocvien_ID;

        public int Hocvien_ID { get => hocvien_ID; set => hocvien_ID = value; }
        public string Hocvien_Name { get => hocvien_Name; set => hocvien_Name = value; }
        public int Hocvien_KhoaKyThuat_ID { get => hocvien_KhoaKyThuat_ID; set => hocvien_KhoaKyThuat_ID = value; }
        public string Hocvien_KhoaKyThuat_Name { get => hocvien_KhoaKyThuat_Name; set => hocvien_KhoaKyThuat_Name = value; }
        public DateTime Hocvien_KhoaKyThuat_Lauching { get => hocvien_KhoaKyThuat_Lauching; set => hocvien_KhoaKyThuat_Lauching = value; }
        public string Hocvien_NhomCC_Name { get => hocvien_NhomCC_Name; set => hocvien_NhomCC_Name = value; }
        public int Hocvien_NhomCC_Status { get => hocvien_NhomCC_Status; set => hocvien_NhomCC_Status = value; }
        public int Hocvien_HDNHomCC_ID { get => hocvien_HDNHomCC_ID; set => hocvien_HDNHomCC_ID = value; }
    }
}
