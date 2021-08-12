using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class KhoaKyThuat
    {
        public KhoaKyThuat(DataRow row)
        {
            this.khoakythuat_ID = (int)row["makhoahoc"];
            this.khoakythuat_Name = row["tenkhoahoc"].ToString();
            this.khoakythuat_Opening = (DateTime)row["ngaybatdau"];
            this.khoakythuat_Status = row["mota"].ToString();
            this.Khoakythuat_Group_Size = (int)row["soluongnhomhp"];
            this.Khoakythuat_Nhanvien_ID = (int)row["manhanvien"];
            this.khoakythuat_Loai_ID = (int)row["maloaikhoahoc"];
        }
        public KhoaKyThuat(int id, string name, DateTime opening, string status, int groupsize, int idnhanvien, int idtype)
        {
            this.khoakythuat_ID = id;
            this.khoakythuat_Name = name;
            this.khoakythuat_Opening = opening;
            this.khoakythuat_Status = status;
            this.Khoakythuat_Group_Size = groupsize;
            this.Khoakythuat_Nhanvien_ID = idnhanvien;
            this.Khoakythuat_Loai_ID = idtype;

        }
        private int khoakythuat_Loai_ID;
        private int khoakythuat_Nhanvien_ID;
        private int khoakythuat_Group_Size;
        private string khoakythuat_Status;
        private DateTime khoakythuat_Opening;
        private string khoakythuat_Name;
        private int khoakythuat_ID;

        public int Khoakythuat_ID { get => khoakythuat_ID; set => khoakythuat_ID = value; }
        public string Khoakythuat_Name { get => khoakythuat_Name; set => khoakythuat_Name = value; }
        public DateTime Khoakythuat_Opening { get => khoakythuat_Opening; set => khoakythuat_Opening = value; }
        public string Khoakythuat_Status { get => khoakythuat_Status; set => khoakythuat_Status = value; }
        public int Khoakythuat_Group_Size { get => khoakythuat_Group_Size; set => khoakythuat_Group_Size = value; }
        public int Khoakythuat_Nhanvien_ID { get => khoakythuat_Nhanvien_ID; set => khoakythuat_Nhanvien_ID = value; }
        public int Khoakythuat_Loai_ID { get => khoakythuat_Loai_ID; set => khoakythuat_Loai_ID = value; }
    }
}
