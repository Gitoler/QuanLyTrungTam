using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class HoaDonChungChi
    {
        public HoaDonChungChi(DataRow row)
        {
            this.Hoadonchungchi_ID = (int)row["machitiethd"];
            this.Hoadonchungchi_KhoaHoc_Name = row["tenkhoahoc"].ToString();
            this.Hoadonchungchi_MonHoc_ID = (int)row["mamonhoc"];
            this.Hoadonchungchi_MonHoc_Name = row["tenmonhoc"].ToString();
            this.Hoadonchungchi_HocPhan_Price = (int)row["gia"];

        }
        public HoaDonChungChi(int id, string khoahoc_name, int monhoc_id, string monhoc_name, int price)
        {
            this.Hoadonchungchi_ID = id;
            this.Hoadonchungchi_KhoaHoc_Name = khoahoc_name;
            this.Hoadonchungchi_MonHoc_ID = monhoc_id;
            this.Hoadonchungchi_MonHoc_Name = monhoc_name;
            this.Hoadonchungchi_HocPhan_Price = price;

        }
        private int hoadonchungchi_HocPhan_Price;
        private string hoadonchungchi_MonHoc_Name;
        private int hoadonchungchi_MonHoc_ID;
        private string hoadonchungchi_KhoaHoc_Name;
        private int hoadonchungchi_ID;

        public int Hoadonchungchi_ID { get => hoadonchungchi_ID; set => hoadonchungchi_ID = value; }
        public string Hoadonchungchi_KhoaHoc_Name { get => hoadonchungchi_KhoaHoc_Name; set => hoadonchungchi_KhoaHoc_Name = value; }
        public int Hoadonchungchi_MonHoc_ID { get => hoadonchungchi_MonHoc_ID; set => hoadonchungchi_MonHoc_ID = value; }
        public string Hoadonchungchi_MonHoc_Name { get => hoadonchungchi_MonHoc_Name; set => hoadonchungchi_MonHoc_Name = value; }
        public int Hoadonchungchi_HocPhan_Price { get => hoadonchungchi_HocPhan_Price; set => hoadonchungchi_HocPhan_Price = value; }
    }
}
