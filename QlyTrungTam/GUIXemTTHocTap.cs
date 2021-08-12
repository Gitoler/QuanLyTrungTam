using QlyTrungTam.DAO;
using QlyTrungTam.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlyTrungTam
{
    public partial class GUIXemTTHocTap : Form
    {
        BindingSource hocviendiemhocphan = new BindingSource();
        int idhocvien = DAO_HocVien.Instance.GetIDHocVienByUserName();
        public GUIXemTTHocTap()
        {
            InitializeComponent();
            LoadHocVienDiem();
        }

        #region method
        void LoadHocVienDiem()
        {
            LoadLoaiKhoaHoc(cbHVLoaiKhoaHoc);
        }
        void LoadLoaiKhoaHoc(ComboBox cb)
        {
            List<LoaiKhoaHoc> listLoaiKhoaHoc = DAO_LoaiKhoaHoc.Instance.GetLoaiKhoaHocDiemList();
            cb.DataSource = listLoaiKhoaHoc;
            cb.DisplayMember = "loaikhoahoc_Name";
            LoaiKhoaHoc selected = cb.SelectedItem as LoaiKhoaHoc;
            int id = selected.Loaikhoahoc_ID;
        }
        void LoadKhoaHocByIDLoaiKhoaHoc(ComboBox cb, int id, int idhocvien)
        {
            List<KhoaHoc> listKhoaHoc = DAO_KhoaHoc.Instance.GetKhoaHocListByIDLoaiHocVien(id, idhocvien);
            cb.DataSource = listKhoaHoc;
            cb.DisplayMember = "khoahoc_Name";
        }

        void LoadListHocVienHocPhanChungChiByIDHocVien(int idkhoahoc, int idhocvien)
        {
            hocviendiemhocphan.DataSource = DAO_HocVienHocPhanChungChi.Instance.GetHocVienHocPhanChungChiListByIDHocVien(idkhoahoc, idhocvien);
            dtgvHVDiem.DataSource = hocviendiemhocphan;
        }
        void LoadListHocVienHocPhanKyThuatByIDHocVien(int idkhoahoc, int idhocvien)
        {
            hocviendiemhocphan.DataSource = DAO_HocVienHocPhanKyThuat.Instance.GetHocVienHocPhanKyThuatListByIDHocVien(idkhoahoc, idhocvien);
            dtgvHVDiem.DataSource = hocviendiemhocphan;
        }
        #endregion
        #region event
        private void cbHVLoaiKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            LoaiKhoaHoc selected = cb.SelectedItem as LoaiKhoaHoc;
            id = selected.Loaikhoahoc_ID;
            LoadKhoaHocByIDLoaiKhoaHoc(cbHVKhoaHoc, id, idhocvien);
        }
        private void cbHVKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            LoaiKhoaHoc loaikhoahoc = (LoaiKhoaHoc)cbHVLoaiKhoaHoc.SelectedItem;
            int maloaikhoahoc = loaikhoahoc.Loaikhoahoc_ID;
            KhoaHoc selected = cb.SelectedItem as KhoaHoc;
            id = selected.Khoahoc_ID;
            if(maloaikhoahoc == 1)
            {
                LoadListHocVienHocPhanKyThuatByIDHocVien(id, idhocvien);
                //AddHocVienDiemHPKTBiding();
            }
            else
            {
                LoadListHocVienHocPhanChungChiByIDHocVien(id, idhocvien);
                //AddHocVienDiemHPCCBiding();
            }
        }
        #endregion

        #region thinh
        void Load()
        {
            string b = nhcbb.Text;
            nhcbb.Items.Clear();

            dtlt.DataSource = null;
            DTO_HocVien_XemTTHocTap tt = new DTO_HocVien_XemTTHocTap(hkcbb.Text, b, ltcbb.Text);
            if (ltcbb.Text == "Tốt nghiệp")
            {
                hkcbb.Enabled = false;

                DataTable data = DAO.DAO_HocVien_XemTTHocTap.Instance.Select_HocVien_NamHoc(4);

                foreach (DataRow tmp in data.Rows)
                {
                    nhcbb.Items.Add(tmp["NamHoc"]);
                }

                dtlt.DataSource = DAO.DAO_HocVien_XemTTHocTap.Instance.Select_HocVien_LichThi(tt, 4);
            }
            else
            {
                hkcbb.Enabled = true;

                if (ltcbb.Text == "Chứng chỉ")
                {
                    DataTable data = DAO.DAO_HocVien_XemTTHocTap.Instance.Select_HocVien_NamHoc(2);

                    foreach (DataRow tmp in data.Rows)
                    {
                        nhcbb.Items.Add(tmp["NamHoc"]);
                    }

                    dtlt.DataSource = DAO.DAO_HocVien_XemTTHocTap.Instance.Select_HocVien_LichThi(tt, 2);
                }
                if (ltcbb.Text == "Kỹ thuật")
                {
                    DataTable data = DAO.DAO_HocVien_XemTTHocTap.Instance.Select_HocVien_NamHoc(1);

                    foreach (DataRow tmp in data.Rows)
                    {
                        nhcbb.Items.Add(tmp["NamHoc"]);
                    }

                    dtlt.DataSource = DAO.DAO_HocVien_XemTTHocTap.Instance.Select_HocVien_LichThi(tt, 1);
                }
            }
        }
        private void ltcbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nhcbb.Text == "" || nhcbb.Text == null || !Regex.IsMatch(nhcbb.Text, "[0-9]", RegexOptions.IgnoreCase))
            {
                nhcbb.Text = "2020";
            }
            if (hkcbb.Text == "" || hkcbb.Text == null || !Regex.IsMatch(hkcbb.Text, "[0-9]", RegexOptions.IgnoreCase))
            {
                hkcbb.Text = "1";
            }

            Load();
        }

        private void hkcbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltcbb.Text == "" || ltcbb.Text == null || !(ltcbb.Text == "Chứng chỉ" || ltcbb.Text == "Kỹ thuật" || ltcbb.Text == "Tốt nghiệp"))
            {
                ltcbb.Text = "Chứng chỉ";
            }
            if (nhcbb.Text == "" || nhcbb.Text == null || !Regex.IsMatch(nhcbb.Text, "[0-9]", RegexOptions.IgnoreCase))
            {
                nhcbb.Text = "2020";
            }

            Load();
        }

        private void nhcbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltcbb.Text == "" || ltcbb.Text == null || !(ltcbb.Text == "Chứng chỉ" || ltcbb.Text == "Kỹ thuật" || ltcbb.Text == "Tốt nghiệp"))
            {
                ltcbb.Text = "Chứng chỉ";
            }
            if (hkcbb.Text == "" || hkcbb.Text == null || !Regex.IsMatch(hkcbb.Text, "[0-9]", RegexOptions.IgnoreCase))
            {
                hkcbb.Text = "1";
            }

            Load();
        }
        //------------------------------------------------p3------------------------------------------------
        void P3Load()
        {
            string b = p3nh.Text;
            p3nh.Items.Clear();
            p3nh.Text = b;
            p3dtgv.DataSource = null;

            DTO_HocVien_XemTTHocTap tt = new DTO_HocVien_XemTTHocTap(p3hocki.Text, b, p3lichhoc.Text);
            if (p3lichhoc.Text == "Chuyên đề")
            {
                p3hocki.Enabled = false;

                DataTable data = DAO.DAO_HocVien_XemTTHocTap.Instance.Select_HocVien_NamHoc(3);

                foreach (DataRow tmp in data.Rows)
                {
                    p3nh.Items.Add(tmp["NamHoc"]);
                }

                p3dtgv.DataSource = DAO.DAO_HocVien_XemTTHocTap.Instance.Select_HocVien_LichHoc(tt, 3);
            }
            else
            {
                p3hocki.Enabled = true;

                if (p3lichhoc.Text == "Chứng chỉ")
                {
                    DataTable data = DAO.DAO_HocVien_XemTTHocTap.Instance.Select_HocVien_NamHoc(2);

                    foreach (DataRow tmp in data.Rows)
                    {
                        p3nh.Items.Add(tmp["NamHoc"]);
                    }

                    p3dtgv.DataSource = DAO.DAO_HocVien_XemTTHocTap.Instance.Select_HocVien_LichHoc(tt, 2);
                }
                if (p3lichhoc.Text == "Kỹ thuật")
                {
                    DataTable data = DAO.DAO_HocVien_XemTTHocTap.Instance.Select_HocVien_NamHoc(1);

                    foreach (DataRow tmp in data.Rows)
                    {
                        p3nh.Items.Add(tmp["NamHoc"]);
                    }

                    p3dtgv.DataSource = DAO.DAO_HocVien_XemTTHocTap.Instance.Select_HocVien_LichHoc(tt, 1);
                }
            }
        }
        private void p3lichhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (p3nh.Text == "" || p3nh.Text == null || !Regex.IsMatch(p3nh.Text, "[0-9]", RegexOptions.IgnoreCase))
            {
                p3nh.Text = "2020";
            }
            if (p3hocki.Text == "" || p3hocki.Text == null || !Regex.IsMatch(p3hocki.Text, "[0-9]", RegexOptions.IgnoreCase))
            {
                p3hocki.Text = "1";
            }

            P3Load();
        }

        private void p3hocki_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (p3nh.Text == "" || p3nh.Text == null || !Regex.IsMatch(p3nh.Text, "[0-9]", RegexOptions.IgnoreCase))
            {
                p3nh.Text = "2020";
            }
            if (p3lichhoc.Text == "" || p3lichhoc.Text == null)
            {
                p3lichhoc.Text = "Chứng chỉ";
            }

            P3Load();
        }

        private void p3nh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (p3hocki.Text == "" || p3hocki.Text == null || !Regex.IsMatch(p3hocki.Text, "[0-9]", RegexOptions.IgnoreCase))
            {
                p3hocki.Text = "1";
            }
            if (p3lichhoc.Text == "" || p3lichhoc.Text == null)
            {
                p3lichhoc.Text = "Chứng chỉ";
            }

            P3Load();
        }
        #endregion

    }
}
