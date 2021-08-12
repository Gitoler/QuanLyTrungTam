using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QlyTrungTam.DTO;

namespace QlyTrungTam
{
    public partial class GUILogin : Form
    {
        string gv = "GIAOVIEN", nv = "NHANVIEN", hv = "HOCVIEN";

        public GUILogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtbUsername.Text;
            string passWord = txbPassword.Text;

            string isLogin = Login(userName, passWord);

            if (isLogin.Contains(gv) == true)
            {
                GUIGiaoVien fgv= new GUIGiaoVien();
                this.Hide();
                fgv.ShowDialog();
            }
            else if (isLogin.Contains(nv) == true)
            {
                GUIQuanLiTrungTam qltt = new GUIQuanLiTrungTam();
                this.Hide();
                qltt.ShowDialog();
            }
            else if (isLogin.Contains(hv) == true)
            {
                GUIHocVien ghv = new GUIHocVien();
                this.Hide();
                ghv.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại");
            }

        }

        private void GUILogin_Load(object sender, EventArgs e)
        {

        }

        public string Login(string userName, string passWord)
        {
            DTO_Account user = new DTO_Account(userName, passWord, "");
            return DAO.DAO_UserPass.Instance.Login(user);
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn thoát chương trình không ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }    
        }
    }
}
