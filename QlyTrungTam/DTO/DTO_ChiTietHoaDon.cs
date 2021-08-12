using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class ChiTietHoaDon
    {
        public ChiTietHoaDon(DataRow row)
        {
            this.Chitiethoadon_ID = (int)row["machitiethd"];
            this.chitiethoadon_Price = (int)row["gia"];
            this.Chitiethoadon_Hoadon_ID = (int)row["mahoadon"];
        }
        public ChiTietHoaDon(int id, int price, int idhoadon)
        {
            this.Chitiethoadon_ID = id;
            this.chitiethoadon_Price = price;
            this.Chitiethoadon_Hoadon_ID = idhoadon;

        }
        private int chitiethoadon_Hoadon_ID;
        private int chitiethoadon_Price;
        private int chitiethoadon_ID;

        public int Chitiethoadon_ID { get => chitiethoadon_ID; set => chitiethoadon_ID = value; }
        public int Chitiethoadon_Price { get => chitiethoadon_Price; set => chitiethoadon_Price = value; }
        public int Chitiethoadon_Hoadon_ID { get => chitiethoadon_Hoadon_ID; set => chitiethoadon_Hoadon_ID = value; }
    }
}
