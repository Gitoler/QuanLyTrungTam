using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class HocVienHocPhanKyThuat
    {
        public HocVienHocPhanKyThuat(int id, int idhocvien, string tenhocvien, int idmonhoc, string nhom, string tenmonhoc, string lichhoc, DateTime lichthi, string namhoc, string kyhoc, int diem, int iddiem, int lanthi)
        {
            this.Hocvien_ID = idhocvien;
            this.Hocvien_Name = tenhocvien;
            this.Hocvien_MonHoc_ID = idmonhoc;
            this.Hocvien_MonHoc_Name = tenmonhoc;
            this.Hocvien_HPKT_ID = id;
            this.Hocvien_HPKT_LichHoc = lichhoc;
            this.Hocvien_HPKT_NamHoc = namhoc;
            this.Hocvien_HPKT_KyHoc = kyhoc;
            this.Hocvien_HPKT_LichThi = lichthi;
            this.Hocvien_HPKT_Diem = diem;
            this.Hocvien_HPKT_Diem_ID = iddiem;
            this.Hocvien_Nhom = nhom;
            this.Hocvien_LanThi = lanthi;
        }

        public HocVienHocPhanKyThuat(DataRow row)
        {
            this.hocvien_LanThi = (int)row["lanthi"];
            this.Hocvien_HPKT_Diem_ID = (int)row["madiemhpkt"];
            var diem = row["diem"];
            if (diem.ToString() != "")
            {
                this.Hocvien_HPKT_Diem = (int)row["diem"];
            }
            this.Hocvien_ID = (int)row["mahocvien"];
            this.Hocvien_Name = row["tenhocvien"].ToString();
            this.Hocvien_MonHoc_ID = (int)row["mamonhoc"];
            this.Hocvien_MonHoc_Name = row["tenmonhoc"].ToString();
            this.Hocvien_HPKT_ID = (int)row["mahpkythuat"];
            this.Hocvien_HPKT_LichHoc = row["lichhoc"].ToString();
            this.Hocvien_HPKT_NamHoc = row["namhoc"].ToString();
            this.Hocvien_HPKT_KyHoc = row["hocky"].ToString();
            this.Hocvien_HPKT_LichThi = (DateTime)row["ngaythi"];
            this.Hocvien_Nhom = row["tennhomhocphan"].ToString();
        }
        private int hocvien_LanThi;
        private string hocvien_Nhom;
        private int hocvien_HPKT_Diem_ID;
        private int hocvien_HPKT_Diem;
        private DateTime hocvien_HPKT_LichThi;
        private string hocvien_HPKT_KyHoc;
        private string hocvien_HPKT_NamHoc;
        private string hocvien_HPKT_LichHoc;
        private string hocvien_MonHoc_Name;
        private int hocvien_MonHoc_ID;
        private int hocvien_HPKT_ID;
        private string hocvien_Name;
        private int hocvien_ID;

        public int Hocvien_ID { get => hocvien_ID; set => hocvien_ID = value; }
        public string Hocvien_Name { get => hocvien_Name; set => hocvien_Name = value; }
        public int Hocvien_HPKT_ID { get => hocvien_HPKT_ID; set => hocvien_HPKT_ID = value; }
        public int Hocvien_MonHoc_ID { get => hocvien_MonHoc_ID; set => hocvien_MonHoc_ID = value; }
        public string Hocvien_MonHoc_Name { get => hocvien_MonHoc_Name; set => hocvien_MonHoc_Name = value; }
        public string Hocvien_HPKT_LichHoc { get => hocvien_HPKT_LichHoc; set => hocvien_HPKT_LichHoc = value; }
        public string Hocvien_HPKT_NamHoc { get => hocvien_HPKT_NamHoc; set => hocvien_HPKT_NamHoc = value; }
        public string Hocvien_HPKT_KyHoc { get => hocvien_HPKT_KyHoc; set => hocvien_HPKT_KyHoc = value; }
        public DateTime Hocvien_HPKT_LichThi { get => hocvien_HPKT_LichThi; set => hocvien_HPKT_LichThi = value; }
        public int Hocvien_HPKT_Diem { get => hocvien_HPKT_Diem; set => hocvien_HPKT_Diem = value; }
        public int Hocvien_HPKT_Diem_ID { get => hocvien_HPKT_Diem_ID; set => hocvien_HPKT_Diem_ID = value; }
        public string Hocvien_Nhom { get => hocvien_Nhom; set => hocvien_Nhom = value; }
        public int Hocvien_LanThi { get => hocvien_LanThi; set => hocvien_LanThi = value; }
    }
}
