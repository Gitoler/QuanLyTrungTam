using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class HoaDon
    {
        public HoaDon(DataRow row)
        {
            this.Hoadon_ID = (int)row["mahoadon"];
            this.Hoadon_Founding = (DateTime)row["ngaytao"];
            this.Hoadon_Money = (int)row["tiendangky"];
            this.Hoadon_Hocvien_ID = (int)row["mahocvien"];
            this.Hoadon_Khoahoc_ID = (int)row["makhoahoc"];
            this.Hoadon_status = (int)row["tinhtrang"];

        }
        public HoaDon(int id, DateTime founding, int money, int idhocvien, int idkhoahoc, int status)
        {
            this.Hoadon_ID = id;
            this.Hoadon_Founding = founding;
            this.Hoadon_Money = money;
            this.Hoadon_Hocvien_ID = idhocvien;
            this.Hoadon_Khoahoc_ID = idkhoahoc;
            this.Hoadon_status = status;

        }
        private int hoadon_Status;
        private int hoadon_Khoahoc_ID;
        private int hoadon_Hocvien_ID;
        private int hoadon_Money;
        private DateTime hoadon_Founding;
        private int hoadon_ID;

        public int Hoadon_ID { get => hoadon_ID; set => hoadon_ID = value; }
        public DateTime Hoadon_Founding { get => hoadon_Founding; set => hoadon_Founding = value; }
        public int Hoadon_Money { get => hoadon_Money; set => hoadon_Money = value; }
        public int Hoadon_Hocvien_ID { get => hoadon_Hocvien_ID; set => hoadon_Hocvien_ID = value; }
        public int Hoadon_Khoahoc_ID { get => hoadon_Khoahoc_ID; set => hoadon_Khoahoc_ID = value; }
        public int Hoadon_status { get => hoadon_Status; set => hoadon_Status = value; }
    }
}
