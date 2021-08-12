using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class ChungChiHocVien
    {
        public ChungChiHocVien(int id,int hoadon_id, string hocvien_name, int khoahoc_id, string khoahoc_name, DateTime khoahoc_lauching, string chungchi_name, int chungchi_status)
        {
            this.Hocvien_ID = id;
            this.Hocvien_Name = hocvien_name;
            this.Hocvien_KhoaChungChi_ID = khoahoc_id;
            this.Hocvien_KhoaChungChi_Name = khoahoc_name;
            this.Hocvien_KhoaChungChi_Lauching = khoahoc_lauching;
            this.Hocvien_ChungChi_Name = chungchi_name;
            this.Hocvien_ChungChi_status = chungchi_status;
            this.Hocvien_HoaDon_ID = hoadon_id;

        }

        public ChungChiHocVien(DataRow row)
        {
            this.Hocvien_HoaDon_ID = (int)row["mahoadon"];
            this.Hocvien_ID = (int)row["mahocvien"];
            this.Hocvien_Name = row["tenhocvien"].ToString();
            this.Hocvien_KhoaChungChi_ID = (int)row["makhoahoc"];
            this.Hocvien_KhoaChungChi_Name = row["tenkhoahoc"].ToString();
            this.Hocvien_KhoaChungChi_Lauching = (DateTime)row["ngaybatdau"];
            this.hocvien_ChungChi_Name = row["tennhomchungchi"].ToString();
            this.Hocvien_ChungChi_status = (int)row["yccapchungchi"];
        }
        private int hocvien_HoaDon_ID;
        private int hocvien_ChungChi_Status;
        private string hocvien_ChungChi_Name;
        private DateTime hocvien_KhoaChungChi_Lauching;
        private string hocvien_KhoaChungChi_Name;
        private int hocvien_KhoaChungChi_ID;
        private string hocvien_Name;
        private int hocvien_ID;

        public int Hocvien_ID { get => hocvien_ID; set => hocvien_ID = value; }
        public string Hocvien_Name { get => hocvien_Name; set => hocvien_Name = value; }
        public string Hocvien_KhoaChungChi_Name { get => hocvien_KhoaChungChi_Name; set => hocvien_KhoaChungChi_Name = value; }
        public DateTime Hocvien_KhoaChungChi_Lauching { get => hocvien_KhoaChungChi_Lauching; set => hocvien_KhoaChungChi_Lauching = value; }
        public string Hocvien_ChungChi_Name { get => hocvien_ChungChi_Name; set => hocvien_ChungChi_Name = value; }
        public int Hocvien_ChungChi_status { get => hocvien_ChungChi_Status; set => hocvien_ChungChi_Status = value; }
        public int Hocvien_KhoaChungChi_ID { get => hocvien_KhoaChungChi_ID; set => hocvien_KhoaChungChi_ID = value; }
        public int Hocvien_HoaDon_ID { get => hocvien_HoaDon_ID; set => hocvien_HoaDon_ID = value; }
    }
}
