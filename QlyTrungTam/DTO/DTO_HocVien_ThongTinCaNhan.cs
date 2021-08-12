using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class DTO_HocVien_ThongTinCaNhan
    {
    private 
        int _mahv;
        string _tenhv;
        string _email;
        string _sdt;
        string _diachi;
        string _password;

        public int MaHV
        {
            get { return _mahv; }
            set { _mahv = value; }
        }

        public string TenHV
        {
            get { return _tenhv; }
            set { _tenhv = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string SDT
        {
            get { return _sdt; }
            set { _sdt = value; }
        }
        public string DiaChi
        {
            get { return _diachi; }
            set { _diachi = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public DTO_HocVien_ThongTinCaNhan(  int mahv,
                                            string tenhv,
                                            string email,
                                            string sdt,
                                            string diachi,
                                            string password)
        {
            MaHV = mahv;
            TenHV = tenhv;
            Email = email;
            SDT = sdt;
            DiaChi = diachi;
            Password = password;
        }

    }


}
