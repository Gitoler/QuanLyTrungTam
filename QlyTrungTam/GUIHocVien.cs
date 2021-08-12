using QlyTrungTam.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlyTrungTam
{
    public partial class GUIHocVien : Form
    {
        BindingSource khoahocList = new BindingSource();
        int idhocvien = DAO_HocVien.Instance.GetIDHocVienByUserName();
        public GUIHocVien()
        {
            InitializeComponent();
            LoadKhoaHocList();
            AddKhoaHocBiding();
        }

        private void GUIHocVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void qlttmnStrip_Click(object sender, EventArgs e)
        {
            GUIQuanLiThongTin ghv = new GUIQuanLiThongTin();
            this.Hide();
            ghv.ShowDialog();
            this.Show();
        }

        private void xtthtmni_Click(object sender, EventArgs e)
        {
            GUIXemTTHocTap ghv = new GUIXemTTHocTap();
            this.Hide();
            ghv.ShowDialog();
            this.Show();
        }
        void LoadKhoaHocList()
        {
            khoahocList.DataSource = DAO_KhoaHoc.Instance.GetKhoaHocListByIDHocVien(idhocvien);
            dtgvHVKhoaHoc.DataSource = khoahocList;
        }
        void AddKhoaHocBiding()
        {
            cbHVLoaiKhoaHoc.DataBindings.Add(new Binding("text", dtgvHVKhoaHoc.DataSource, "khoahoc_Loai_Name", true, DataSourceUpdateMode.Never));
            txbHVKhoaHocID.DataBindings.Add(new Binding("text", dtgvHVKhoaHoc.DataSource, "khoahoc_ID", true, DataSourceUpdateMode.Never));
            cbHVKhoaHocName.DataBindings.Add(new Binding("text", dtgvHVKhoaHoc.DataSource, "khoahoc_Name", true, DataSourceUpdateMode.Never));
            dtHVKhoaHocOpening.DataBindings.Add(new Binding("text", dtgvHVKhoaHoc.DataSource, "khoahoc_Opening", true, DataSourceUpdateMode.Never));
            rtxtHVMoTa.DataBindings.Add(new Binding("text", dtgvHVKhoaHoc.DataSource, "khoahoc_Status", true, DataSourceUpdateMode.Never));
        }


    }
}
