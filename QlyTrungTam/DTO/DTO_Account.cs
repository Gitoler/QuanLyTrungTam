using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyTrungTam.DTO
{
    class DTO_Account
    {
        private static string _userName;

        private static DTO_Account instance;
        public static DTO_Account Instance
        {
            get
            {
                if (instance == null) instance = new DTO_Account(_userName, _passWord, _vaiTro);
                return instance;
            }
            private set { instance = value; }
        }
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        private static string _passWord;

        public string PassWord
        {
            get { return _passWord; }
            set { _passWord = value; }
        }

        private static string _vaiTro;

        public string VaiTro
        {
            get { return _vaiTro; }
            set { _vaiTro = value; }
        }

        public DTO_Account(string userName, string passWord, string vaiTro)
        {
            UserName = userName;
            PassWord = passWord;
            VaiTro = vaiTro;
        }
        public DTO_Account() { }
    }
}
