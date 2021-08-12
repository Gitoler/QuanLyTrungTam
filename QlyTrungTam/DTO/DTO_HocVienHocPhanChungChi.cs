using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class HocVienHocPhanChungChi
    {
        public HocVienHocPhanChungChi(int id, int idhocvien, string tenhocvien, int idmonhoc,string nhom, string tenmonhoc, string lichhoc, DateTime lichthi, string namhoc, string kyhoc, int diem, int iddiem)
        {
            this.Hocvien_ID = idhocvien;
            this.Hocvien_Name = tenhocvien;
            this.Hocvien_MonHoc_ID = idmonhoc;
            this.Hocvien_MonHoc_Name = tenmonhoc;
            this.Hocvien_HPCC_ID = id;
            this.Hocvien_HPCC_LichHoc = lichhoc;
            this.Hocvien_HPCC_NamHoc = namhoc;
            this.Hocvien_HPCC_KyHoc = kyhoc;
            this.Hocvien_HPCC_LichThi = lichthi;
            this.Hocvien_HPCC_Diem = diem;
            this.Hocvien_HPCC_Diem_ID = iddiem;
            this.Hocvien_Nhom = nhom;
        }

        public HocVienHocPhanChungChi(DataRow row)
        {

            this.Hocvien_HPCC_Diem_ID = (int)row["madiemhpcc"];
            var diem = row["diem"];
            if (diem.ToString() != "")
            {
                this.Hocvien_HPCC_Diem = (int)row["diem"];
            }
            this.Hocvien_ID = (int)row["mahocvien"];
            this.Hocvien_Name = row["tenhocvien"].ToString();
            this.Hocvien_MonHoc_ID = (int)row["mamonhoc"];
            this.Hocvien_MonHoc_Name = row["tenmonhoc"].ToString();
            this.Hocvien_HPCC_ID = (int)row["mahpcc"];
            this.Hocvien_HPCC_LichHoc = row["lichhoc"].ToString();
            this.Hocvien_HPCC_NamHoc = row["namhoc"].ToString();
            this.Hocvien_HPCC_KyHoc = row["hocky"].ToString();
            this.Hocvien_HPCC_LichThi = (DateTime)row["ngaythi"];
            this.Hocvien_Nhom = row["tennhomchungchi"].ToString();
        }
        private string hocvien_Nhom;
        private int hocvien_HPCC_Diem_ID;
        private int hocvien_HPCC_Diem;
        private DateTime hocvien_HPCC_LichThi;
        private string hocvien_HPCC_KyHoc;
        private string hocvien_HPCC_NamHoc;
        private string hocvien_HPCC_LichHoc;
        private string hocvien_MonHoc_Name;
        private int hocvien_MonHoc_ID;
        private int hocvien_HPCC_ID;
        private string hocvien_Name;
        private int hocvien_ID;

        public int Hocvien_ID { get => hocvien_ID; set => hocvien_ID = value; }
        public string Hocvien_Name { get => hocvien_Name; set => hocvien_Name = value; }
        public int Hocvien_HPCC_ID { get => hocvien_HPCC_ID; set => hocvien_HPCC_ID = value; }
        public int Hocvien_MonHoc_ID { get => hocvien_MonHoc_ID; set => hocvien_MonHoc_ID = value; }
        public string Hocvien_MonHoc_Name { get => hocvien_MonHoc_Name; set => hocvien_MonHoc_Name = value; }
        public string Hocvien_HPCC_LichHoc { get => hocvien_HPCC_LichHoc; set => hocvien_HPCC_LichHoc = value; }
        public string Hocvien_HPCC_NamHoc { get => hocvien_HPCC_NamHoc; set => hocvien_HPCC_NamHoc = value; }
        public string Hocvien_HPCC_KyHoc { get => hocvien_HPCC_KyHoc; set => hocvien_HPCC_KyHoc = value; }
        public DateTime Hocvien_HPCC_LichThi { get => hocvien_HPCC_LichThi; set => hocvien_HPCC_LichThi = value; }
        public int Hocvien_HPCC_Diem { get => hocvien_HPCC_Diem; set => hocvien_HPCC_Diem = value; }
        public int Hocvien_HPCC_Diem_ID { get => hocvien_HPCC_Diem_ID; set => hocvien_HPCC_Diem_ID = value; }
        public string Hocvien_Nhom { get => hocvien_Nhom; set => hocvien_Nhom = value; }
    }
}
