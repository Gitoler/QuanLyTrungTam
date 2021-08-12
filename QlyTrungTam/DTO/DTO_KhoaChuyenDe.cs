using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class KhoaChuyenDe
    {
        public KhoaChuyenDe(DataRow row)
        {
            Khoachuyende_ID = (int)row["makhoahoc"];
            Khoachuyende_Name = row["tenkhoahoc"].ToString(); ;
            Khoachuyende_Opening = (DateTime)row["ngaybatdau"];
            Khoachuyende_Status = row["mota"].ToString();
            Khoachuyende_Nhanvien_ID = (int)row["manhanvien"];
            Khoachuyende_Loai_ID = (int)row["maloaikhoahoc"];
        }
        public KhoaChuyenDe(int id, string name, DateTime opeing, string status, int groupsize, int grouptype, int idnhanvien,int idtype)
        {
            Khoachuyende_ID = id;
            Khoachuyende_Name = name;
            Khoachuyende_Opening = opeing;
            Khoachuyende_Status = status;
            Khoachuyende_Nhanvien_ID = idnhanvien;
            Khoachuyende_Loai_ID = idtype; 
        }
        private int khoachuyende_Loai_ID;
        private int khoachuyende_Nhanvien_ID;
        private string khoachuyende_Status;
        private DateTime khoachuyende_Opening;
        private int khoachuyende_ID;
        private string khoachuyende_Name;

        public string Khoachuyende_Name { get => khoachuyende_Name; set => khoachuyende_Name = value; }
        public int Khoachuyende_ID { get => khoachuyende_ID; set => khoachuyende_ID = value; }
        public DateTime Khoachuyende_Opening { get => khoachuyende_Opening; set => khoachuyende_Opening = value; }
        public string Khoachuyende_Status { get => khoachuyende_Status; set => khoachuyende_Status = value; }
        public int Khoachuyende_Nhanvien_ID { get => khoachuyende_Nhanvien_ID; set => khoachuyende_Nhanvien_ID = value; }
        public int Khoachuyende_Loai_ID { get => khoachuyende_Loai_ID; set => khoachuyende_Loai_ID = value; }
    }
}
