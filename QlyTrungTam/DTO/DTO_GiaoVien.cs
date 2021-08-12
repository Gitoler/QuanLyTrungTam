using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class GiaoVien
    {
        public GiaoVien(int id, string name, string adress, string sdt, string email)
        {
            this.Giaovien_ID = id;
            this.Giaovien_Name = name;
            this.Giaovien_Adress = adress;
            this.Giaovien_SDT = sdt;
            this.Giaovien_Email = email;

        }

        public GiaoVien(DataRow row)
        {
            this.Giaovien_ID = (int)row["magiaovien"];
            this.Giaovien_Name = row["tengiaovien"].ToString();
            this.Giaovien_Adress = row["diachi"].ToString();
            this.Giaovien_SDT = row["sdt"].ToString();
            this.Giaovien_Email = row["email"].ToString();
        }
        private string giaovien_Email;
        private string giaovien_SDT;
        private string giaovien_Adress;
        private string giaovien_Name;
        private int giaovien_ID;

        public int Giaovien_ID { get => giaovien_ID; set => giaovien_ID = value; }
        public string Giaovien_Name { get => giaovien_Name; set => giaovien_Name = value; }
        public string Giaovien_Adress { get => giaovien_Adress; set => giaovien_Adress = value; }
        public string Giaovien_SDT { get => giaovien_SDT; set => giaovien_SDT = value; }
        public string Giaovien_Email { get => giaovien_Email; set => giaovien_Email = value; }
    }
}
