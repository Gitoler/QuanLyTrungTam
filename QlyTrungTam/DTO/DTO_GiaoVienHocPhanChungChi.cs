using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class GiaoVienHocPhanChungChi
    {
        public GiaoVienHocPhanChungChi(int id, int idhocvien, string tenhocvien, int idkhoahoc, string tenkhoahoc, int idgiaovien, string tengiaovien, int idmonhoc, string tenmonhoc, string lichhoc, DateTime lichthi, string namhoc, string kyhoc, int diem, int iddiem)
        {
            this.Giaovien_HocVien_ID = idhocvien;
            this.Giaovien_HocVien_Name = tenhocvien;
            this.Giaovien_ID = idgiaovien;
            this.Giaovien_Name = tengiaovien;
            this.Giaovien_MonHoc_ID = idmonhoc;
            this.Giaovien_MonHoc_Name = tenmonhoc;
            this.Giaovien_KhoaHoc_ID = idkhoahoc;
            this.Giaovien_KhoaHoc_Name = tenkhoahoc;
            this.Giaovien_HPCC_ID = id;
            this.Giaovien_HPCC_LichHoc = lichhoc;
            this.Giaovien_HPCC_NamHoc = namhoc;
            this.Giaovien_HPCC_KyHoc = kyhoc;
            this.Giaovien_HPCC_LichThi = lichthi;
            this.Giaovien_HPCC_Diem = diem;
            this.Giaovien_HPCC_Diem_ID = iddiem;
        }

        public GiaoVienHocPhanChungChi(DataRow row)
        {
            this.Giaovien_HPCC_Diem_ID = (int)row["madiemhpcc"];
            var diem = row["diem"];
            if (diem.ToString() != "")
            {
                this.Giaovien_HPCC_Diem = (int)row["diem"];
            }
            this.Giaovien_HocVien_ID = (int)row["mahocvien"];
            this.Giaovien_HocVien_Name = row["tenhocvien"].ToString();
            this.Giaovien_ID = (int)row["magiaovien"];
            this.Giaovien_Name = row["tengiaovien"].ToString();
            this.Giaovien_MonHoc_ID = (int)row["mamonhoc"];
            this.Giaovien_MonHoc_Name = row["tenmonhoc"].ToString();
            this.Giaovien_KhoaHoc_ID = (int)row["makhoahoc"];
            this.Giaovien_KhoaHoc_Name = row["tenkhoahoc"].ToString();
            this.Giaovien_HPCC_ID = (int)row["mahpcc"];
            this.Giaovien_HPCC_LichHoc = row["lichhoc"].ToString();
            this.Giaovien_HPCC_NamHoc = row["namhoc"].ToString();
            this.Giaovien_HPCC_KyHoc = row["hocky"].ToString();
            this.Giaovien_HPCC_LichThi = (DateTime)row["ngaythi"];
        }
        private int giaovien_HPCC_Diem_ID;
        private int giaovien_HPCC_Diem;
        private DateTime giaovien_HPCC_LichThi;
        private string giaovien_HPCC_KyHoc;
        private string giaovien_HPCC_NamHoc;
        private string giaovien_HPCC_LichHoc;
        private string giaovien_MonHoc_Name;
        private int giaovien_MonHoc_ID;
        private string giaovien_KhoaHoc_Name;
        private int giaovien_KhoaHoc_ID;
        private int giaovien_HPCC_ID;
        private string giaovien_Name;
        private int giaovien_ID;
        private string giaovien_HocVien_Name;
        private int giaovien_HocVien_ID;

        public int Giaovien_HocVien_ID { get => giaovien_HocVien_ID; set => giaovien_HocVien_ID = value; }
        public string Giaovien_HocVien_Name { get => giaovien_HocVien_Name; set => giaovien_HocVien_Name = value; }
        public int Giaovien_ID { get => giaovien_ID; set => giaovien_ID = value; }
        public string Giaovien_Name { get => giaovien_Name; set => giaovien_Name = value; }
        public int Giaovien_KhoaHoc_ID { get => giaovien_KhoaHoc_ID; set => giaovien_KhoaHoc_ID = value; }
        public string Giaovien_KhoaHoc_Name { get => giaovien_KhoaHoc_Name; set => giaovien_KhoaHoc_Name = value; }
        public int Giaovien_MonHoc_ID { get => giaovien_MonHoc_ID; set => giaovien_MonHoc_ID = value; }
        public string Giaovien_MonHoc_Name { get => giaovien_MonHoc_Name; set => giaovien_MonHoc_Name = value; }
        public string Giaovien_HPCC_LichHoc { get => giaovien_HPCC_LichHoc; set => giaovien_HPCC_LichHoc = value; }
        public string Giaovien_HPCC_NamHoc { get => giaovien_HPCC_NamHoc; set => giaovien_HPCC_NamHoc = value; }
        public string Giaovien_HPCC_KyHoc { get => giaovien_HPCC_KyHoc; set => giaovien_HPCC_KyHoc = value; }
        public int Giaovien_HPCC_ID { get => giaovien_HPCC_ID; set => giaovien_HPCC_ID = value; }
        public DateTime Giaovien_HPCC_LichThi { get => giaovien_HPCC_LichThi; set => giaovien_HPCC_LichThi = value; }
        public int Giaovien_HPCC_Diem { get => giaovien_HPCC_Diem; set => giaovien_HPCC_Diem = value; }
        public int Giaovien_HPCC_Diem_ID { get => giaovien_HPCC_Diem_ID; set => giaovien_HPCC_Diem_ID = value; }
    }
}
