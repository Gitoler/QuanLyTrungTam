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
using QlyTrungTam.DAO;

namespace QlyTrungTam
{
    public partial class GUIQuanLiThongTin : Form
    {
        public GUIQuanLiThongTin()
        {
            InitializeComponent();
        }

        private void savebt_Click(object sender, EventArgs e)
        {
            int mhv = Convert.ToInt32(mhvtb.Text);
            string thv = thvtb.Text;
            string email = emailtb.Text;
            string sdt = sdttb.Text;
            string dc = dctb.Text;
            string getpassword = pwtb.Text;
            if (getpassword == "")
            {
                MessageBox.Show("Password không được trống.", "Thông báo");
            }

            string ypw = DTO_Account.Instance.PassWord;
            if (getpassword == ypw)
            {
                DTO_HocVien_ThongTinCaNhan tmp = new DTO_HocVien_ThongTinCaNhan(mhv,
                                                                                thv,
                                                                                email,
                                                                                sdt,
                                                                                dc,
                                                                                "");
                int result = DAO_HocVien_ThongTinCaNhan.Instance.Update_HocVien_ThongTinCaNhan(tmp);
                if (result > 0)
                {
                    MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo");
                    pwtb.Text = "";
                }
            }
        }

        private void GUIQuanLiThongTin_Load(object sender, EventArgs e)
        {
            DataTable tmp = DAO.DAO_HocVien_ThongTinCaNhan.Instance.Select_HocVien_ThongTinCaNhan();
            mhvtb.Text = tmp.Rows[0]["MaHocVien"].ToString();
            thvtb.Text = tmp.Rows[0]["TenHocVien"].ToString();
            emailtb.Text = tmp.Rows[0]["EMail"].ToString();
            sdttb.Text = tmp.Rows[0]["SDT"].ToString();
            dctb.Text = tmp.Rows[0]["DiaChi"].ToString();
            DataTable dt = DAO.DAO_HocVien_ThongTinTaiKhoan.Instance.Select_HocVien_ThongTinTaiKhoan();
            emtb.Text = dt.Rows[0]["username"].ToString();
        }

        private void savetttk_Click(object sender, EventArgs e)
        {
            DataTable dt = DAO.DAO_HocVien_ThongTinTaiKhoan.Instance.Select_HocVien_ThongTinTaiKhoan();
            if(dt.Rows[0]["pw"].ToString().Contains(pwtb.Text))
            {
                if (npwtb.Text == rctb.Text)
                {
                    DTO_HocVien_ThongTinTaiKhoan dttk = new DTO_HocVien_ThongTinTaiKhoan(emtb.Text, npwtb.Text);
                    int result = DAO_HocVien_ThongTinTaiKhoan.Instance.Update_HocVien_ThongTinTaiKhoan(dttk);
                    if(result > 0)
                    {
                        MessageBox.Show("Cập nhật thành công.", "Thông báo");
                        npwtb.Text = "";
                        rctb.Text = "";
                        pwtbtttk.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại.", "Thông báo");
                        npwtb.Text = "";
                        rctb.Text = "";
                        pwtbtttk.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Password mới không khớp.", "Thông báo");
                    npwtb.Text = "";
                    rctb.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Password không chính xác.", "Thông báo");
                npwtb.Text = "";
                rctb.Text = "";
                pwtbtttk.Text = "";
            }
        }
    }
}
