using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class LoaiKhoaHoc
    {
        public LoaiKhoaHoc(DataRow row)
        {
            this.loaikhoahoc_ID = (int)row["maloaikhoahoc"];
            this.loaikhoahoc_Name = row["tenloaikhoahoc"].ToString();
        }
        public LoaiKhoaHoc(int id, string name)
        {
            this.loaikhoahoc_ID = id;
            this.loaikhoahoc_Name = name;
        }
        private string loaikhoahoc_Name;
        private int loaikhoahoc_ID;

        public int Loaikhoahoc_ID { get => loaikhoahoc_ID; set => loaikhoahoc_ID = value; }
        public string Loaikhoahoc_Name { get => loaikhoahoc_Name; set => loaikhoahoc_Name = value; }
    }
}
