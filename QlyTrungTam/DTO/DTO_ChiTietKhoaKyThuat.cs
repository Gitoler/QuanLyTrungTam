using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class ChiTietKhoaKyThuat
    {
        public ChiTietKhoaKyThuat(DataRow row)
        {
            this.chitietkhoakythuat_nhomhpkythuat_Name = row["tennhomhocphan"].ToString();
            this.chitietkhoakythuat_nhomhpkythuat_ID = (int)row["manhomhocphan"];
            this.chitietkhoakythuat_khoakythuat_ID = (int)row["makhoahoc"];
            this.Chitietkhoakythuat_ID = (int)row["machitietkhoakythuat"];
        }
        public ChiTietKhoaKyThuat(int id, int idkhoakythuat, int idnhomhpkythuat, string namenhomhpkythuat)
        {
            this.chitietkhoakythuat_nhomhpkythuat_Name = namenhomhpkythuat;
            this.chitietkhoakythuat_nhomhpkythuat_ID = idnhomhpkythuat;
            this.chitietkhoakythuat_khoakythuat_ID =  idkhoakythuat;
            this.Chitietkhoakythuat_ID = id;

        }
        private string chitietkhoakythuat_nhomhpkythuat_Name;
        private int chitietkhoakythuat_nhomhpkythuat_ID;
        private int chitietkhoakythuat_khoakythuat_ID;
        private int chitietkhoakythuat_ID;

        public int Chitietkhoakythuat_ID { get => chitietkhoakythuat_ID; set => chitietkhoakythuat_ID = value; }
        public int Chitietkhoakythuat_khoakythuat_ID { get => chitietkhoakythuat_khoakythuat_ID; set => chitietkhoakythuat_khoakythuat_ID = value; }
        public int Chitietkhoakythuat_nhomhpkythuat_ID { get => chitietkhoakythuat_nhomhpkythuat_ID; set => chitietkhoakythuat_nhomhpkythuat_ID = value; }
        public string Chitietkhoakythuat_nhomhpkythuat_Name { get => chitietkhoakythuat_nhomhpkythuat_Name; set => chitietkhoakythuat_nhomhpkythuat_Name = value; }
    }
}
