using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class HocVien
    {
        public HocVien(int id, string name, string adress, string sdt, string email)
        {
            this.Hocvien_ID = id;
            this.Hocvien_Name = name;
            this.Hocvien_Adress = adress;
            this.Hocvien_SDT = sdt;
            this.Hocvien_Email = email;

        }

        public HocVien(DataRow row)
        {
            this.Hocvien_ID = (int)row["mahocvien"];
            this.Hocvien_Name = row["tenhocvien"].ToString();
            this.Hocvien_Adress = row["diachi"].ToString();
            this.Hocvien_SDT = row["sdt"].ToString();
            this.Hocvien_Email = row["email"].ToString();
        }
        private string hocvien_Email;
        private string hocvien_SDT;
        private string hocvien_Adress;
        private string hocvien_Name;
        private int hocvien_ID;
        public int Hocvien_ID { get => hocvien_ID; set => hocvien_ID = value; }
        public string Hocvien_Name { get => hocvien_Name; set => hocvien_Name = value; }
        public string Hocvien_Adress { get => hocvien_Adress; set => hocvien_Adress = value; }
        public string Hocvien_SDT { get => hocvien_SDT; set => hocvien_SDT = value; }
        public string Hocvien_Email { get => hocvien_Email; set => hocvien_Email = value; }
        public static object Instance { get; internal set; }
    }
}
