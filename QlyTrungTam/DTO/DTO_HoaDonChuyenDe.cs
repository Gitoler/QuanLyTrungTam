using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class HoaDonChuyenDe
    {
        public HoaDonChuyenDe(DataRow row)
        {
            this.Hoadonchuyende_ID = (int)row["machitiethd"];
            this.Hoadonchuyende_KhoaHoc_Name = row["tenkhoahoc"].ToString();
            this.Hoadonchuyende_ChuyenDe_ID = (int)row["machuyende"];
            this.Hoadonchuyende_ChuyenDe_Name = row["tenchuyende"].ToString();
            this.Hoadonchuyende_HocPhan_Price = (int)row["gia"];

        }
        public HoaDonChuyenDe(int id, string khoahoc_name, int chuyende_id, string chuyende_name, int price)
        {
            this.Hoadonchuyende_ID = id;
            this.Hoadonchuyende_KhoaHoc_Name = khoahoc_name;
            this.Hoadonchuyende_ChuyenDe_ID = chuyende_id;
            this.Hoadonchuyende_ChuyenDe_Name = chuyende_name;
            this.Hoadonchuyende_HocPhan_Price = price;

        }
        private int hoadonchuyende_HocPhan_Price;
        private string hoadonchuyende_ChuyenDe_Name;
        private int hoadonchuyende_ChuyenDe_ID;
        private string hoadonchuyende_KhoaHoc_Name;
        private int hoadonchuyende_ID;

        public int Hoadonchuyende_ID { get => hoadonchuyende_ID; set => hoadonchuyende_ID = value; }
        public string Hoadonchuyende_KhoaHoc_Name { get => hoadonchuyende_KhoaHoc_Name; set => hoadonchuyende_KhoaHoc_Name = value; }
        public int Hoadonchuyende_ChuyenDe_ID { get => hoadonchuyende_ChuyenDe_ID; set => hoadonchuyende_ChuyenDe_ID = value; }
        public string Hoadonchuyende_ChuyenDe_Name { get => hoadonchuyende_ChuyenDe_Name; set => hoadonchuyende_ChuyenDe_Name = value; }
        public int Hoadonchuyende_HocPhan_Price { get => hoadonchuyende_HocPhan_Price; set => hoadonchuyende_HocPhan_Price = value; }
    }
}
