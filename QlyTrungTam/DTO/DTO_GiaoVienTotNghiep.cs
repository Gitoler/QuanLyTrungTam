using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class GiaoVienTotNghiep
    {
        public GiaoVienTotNghiep(int iddiem,int diem,int idkhoahoc,string tenkhoahoc, int idhocvien, string tenhocvien, DateTime lichthi, int lanthi, int idgiaovien)
        {
            this.Giaovientotnghiep_Diem_ID = iddiem;
            this.Giaovientotnghiep_Diem = diem;
            this.Giaovientotnghiep_Khoa_ID = idkhoahoc;
            this.Giaovientotnghiep_Khoa_Name = tenkhoahoc;
            this.Giaovientotnghiep_LichThi = lichthi;
            this.Giaovientotnghiep_LanThi = lanthi;
            this.Giaovientotnghiep_HocVien_ID = idhocvien;
            this.Giaovientotnghiep_HocVien_Name = tenhocvien;
            this.Giaovientotnghiep_GiaoVien_ID = idgiaovien;

        }

        public GiaoVienTotNghiep(DataRow row)
        {
            this.Giaovientotnghiep_Diem_ID = (int)row["madiemthitotnghiep"];
            var diem = row["diem"];
            if (diem.ToString() != "")
            {
                this.Giaovientotnghiep_Diem = (int)diem;
            }
            this.Giaovientotnghiep_Khoa_ID = (int)row["makhoahoc"];
            this.Giaovientotnghiep_Khoa_Name = row["tenkhoahoc"].ToString();
            this.Giaovientotnghiep_LichThi = (DateTime)row["ngaythi"];
            this.Giaovientotnghiep_LanThi = (int)row["lanthi"];
            this.Giaovientotnghiep_HocVien_ID = (int)row["mahocvien"];
            this.Giaovientotnghiep_HocVien_Name = row["tenhocvien"].ToString();
            var idgiaovien = row["magiaovien"];
            if (idgiaovien.ToString() != "")
            {
                this.Giaovientotnghiep_GiaoVien_ID = (int)idgiaovien;
            }
        }
        private int giaovientotnghiep_GiaoVien_ID;
        private string giaovientotnghiep_HocVien_Name;
        private int giaovientotnghiep_HocVien_ID;
        private int giaovientotnghiep_LanThi;
        private DateTime giaovientotnghiep_LichThi;
        private string giaovientotnghiep_Khoa_Name;
        private int giaovientotnghiep_Khoa_ID;
        private int giaovientotnghiep_Diem;
        private int giaovientotnghiep_Diem_ID;

        public int Giaovientotnghiep_Diem_ID { get => giaovientotnghiep_Diem_ID; set => giaovientotnghiep_Diem_ID = value; }
        public int Giaovientotnghiep_Diem { get => giaovientotnghiep_Diem; set => giaovientotnghiep_Diem = value; }
        public int Giaovientotnghiep_Khoa_ID { get => giaovientotnghiep_Khoa_ID; set => giaovientotnghiep_Khoa_ID = value; }
        public string Giaovientotnghiep_Khoa_Name { get => giaovientotnghiep_Khoa_Name; set => giaovientotnghiep_Khoa_Name = value; }
        public DateTime Giaovientotnghiep_LichThi { get => giaovientotnghiep_LichThi; set => giaovientotnghiep_LichThi = value; }
        public int Giaovientotnghiep_LanThi { get => giaovientotnghiep_LanThi; set => giaovientotnghiep_LanThi = value; }
        public int Giaovientotnghiep_HocVien_ID { get => giaovientotnghiep_HocVien_ID; set => giaovientotnghiep_HocVien_ID = value; }
        public string Giaovientotnghiep_HocVien_Name { get => giaovientotnghiep_HocVien_Name; set => giaovientotnghiep_HocVien_Name = value; }
        public int Giaovientotnghiep_GiaoVien_ID { get => giaovientotnghiep_GiaoVien_ID; set => giaovientotnghiep_GiaoVien_ID = value; }
    }
}
