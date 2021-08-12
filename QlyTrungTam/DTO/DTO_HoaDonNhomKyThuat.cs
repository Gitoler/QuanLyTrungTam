using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class HoaDonNhomKyThuat
    {
        public HoaDonNhomKyThuat(DataRow row)
        {
            this.Hoadonnhomkythuat_HoaDon_ID = (int)row["mahoadon"];
            this.Hoadonnhomkythuat_ID = (int)row["machitiethd"];
            this.Hoadonnhomkythuat_KhoaHoc_Name = row["tenkhoahoc"].ToString();
            this.Hoadonnhomkythuat_NhomKyThuat_ID = (int)row["manhomhocphan"];
            this.Hoadonnhomkythuat_NhomKyThuat_Name = row["tennhomhocphan"].ToString();
            this.hoadonnhomkythuat_NhomKyThuat_Price = (int)row["gia"];

        }
        public HoaDonNhomKyThuat(int id,int hoadon_id, string khoahoc_name, int nhomkythuat_id, string nhomkythuat_name, int price)
        {
            this.Hoadonnhomkythuat_HoaDon_ID = hoadon_id;
            this.Hoadonnhomkythuat_ID = id;
            this.Hoadonnhomkythuat_KhoaHoc_Name = khoahoc_name;
            this.Hoadonnhomkythuat_NhomKyThuat_ID = nhomkythuat_id;
            this.Hoadonnhomkythuat_NhomKyThuat_Name = nhomkythuat_name;
            this.hoadonnhomkythuat_NhomKyThuat_Price = price;

        }
        private int hoadonnhomkythuat_NhomKyThuat_Price;
        private string hoadonnhomkythuat_NhomKyThuat_Name;
        private int hoadonnhomkythuat_NhomKyThuat_ID;
        private string hoadonnhomkythuat_KhoaHoc_Name;
        private int hoadonnhomkythuat_ID;
        private int hoadonnhomkythuat_HoaDon_ID;

        public int Hoadonnhomkythuat_ID { get => hoadonnhomkythuat_ID; set => hoadonnhomkythuat_ID = value; }
        public int Hoadonnhomkythuat_NhomKyThuat_ID { get => hoadonnhomkythuat_NhomKyThuat_ID; set => hoadonnhomkythuat_NhomKyThuat_ID = value; }
        public string Hoadonnhomkythuat_NhomKyThuat_Name { get => hoadonnhomkythuat_NhomKyThuat_Name; set => hoadonnhomkythuat_NhomKyThuat_Name = value; }
        public int Hoadonnhomkythuat_NhomKyThuat_Price { get => hoadonnhomkythuat_NhomKyThuat_Price; set => hoadonnhomkythuat_NhomKyThuat_Price = value; }
        public string Hoadonnhomkythuat_KhoaHoc_Name { get => hoadonnhomkythuat_KhoaHoc_Name; set => hoadonnhomkythuat_KhoaHoc_Name = value; }
        public int Hoadonnhomkythuat_HoaDon_ID { get => hoadonnhomkythuat_HoaDon_ID; set => hoadonnhomkythuat_HoaDon_ID = value; }
    }
}
