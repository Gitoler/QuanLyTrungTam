using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class KhoaChungChi
    {
        public KhoaChungChi(DataRow row)
        {
            khoachungchi_ID = (int)row["makhoahoc"];
            khoachungchi_Name = row["tenkhoahoc"].ToString(); ;
            khoachungchi_Opening = (DateTime)row["ngaybatdau"];
            khoachungchi_Status = row["mota"].ToString();
            Khoachungchi_Group_Size = (int)row["soluonghpcc"];
            Khoachungchi_Group_Type = (int)row["manhomchungchi"]; 
            khoachungchi_Nhanvien_ID = (int)row["manhanvien"];
            khoachungchi_Loai_ID = (int)row["maloaikhoahoc"];

        }
        public KhoaChungChi(int id, string name, DateTime opeing, string status, int groupsize, int grouptype, int idnhanvien, int idtype)
        {
            khoachungchi_ID = id;
            khoachungchi_Name = name;
            khoachungchi_Opening = opeing;
            khoachungchi_Status = status;
            Khoachungchi_Group_Size = groupsize;
            Khoachungchi_Group_Type = grouptype;
            khoachungchi_Nhanvien_ID = idnhanvien;
            khoachungchi_Loai_ID = idtype;

    }
    private int khoachungchi_Loai_ID;
        private int khoachungchi_Nhanvien_ID;
        private int khoachungchi_Group_Type;
        private int khoachungchi_Group_Size;
        private string khoachungchi_Status;
        private DateTime khoachungchi_Opening;
        private int  khoachungchi_ID;
        private string khoachungchi_Name;

        public int Khoachungchi_ID { get => khoachungchi_ID; set => khoachungchi_ID = value; }
        public string Khoachungchi_Name { get => khoachungchi_Name; set => khoachungchi_Name = value; }
        public DateTime Khoachungchi_Opening { get => khoachungchi_Opening; set => khoachungchi_Opening = value; }
        public string Khoachungchi_Status { get => khoachungchi_Status; set => khoachungchi_Status = value; }
        public int Khoachungchi_Group_Size { get => khoachungchi_Group_Size; set => khoachungchi_Group_Size = value; }
        public int Khoachungchi_Group_Type { get => khoachungchi_Group_Type; set => khoachungchi_Group_Type = value; }
        public int Khoachungchi_Nhanvien_ID { get => khoachungchi_Nhanvien_ID; set => khoachungchi_Nhanvien_ID = value; }
        public int Khoachungchi_Loai_ID { get => khoachungchi_Loai_ID; set => khoachungchi_Loai_ID = value; }
    }
}
