using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class NhanVien
    {
        public NhanVien(int id, string name, string adress, string sdt, string email)
        {
            this.Nhanvien_ID = id;
            this.Nhanvien_Name = name;
            this.Nhanvien_Adress = adress;
            this.Nhanvien_SDT = sdt;
            this.Nhanvien_Email = email;

        }

        public NhanVien(DataRow row)
        {
            this.Nhanvien_ID = (int)row["manhanvien"];
            this.Nhanvien_Name = row["tennhanvien"].ToString();
            this.Nhanvien_Adress = row["diachi"].ToString();
            this.Nhanvien_SDT = row["sdt"].ToString();
            this.Nhanvien_Email = row["email"].ToString();
        }
        private string nhanvien_Email;
        private string nhanvien_SDT;
        private string nhanvien_Adress;
        private string nhanvien_Name;
        private int nhanvien_ID;

        public int Nhanvien_ID { get => nhanvien_ID; set => nhanvien_ID = value; }
        public string Nhanvien_Name { get => nhanvien_Name; set => nhanvien_Name = value; }
        public string Nhanvien_Adress { get => nhanvien_Adress; set => nhanvien_Adress = value; }
        public string Nhanvien_SDT { get => nhanvien_SDT; set => nhanvien_SDT = value; }
        public string Nhanvien_Email { get => nhanvien_Email; set => nhanvien_Email = value; }
    }
}
