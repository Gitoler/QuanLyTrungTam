using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class LichThiHocPhanKyThuat
    {
        public LichThiHocPhanKyThuat(DataRow row)
        {
            this.Lichthihocphankythuat_NhanVien_Name = row["tennhanvien"].ToString();
            this.Lichthihocphankythuat_NhanVien_ID = (int)row["manhanvien"];
            this.lichthihocphankythuat_HPKT_ID = (int)row["mahpkythuat"];
            this.Lichthihocphankythuat_NhomKyThuat_Name = row["tennhomhocphan"].ToString();
            this.Lichthihocphankythuat_NhomKyThuat_ID = (int)row["manhomhocphan"];
            this.lichthihocphankythuat_MonHoc_Name = row["tenmonhoc"].ToString();
            this.Lichthihocphankythuat_MonHoc_ID = (int)row["mamonhoc"];
            this.Lichthihocphankythuat_PhongThi = row["phongthi"].ToString();
            this.Lichthihocphankythuat_LanThi = (int)row["lanthi"];
            this.Lichthihocphankythuat_Opening = (DateTime)row["ngaythi"];
            this.Lichthihocphankythuat_KhoaKyThuat_Name = row["tenkhoahoc"].ToString();
            this.Lichthihocphankythuat_KhoaKyThuat_ID = (int)row["makhoahoc"];
            this.Lichthihocphankythuat_ID = (int)row["malichthihpkt"];
        }
        public LichThiHocPhanKyThuat(int id, int khoakythuat_id, string khoakythuat_name, DateTime opening, int lanthi, string phongthi, int idmonhoc, string tenmonhoc, int idnhomphkt, string tennhomphkt, int idhpkt, int idnhanvien, string tennhanvien)
        {
            this.Lichthihocphankythuat_NhanVien_Name = tennhanvien;
            this.Lichthihocphankythuat_NhanVien_ID = idnhanvien;
            this.lichthihocphankythuat_HPKT_ID = idhpkt;
            this.Lichthihocphankythuat_NhomKyThuat_Name = tennhomphkt;
            this.Lichthihocphankythuat_NhomKyThuat_ID = idnhomphkt;
            this.lichthihocphankythuat_MonHoc_Name = tenmonhoc;
            this.Lichthihocphankythuat_MonHoc_ID = idmonhoc;
            this.Lichthihocphankythuat_PhongThi = phongthi;
            this.Lichthihocphankythuat_LanThi = lanthi;
            this.Lichthihocphankythuat_Opening = opening;
            this.Lichthihocphankythuat_KhoaKyThuat_Name = khoakythuat_name;
            this.Lichthihocphankythuat_KhoaKyThuat_ID = khoakythuat_id;
            this.Lichthihocphankythuat_ID = id;
        }
        private string lichthihocphankythuat_NhanVien_Name;
        private int lichthihocphankythuat_NhanVien_ID;
        private int lichthihocphankythuat_HPKT_ID;
        private string lichthihocphankythuat_NhomKyThuat_Name;
        private int lichthihocphankythuat_NhomKyThuat_ID;
        private string lichthihocphankythuat_MonHoc_Name;
        private int lichthihocphankythuat_MonHoc_ID;
        private string lichthihocphankythuat_PhongThi;
        private int lichthihocphankythuat_LanThi;
        private DateTime lichthihocphankythuat_Opening;
        private string lichthihocphankythuat_KhoaKyThuat_Name;
        private int lichthihocphankythuat_KhoaKyThuat_ID;
        private int lichthihocphankythuat_ID;

        public int Lichthihocphankythuat_ID { get => lichthihocphankythuat_ID; set => lichthihocphankythuat_ID = value; }
        public int Lichthihocphankythuat_KhoaKyThuat_ID { get => lichthihocphankythuat_KhoaKyThuat_ID; set => lichthihocphankythuat_KhoaKyThuat_ID = value; }
        public string Lichthihocphankythuat_KhoaKyThuat_Name { get => lichthihocphankythuat_KhoaKyThuat_Name; set => lichthihocphankythuat_KhoaKyThuat_Name = value; }
        public DateTime Lichthihocphankythuat_Opening { get => lichthihocphankythuat_Opening; set => lichthihocphankythuat_Opening = value; }
        public int Lichthihocphankythuat_LanThi { get => lichthihocphankythuat_LanThi; set => lichthihocphankythuat_LanThi = value; }
        public string Lichthihocphankythuat_PhongThi { get => lichthihocphankythuat_PhongThi; set => lichthihocphankythuat_PhongThi = value; }
        public int Lichthihocphankythuat_MonHoc_ID { get => lichthihocphankythuat_MonHoc_ID; set => lichthihocphankythuat_MonHoc_ID = value; }
        public string Lichthihocphankythuat_MonHoc_Name { get => lichthihocphankythuat_MonHoc_Name; set => lichthihocphankythuat_MonHoc_Name = value; }
        public int Lichthihocphankythuat_NhomKyThuat_ID { get => lichthihocphankythuat_NhomKyThuat_ID; set => lichthihocphankythuat_NhomKyThuat_ID = value; }
        public string Lichthihocphankythuat_NhomKyThuat_Name { get => lichthihocphankythuat_NhomKyThuat_Name; set => lichthihocphankythuat_NhomKyThuat_Name = value; }
        public int Lichthihocphankythuat_HPKT_ID { get => lichthihocphankythuat_HPKT_ID; set => lichthihocphankythuat_HPKT_ID = value; }
        public int Lichthihocphankythuat_NhanVien_ID { get => lichthihocphankythuat_NhanVien_ID; set => lichthihocphankythuat_NhanVien_ID = value; }
        public string Lichthihocphankythuat_NhanVien_Name { get => lichthihocphankythuat_NhanVien_Name; set => lichthihocphankythuat_NhanVien_Name = value; }
    }
}
