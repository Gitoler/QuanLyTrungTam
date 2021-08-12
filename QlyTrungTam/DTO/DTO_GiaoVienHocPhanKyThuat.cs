using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class GiaoVienHocPhanKyThuat
    {
        public GiaoVienHocPhanKyThuat(int id, int idhocvien, string tenhocvien, int idkhoahoc, string tenkhoahoc, int idgiaovien, string tengiaovien, int idmonhoc, string tenmonhoc, string lichhoc, DateTime lichthi, string namhoc, string kyhoc, int diem, int iddiem, int lanthi, string tennhomhocphan)
        {
            this.Giaovien_HPKT_LanThi = lanthi;
            this.Giaovien_HPKT_NhomKT_Name = tennhomhocphan;
            this.Giaovien_HocVien_ID = idhocvien;
            this.Giaovien_HocVien_Name = tenhocvien;
            this.Giaovien_ID = idgiaovien;
            this.Giaovien_Name = tengiaovien;
            this.Giaovien_MonHoc_ID = idmonhoc;
            this.Giaovien_MonHoc_Name = tenmonhoc;
            this.Giaovien_KhoaHoc_ID = idkhoahoc;
            this.Giaovien_KhoaHoc_Name = tenkhoahoc;
            this.Giaovien_HPKT_ID = id;
            this.Giaovien_HPKT_LichHoc = lichhoc;
            this.Giaovien_HPKT_NamHoc = namhoc;
            this.Giaovien_HPKT_KyHoc = kyhoc;
            this.Giaovien_HPKT_LichThi = lichthi;
            this.Giaovien_HPKT_Diem = diem;
            this.Giaovien_HPKT_Diem_ID = iddiem;
        }

        public GiaoVienHocPhanKyThuat(DataRow row)
        {
            this.giaovien_HPKT_LanThi = (int)row["lanthi"];
            this.Giaovien_HPKT_NhomKT_Name = row["tennhomhocphan"].ToString();
            this.Giaovien_HPKT_Diem_ID = (int)row["madiemhpkt"];
            var diem = row["diem"];
            if (diem.ToString() != "")
            {
                this.Giaovien_HPKT_Diem = (int)row["diem"];
            }
            this.Giaovien_HocVien_ID = (int)row["mahocvien"];
            this.Giaovien_HocVien_Name = row["tenhocvien"].ToString();
            this.Giaovien_ID = (int)row["magiaovien"];
            this.Giaovien_Name = row["tengiaovien"].ToString();
            this.Giaovien_MonHoc_ID = (int)row["mamonhoc"];
            this.Giaovien_MonHoc_Name = row["tenmonhoc"].ToString();
            this.Giaovien_KhoaHoc_ID = (int)row["makhoahoc"];
            this.Giaovien_KhoaHoc_Name = row["tenkhoahoc"].ToString();
            this.Giaovien_HPKT_ID = (int)row["mahpkythuat"];
            this.Giaovien_HPKT_LichHoc = row["lichhoc"].ToString();
            this.Giaovien_HPKT_NamHoc = row["namhoc"].ToString();
            this.Giaovien_HPKT_KyHoc = row["hocky"].ToString();
            this.Giaovien_HPKT_LichThi = (DateTime)row["ngaythi"];
        }
        private int giaovien_HPKT_LanThi;
        private string giaovien_HPKT_NhomKT_Name;
        private int giaovien_HPKT_Diem_ID;
        private int giaovien_HPKT_Diem;
        private DateTime giaovien_HPKT_LichThi;
        private string giaovien_HPKT_KyHoc;
        private string giaovien_HPKT_NamHoc;
        private string giaovien_HPKT_LichHoc;
        private string giaovien_MonHoc_Name;
        private int giaovien_MonHoc_ID;
        private string giaovien_KhoaHoc_Name;
        private int giaovien_KhoaHoc_ID;
        private int giaovien_HPKT_ID;
        private string giaovien_Name;
        private int giaovien_ID;
        private string giaovien_HocVien_Name;
        private int giaovien_HocVien_ID;

        public int Giaovien_HocVien_ID { get => giaovien_HocVien_ID; set => giaovien_HocVien_ID = value; }
        public string Giaovien_HocVien_Name { get => giaovien_HocVien_Name; set => giaovien_HocVien_Name = value; }
        public int Giaovien_ID { get => giaovien_ID; set => giaovien_ID = value; }
        public string Giaovien_Name { get => giaovien_Name; set => giaovien_Name = value; }
        public int Giaovien_HPKT_ID { get => giaovien_HPKT_ID; set => giaovien_HPKT_ID = value; }
        public int Giaovien_KhoaHoc_ID { get => giaovien_KhoaHoc_ID; set => giaovien_KhoaHoc_ID = value; }
        public string Giaovien_KhoaHoc_Name { get => giaovien_KhoaHoc_Name; set => giaovien_KhoaHoc_Name = value; }
        public int Giaovien_MonHoc_ID { get => giaovien_MonHoc_ID; set => giaovien_MonHoc_ID = value; }
        public string Giaovien_MonHoc_Name { get => giaovien_MonHoc_Name; set => giaovien_MonHoc_Name = value; }
        public string Giaovien_HPKT_LichHoc { get => giaovien_HPKT_LichHoc; set => giaovien_HPKT_LichHoc = value; }
        public string Giaovien_HPKT_NamHoc { get => giaovien_HPKT_NamHoc; set => giaovien_HPKT_NamHoc = value; }
        public string Giaovien_HPKT_KyHoc { get => giaovien_HPKT_KyHoc; set => giaovien_HPKT_KyHoc = value; }
        public DateTime Giaovien_HPKT_LichThi { get => giaovien_HPKT_LichThi; set => giaovien_HPKT_LichThi = value; }
        public int Giaovien_HPKT_Diem { get => giaovien_HPKT_Diem; set => giaovien_HPKT_Diem = value; }
        public int Giaovien_HPKT_Diem_ID { get => giaovien_HPKT_Diem_ID; set => giaovien_HPKT_Diem_ID = value; }
        public string Giaovien_HPKT_NhomKT_Name { get => giaovien_HPKT_NhomKT_Name; set => giaovien_HPKT_NhomKT_Name = value; }
        public int Giaovien_HPKT_LanThi { get => giaovien_HPKT_LanThi; set => giaovien_HPKT_LanThi = value; }
    }
}
