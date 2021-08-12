using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class DTO_HocVien_ThongTinTaiKhoan
    {
        private
        string _username;
        string _pw;
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Pw
        {
            get { return _pw; }
            set { _pw = value; }
        }
        public DTO_HocVien_ThongTinTaiKhoan(string username,
                                           string pw)
        {
            Username = username;
            Pw = pw;
        }
    }
}
