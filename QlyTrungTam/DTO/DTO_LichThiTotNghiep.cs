using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class LichThiTotNghiep
    {
        public LichThiTotNghiep(DataRow row)
        {
            lichthitotnghiep_PhongThi = row["phongthi"].ToString();
            lichthitotnghiep_LanThi = (int)row["lanthi"];
            lichthitotnghiep_Opening = (DateTime)row["ngaythi"];
            lichthitotnghiep_KhoaKyThuat_Name = row["tenkhoahoc"].ToString();
            lichthitotnghiep_KhoaKyThuat_ID = (int)row["makhoahoc"];
            lichthitotnghiep_ID = (int)row["malichthitotnghiep"];
        }
        public LichThiTotNghiep(int id, int khoakythuat_id, string khoakythuat_name, DateTime opening, int lanthi, string phongthi)
        {
            lichthitotnghiep_PhongThi = phongthi;
            lichthitotnghiep_LanThi = lanthi;
            lichthitotnghiep_Opening = opening;
            lichthitotnghiep_KhoaKyThuat_Name = khoakythuat_name;
            lichthitotnghiep_KhoaKyThuat_ID = khoakythuat_id;
            lichthitotnghiep_ID = id;
        }
        private string lichthitotnghiep_PhongThi;
        private int lichthitotnghiep_LanThi;
        private DateTime lichthitotnghiep_Opening;
        private string lichthitotnghiep_KhoaKyThuat_Name;
        private int lichthitotnghiep_KhoaKyThuat_ID;
        private int lichthitotnghiep_ID;

        public int Lichthitotnghiep_ID { get => lichthitotnghiep_ID; set => lichthitotnghiep_ID = value; }
        public int Lichthitotnghiep_KhoaKyThuat_ID { get => lichthitotnghiep_KhoaKyThuat_ID; set => lichthitotnghiep_KhoaKyThuat_ID = value; }
        public string Lichthitotnghiep_KhoaKyThuat_Name { get => lichthitotnghiep_KhoaKyThuat_Name; set => lichthitotnghiep_KhoaKyThuat_Name = value; }
        public DateTime Lichthitotnghiep_Opening { get => lichthitotnghiep_Opening; set => lichthitotnghiep_Opening = value; }
        public int Lichthitotnghiep_LanThi { get => lichthitotnghiep_LanThi; set => lichthitotnghiep_LanThi = value; }
        public string Lichthitotnghiep_PhongThi { get => lichthitotnghiep_PhongThi; set => lichthitotnghiep_PhongThi = value; }
    }
}
