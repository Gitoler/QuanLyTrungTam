using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class DTO_HocVien_XemTTHocTap
    {
        private 
            string _hocki;
            string _namhoc;
            string _loai;
        public string HocKi
        {
            get { return _hocki; }
            set { _hocki = value; }
        }
        public string NamHoc
        {
            get { return _namhoc; }
            set { _namhoc = value; }
        }

        public string Loai
        {
            get { return _loai; }
            set { _loai = value; }
        }
        public DTO_HocVien_XemTTHocTap(string hocki, string namhoc, string loai)
        {
            HocKi = hocki;
            NamHoc = namhoc;
            Loai = loai;
        }
    }
}
