using QlyTrungTam.DAO;
using QlyTrungTam.DTO;
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
    public partial class GUIQuanLiHocVien : Form
    {
        BindingSource chungchihocvienList = new BindingSource();
        BindingSource nhomcchocvienList = new BindingSource();
        BindingSource lichthitotnghiepList = new BindingSource();
        public GUIQuanLiHocVien()
        {
            InitializeComponent();
            LoadChungChiHocVienList();
            AddChungChiHocVienBiding();
            LoadNhomCCHocVienList();
            AddNhomCCHocVienBiding();
            LoadLichThiTotNghiep();
            AddLichThiTotNghiepBiding();
        }
        #region Methods
        List<NhomCCHocVien> SearchNhomCCHocVien(string hocvienname)
        {
            List<NhomCCHocVien> ListNhomCCHocVien = DAO_NhomCCHocVien.Instance.SearchNhomCCHocVienListByName(hocvienname);
            return ListNhomCCHocVien;
        }
        List<ChungChiHocVien> SearchChungChiHocVien(string hocvienname)
        {
            List<ChungChiHocVien> ListChungChiHocVien = DAO_ChungChiHocVien.Instance.SearchChungChiHocVienListByName(hocvienname);
            return ListChungChiHocVien;
        }
        void LoadLichThiTotNghiep()
        {
            lichthitotnghiepList.DataSource = DAO_LichThiTotNghiep.Instance.GetLichThiTotNghiepList();
            dtgvLTTotNghiep.DataSource = lichthitotnghiepList;
            cbLTTotnghiepKhoaName.DataSource = DAO_KhoaKyThuat.Instance.GetKhoaKyThuatList();
            cbLTTotnghiepKhoaName.DisplayMember = "khoakythuat_Name";

        }
        void LoadNhomCCHocVienList()
        {
            nhomcchocvienList.DataSource = DAO_NhomCCHocVien.Instance.GetNhomCCHocVienList();
            dtgvNhomCC.DataSource = nhomcchocvienList;
            List<string> tinhtrang = new List<string>();
            tinhtrang.Add("Không Yêu Cầu Cấp Chứng Chỉ");
            tinhtrang.Add("Yêu Cầu Cấp Chứng Chỉ");
            tinhtrang.Add("Thỏa Yêu Cầu Cấp Chứng Chỉ");
            tinhtrang.Add("Đã Cấp Chứng Chỉ");
            cbNhomCCTinhTrang.DataSource = tinhtrang;
            cbChungChiTinhTrang.DataSource = tinhtrang;

        }
        void LoadChungChiHocVienList()
        {
            chungchihocvienList.DataSource = DAO_ChungChiHocVien.Instance.GetChungChiHocVienList();
            dtgvChungChiHocVien.DataSource = chungchihocvienList;
        }
        void AddChungChiHocVienBiding()
        {
            txbChungChiID.DataBindings.Add(new Binding("text", dtgvChungChiHocVien.DataSource, "hocvien_HoaDon_ID", true, DataSourceUpdateMode.Never));
            txbHocVienID.DataBindings.Add(new Binding("text", dtgvChungChiHocVien.DataSource, "hocvien_ID", true, DataSourceUpdateMode.Never));
            txbHocVienName.DataBindings.Add(new Binding("text", dtgvChungChiHocVien.DataSource, "hocvien_Name", true, DataSourceUpdateMode.Never));
            txbKhoaID.DataBindings.Add(new Binding("text", dtgvChungChiHocVien.DataSource, "hocvien_KhoaChungChi_ID", true, DataSourceUpdateMode.Never));
            txbTenKhoa.DataBindings.Add(new Binding("text", dtgvChungChiHocVien.DataSource, "hocvien_KhoaChungChi_Name", true, DataSourceUpdateMode.Never));
            dtKhoahocLauching.DataBindings.Add(new Binding("text", dtgvChungChiHocVien.DataSource, "hocvien_KhoaChungChi_Lauching", true, DataSourceUpdateMode.Never));
            txbChungChi.DataBindings.Add(new Binding("text", dtgvChungChiHocVien.DataSource, "hocvien_ChungChi_Name", true, DataSourceUpdateMode.Never));
            txbTinhTrang.DataBindings.Add(new Binding("text", dtgvChungChiHocVien.DataSource, "hocvien_ChungChi_Status", true, DataSourceUpdateMode.Never)); ;
        }

        void AddNhomCCHocVienBiding()
        {
            txbNhomCCID.DataBindings.Add(new Binding("text", dtgvNhomCC.DataSource, "hocvien_HDNHomCC_ID", true, DataSourceUpdateMode.Never));
            txbHocVienNhomCCID.DataBindings.Add(new Binding("text", dtgvNhomCC.DataSource, "hocvien_ID", true, DataSourceUpdateMode.Never));
            txbHocVienNhomCCName.DataBindings.Add(new Binding("text", dtgvNhomCC.DataSource, "hocvien_Name", true, DataSourceUpdateMode.Never));
            txbKhoaNhomCCID.DataBindings.Add(new Binding("text", dtgvNhomCC.DataSource, "hocvien_KhoaKyThuat_ID", true, DataSourceUpdateMode.Never));
            txbKhoaNhomCCName.DataBindings.Add(new Binding("text", dtgvNhomCC.DataSource, "hocvien_KhoaKyThuat_Name", true, DataSourceUpdateMode.Never));
            dtNhomCCLauching.DataBindings.Add(new Binding("text", dtgvNhomCC.DataSource, "hocvien_KhoaKyThuat_Lauching", true, DataSourceUpdateMode.Never));
            txbNhomCCName.DataBindings.Add(new Binding("text", dtgvNhomCC.DataSource, "hocvien_NhomCC_Name", true, DataSourceUpdateMode.Never));
            txbNhomCCTinhTrang.DataBindings.Add(new Binding("text", dtgvNhomCC.DataSource, "hocvien_NhomCC_Status", true, DataSourceUpdateMode.Never));
        }

        void AddLichThiTotNghiepBiding()
        {
            txbLTTotNghiepID.DataBindings.Add(new Binding("text", dtgvLTTotNghiep.DataSource, "lichthitotnghiep_ID", true, DataSourceUpdateMode.Never));
            txbLTTotNghiepKhoaID.DataBindings.Add(new Binding("text", dtgvLTTotNghiep.DataSource, "lichthitotnghiep_KhoaKyThuat_ID", true, DataSourceUpdateMode.Never));
            cbLTTotnghiepKhoaName.DataBindings.Add(new Binding("text", dtgvLTTotNghiep.DataSource, "lichthitotnghiep_KhoaKyThuat_Name", true, DataSourceUpdateMode.Never));
            dtLTTotNghiepNT.DataBindings.Add(new Binding("text", dtgvLTTotNghiep.DataSource, "lichthitotnghiep_Opening", true, DataSourceUpdateMode.Never));
            txbLTTotNghiepLanThi.DataBindings.Add(new Binding("text", dtgvLTTotNghiep.DataSource, "lichthitotnghiep_LanThi", true, DataSourceUpdateMode.Never));
            txbLTTotNghiepPT.DataBindings.Add(new Binding("text", dtgvLTTotNghiep.DataSource, "lichthitotnghiep_PhongThi", true, DataSourceUpdateMode.Never));
        }
        #endregion
        #region Events

        private void btnXemHVCC_Click(object sender, EventArgs e)
        {
            LoadChungChiHocVienList();
        }

        private void btnSuaHVCC_Click(object sender, EventArgs e)
        {
            int mahoadon = Convert.ToInt32(txbChungChiID.Text);
            string tmp = cbChungChiTinhTrang.Text;
            int tinhtrang;

            if (tmp == "Không Yêu Cầu Cấp Chứng Chỉ")
            {
                tinhtrang = 0;
            }
            else if (tmp == "Yêu Cầu Cấp Chứng Chỉ")
            {
                tinhtrang = 1;
            }
            else if (tmp == "Thỏa Yêu Cầu Cấp Chứng Chỉ")
            {
                tinhtrang = 2;
            }
            else
            {
                tinhtrang = 3;
            }
            if (DAO_ChungChiHocVien.Instance.UpdateChungChiHocVien(mahoadon, tinhtrang))
            {
                MessageBox.Show("Sửa chứng chỉ học viên thành công");
                LoadChungChiHocVienList();
            }
            else
            {
                MessageBox.Show("Lỗi sửa chứng chỉ học viên");
            }
        }


        private void btnTimKiemHVCC_Click(object sender, EventArgs e)
        {
            string hocvienname = txbTimKiemChungChiHV.Text;
            chungchihocvienList.DataSource = SearchChungChiHocVien(hocvienname);
        }


        private void btnSuaNhomCC_Click(object sender, EventArgs e)
        {
            int machitiethoadon = Convert.ToInt32(txbNhomCCID.Text);
            string tmp = cbNhomCCTinhTrang.Text;
            int tinhtrang;

            if (tmp == "Không Yêu Cầu Cấp Chứng Chỉ")
            {
                tinhtrang = 0;
            }
            else if (tmp == "Yêu Cầu Cấp Chứng Chỉ")
            {
                tinhtrang = 1;
            }
            else if (tmp == "Thỏa Yêu Cầu Cấp Chứng Chỉ")
            {
                tinhtrang = 2;
            }
            else
            {
                tinhtrang = 3;
            }
            if (DAO_NhomCCHocVien.Instance.UpdateNhomCCHocVien(machitiethoadon, tinhtrang))
            {
                MessageBox.Show("Sửa tình trạng nhóm chứng chỉ kỷ thuật thành công");
                LoadNhomCCHocVienList();
            }
            else
            {
                MessageBox.Show("Lỗi sửa tình trạng nhóm chứng chỉ kỷ thuật");
            }
        }

        private void btnXemNhomCC_Click(object sender, EventArgs e)
        {
            LoadNhomCCHocVienList();
        }

        private void btnLTTotNghiepThem_Click(object sender, EventArgs e)
        {
            int makhoahoc = Convert.ToInt32(txbLTTotNghiepKhoaID.Text);
            string phongthi = txbLTTotNghiepPT.Text.ToString();
            int lanthi = Convert.ToInt32(txbLTTotNghiepLanThi.Text);
            DateTime ngaythi = dtLTTotNghiepNT.Value;
            if (DAO_LichThiTotNghiep.Instance.InsertLichThiTotNghiep(makhoahoc, phongthi, lanthi, ngaythi))
            {
                MessageBox.Show("Thêm lịch thi tốt nghiệp thành công");
                LoadLichThiTotNghiep();
            }
            else
            {
                MessageBox.Show("Lỗi thêm lịch thi tốt nghiệp");
            }
        }

        private void btnLTTotNghiepSua_Click(object sender, EventArgs e)
        {
            int makhoahoc = Convert.ToInt32(txbLTTotNghiepKhoaID.Text);
            string phongthi = txbLTTotNghiepPT.Text.ToString();
            int lanthi = Convert.ToInt32(txbLTTotNghiepLanThi.Text);
            DateTime ngaythi = dtLTTotNghiepNT.Value;
            if (DAO_LichThiTotNghiep.Instance.UpdateLichThiTotNghiep(makhoahoc, phongthi, lanthi, ngaythi))
            {
                MessageBox.Show("Sửa lịch thi tốt nghiệp thành công");
                LoadLichThiTotNghiep();
            }
            else
            {
                MessageBox.Show("Lỗi sửa lịch thi tốt nghiệp");
            }
        }

        private void cbLTTotnghiepKhoaName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            KhoaKyThuat selected = cb.SelectedItem as KhoaKyThuat;
            id = selected.Khoakythuat_ID;
            txbLTTotNghiepKhoaID.Text = id.ToString();
        }

        private void txbNhomCCTinhTrang_TextChanged(object sender, EventArgs e)
        {
            int tmp;
            try
            {
                tmp = Convert.ToInt32(txbNhomCCTinhTrang.Text);

                if (tmp == 0)
                {
                    txbNhomCCTinhTrang.Text = "Không Yêu Cầu Cấp Chứng Chỉ";
                }
                else if (tmp == 1)
                {
                    txbNhomCCTinhTrang.Text = "Yêu Cầu Cấp Chứng Chỉ";
                }
                else if (tmp == 2)
                {
                    txbNhomCCTinhTrang.Text = "Thỏa Yêu Cầu Cấp Chứng Chỉ";
                }
                else
                {
                    txbNhomCCTinhTrang.Text = "Đã Cấp Chứng Chỉ";
                }
            }
            catch
            {
           
            }
        }

        private void txbTinhTrang_TextChanged(object sender, EventArgs e)
        {
            int tmp;
            try
            {
                tmp = Convert.ToInt32(txbTinhTrang.Text);

                if (tmp == 0)
                {
                    txbTinhTrang.Text = "Không Yêu Cầu Cấp Chứng Chỉ";
                }
                else if (tmp == 1)
                {
                    txbTinhTrang.Text = "Yêu Cầu Cấp Chứng Chỉ";
                }
                else if (tmp == 2)
                {
                    txbTinhTrang.Text = "Thỏa Yêu Cầu Cấp Chứng Chỉ";
                }
                else
                {
                    txbTinhTrang.Text = "Đã Cấp Chứng Chỉ";
                }
            }
            catch
            {

            }
        }
        #endregion

        private void btnTimKiemNhomCC_Click(object sender, EventArgs e)
        {
            string hocvienname = txbTimKiemNhomCC.Text;
            nhomcchocvienList.DataSource = SearchNhomCCHocVien(hocvienname);
        }
    }
}
