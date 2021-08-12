using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class KhoaHoc
    {
        public KhoaHoc(DataRow row)
        {
            this.Khoahoc_ID = (int)row["makhoahoc"];
            this.Khoahoc_Name = row["tenkhoahoc"].ToString();
            this.Khoahoc_Opening = (DateTime)row["ngaybatdau"];
            this.Khoahoc_Status = row["mota"].ToString();
            this.Khoahoc_Nhanvien_ID = (int)row["manhanvien"];
            this.Khoahoc_Loai_ID = (int)row["maloaikhoahoc"];
            this.Khoahoc_Loai_Name = row["tenloaikhoahoc"].ToString();
        }
        public KhoaHoc(int id, string name, DateTime opening, string status, int idnhanvien, int idtype, string typename)
        {
            this.Khoahoc_ID = id;
            this.Khoahoc_Name = name;
            this.Khoahoc_Opening = opening;
            this.Khoahoc_Status = status;
            this.Khoahoc_Nhanvien_ID = idnhanvien;
            this.Khoahoc_Loai_ID = idtype;
            this.Khoahoc_Loai_Name = typename;

        }
        private string khoahoc_Loai_Name;
        private int khoahoc_Loai_ID;
        private int khoahoc_Nhanvien_ID;
        private string khoahoc_Status;
        private DateTime khoahoc_Opening;
        private string khoahoc_Name;
        private int khoahoc_ID;

        public int Khoahoc_ID { get => khoahoc_ID; set => khoahoc_ID = value; }
        public string Khoahoc_Name { get => khoahoc_Name; set => khoahoc_Name = value; }
        public DateTime Khoahoc_Opening { get => khoahoc_Opening; set => khoahoc_Opening = value; }
        public string Khoahoc_Status { get => khoahoc_Status; set => khoahoc_Status = value; }
        public int Khoahoc_Nhanvien_ID { get => khoahoc_Nhanvien_ID; set => khoahoc_Nhanvien_ID = value; }
        public int Khoahoc_Loai_ID { get => khoahoc_Loai_ID; set => khoahoc_Loai_ID = value; }
        public string Khoahoc_Loai_Name { get => khoahoc_Loai_Name; set => khoahoc_Loai_Name = value; }
    }
}
