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
    public partial class GUIQuanLiTrungTam : Form
    {
        BindingSource hocvienList = new BindingSource();
        public GUIQuanLiTrungTam()
        {
            InitializeComponent();
            LoadQuanLiTrungTam();
        }
        #region Methods

        List<HocVien>  SearchHocVien(string hocvienname)
        {
            List<HocVien> listHocVien = DAO_HocVien.Instance.SearchHocVienListByName(hocvienname);
            return listHocVien;
        }
        void ShowHoaDon(int mahocvien, int makhoahoc)
        {
            LoaiKhoaHoc maloaikhoa = (LoaiKhoaHoc)cbLoaiKhoa.SelectedItem;
            int tmp1 = maloaikhoa.Loaikhoahoc_ID;
            if (tmp1 == 1)
            {
                ShowHoaDonNhomKyThuat(mahocvien, makhoahoc);
            }
            else if (tmp1 == 2)
            {
                ShowHoaDonChungChi(mahocvien, makhoahoc);
            }
            else
            {
                ShowHoaDonChuyenDe(mahocvien, makhoahoc);
            }
        }
        void ShowHoaDonChuyenDe(int mahocvien, int makhoahoc)
        {
            int TotalPrice = 0;
            lsvHoaDon.Items.Clear();
            List<HoaDonChuyenDe> listHoaDonChuyenDe = DAO_HoaDonChuyenDe.Instance.GetHoaDonChuyenDeListByMaHoaDon(DAO_HoaDon.Instance.GetUnpayMaHoaDonByMaHocVien(mahocvien, makhoahoc));
            foreach (HoaDonChuyenDe item in listHoaDonChuyenDe)
            {
                ListViewItem lsvItem = new ListViewItem(item.Hoadonchuyende_ID.ToString());
                lsvItem.SubItems.Add(item.Hoadonchuyende_KhoaHoc_Name.ToString());
                lsvItem.SubItems.Add(item.Hoadonchuyende_ChuyenDe_ID.ToString());
                lsvItem.SubItems.Add(item.Hoadonchuyende_ChuyenDe_Name.ToString());
                lsvItem.SubItems.Add(item.Hoadonchuyende_HocPhan_Price.ToString());
                lsvHoaDon.Items.Add(lsvItem);
                TotalPrice += item.Hoadonchuyende_HocPhan_Price;
            }
            txbTongTien.Text = TotalPrice.ToString();
        }
        void ShowHoaDonChungChi(int mahocvien, int makhoahoc)
        {
            int TotalPrice = 0;
            lsvHoaDon.Items.Clear();
            List<HoaDonChungChi> listHoaDonChungChi = DAO_HoaDonChungChi.Instance.GetHoaDonChungChiListByMaHoaDon(DAO_HoaDon.Instance.GetUnpayMaHoaDonByMaHocVien(mahocvien, makhoahoc));
            foreach (HoaDonChungChi item in listHoaDonChungChi)
            {
                ListViewItem lsvItem = new ListViewItem(item.Hoadonchungchi_ID.ToString());
                lsvItem.SubItems.Add(item.Hoadonchungchi_KhoaHoc_Name.ToString());
                lsvItem.SubItems.Add(item.Hoadonchungchi_MonHoc_ID.ToString());
                lsvItem.SubItems.Add(item.Hoadonchungchi_MonHoc_Name.ToString());
                lsvItem.SubItems.Add(item.Hoadonchungchi_HocPhan_Price.ToString());
                lsvHoaDon.Items.Add(lsvItem);
                TotalPrice += item.Hoadonchungchi_HocPhan_Price;
            }
            txbTongTien.Text = TotalPrice.ToString();
        }
        void ShowHoaDonNhomKyThuat(int mahocvien, int makhoahoc)
        {
            int TotalPrice = 0;
            lsvHoaDon.Items.Clear();
            List<HoaDonNhomKyThuat> listHoaDonNhomKyThuat = DAO_HoaDonNhomKyThuat.Instance.GetUnpayHoaDonNhomKyThuatListByMaHoaDon(DAO_HoaDon.Instance.GetUnpayMaHoaDonByMaHocVien(mahocvien, makhoahoc));
            foreach (HoaDonNhomKyThuat item in listHoaDonNhomKyThuat)
            {
                ListViewItem lsvItem = new ListViewItem(item.Hoadonnhomkythuat_ID.ToString());
                lsvItem.SubItems.Add(item.Hoadonnhomkythuat_KhoaHoc_Name.ToString());
                lsvItem.SubItems.Add(item.Hoadonnhomkythuat_NhomKyThuat_ID.ToString());
                lsvItem.SubItems.Add(item.Hoadonnhomkythuat_NhomKyThuat_Name.ToString());
                lsvItem.SubItems.Add(item.Hoadonnhomkythuat_NhomKyThuat_Price.ToString());
                lsvHoaDon.Items.Add(lsvItem);
                TotalPrice += item.Hoadonnhomkythuat_NhomKyThuat_Price;
            }
            txbTongTien.Text = TotalPrice.ToString();
        }

        void LoadQuanLiTrungTam()
        {
            dtgvHocVien.DataSource = hocvienList;
            LoadListHocVien();
            AddHocVienBiding();
            LoadLoaiKhoaHoc(cbLoaiKhoa);
        }
        void LoadListHocVien()
        {
            hocvienList.DataSource = DAO_HocVien.Instance.GetHocVienList();
        }
        void AddHocVienBiding()
        {
            txbHVName.DataBindings.Add(new Binding("text", dtgvHocVien.DataSource, "hocvien_Name", true, DataSourceUpdateMode.Never));
            txbHVEmail.DataBindings.Add(new Binding("text", dtgvHocVien.DataSource, "hocvien_Email", true, DataSourceUpdateMode.Never));
            txbHVID.DataBindings.Add(new Binding("text", dtgvHocVien.DataSource, "hocvien_ID", true, DataSourceUpdateMode.Never));
            txbHVSDT.DataBindings.Add(new Binding("text", dtgvHocVien.DataSource, "hocvien_SDT", true, DataSourceUpdateMode.Never));
        }
        void LoadChiTietKhoaKyThuatByIDKhoaHoc(ComboBox cb, int id)
        {
            List<ChiTietKhoaKyThuat> listChiTietKhoaKyThuat = DAO_ChiTietKhoaKyThuat.Instance.GetChiTietKhoaKyThuatListByIDKhoaHoc(id);
            cb.DataSource = listChiTietKhoaKyThuat;
            cb.DisplayMember = "chitietkhoakythuat_nhomhpkythuat_Name";
        }
        void LoadLoaiKhoaHoc(ComboBox cb)
        {
            List<LoaiKhoaHoc> listLoaiKhoaHoc = DAO_LoaiKhoaHoc.Instance.GetLoaiKhoaHocList();
            cb.DataSource = listLoaiKhoaHoc;
            cb.DisplayMember = "loaikhoahoc_Name";
        }
        void LoadKhoaHocByIDLoaiKhoaHoc(ComboBox cb, int id)
        {
            List<KhoaHoc> listKhoaHoc = DAO_KhoaHoc.Instance.GetKhoaHocListByIDLoai(id);
            cb.DataSource = listKhoaHoc;
            cb.DisplayMember = "khoahoc_Name";
        }
        #endregion

        #region Events

        private void tsmlkhoakythuat_Click(object sender, EventArgs e)
        {
            GUIKhoaKiThuat kktgui = new GUIKhoaKiThuat();
            kktgui.ShowDialog();
        }

        private void tsmlkhoachungchi_Click(object sender, EventArgs e)
        {
            GUIKhoaChungChi ccgui = new GUIKhoaChungChi();
            ccgui.ShowDialog();
        }

        private void tsmlkhoachuyende_Click(object sender, EventArgs e)
        {
            GUIKhoaChuyenDe cdgui = new GUIKhoaChuyenDe();
            cdgui.ShowDialog();
        }

        private void tsmlhocvien_Click(object sender, EventArgs e)
        {
            GUIQuanLiHocVien qlhvgui = new GUIQuanLiHocVien();
            qlhvgui.ShowDialog();
        }

        private void tsmlchuongtrinhdaotao_Click(object sender, EventArgs e)
        {
            GUIQuanLyChuongTrinhDaoTao ctdtgui = new GUIQuanLyChuongTrinhDaoTao();
            ctdtgui.ShowDialog();
        }

        private void tsmlnhanvien_Click(object sender, EventArgs e)
        {
            GUIQuanliNhanVien qlnv = new GUIQuanliNhanVien();
            qlnv.ShowDialog();
        }

        private void GUIQuanLiTrungTam_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bntHVThem_Click(object sender, EventArgs e)
        {
            string name = txbHVName.Text;
            string sdt = txbHVSDT.Text;
            string email = txbHVEmail.Text;

            if(DAO_HocVien.Instance.InsertHocVien(name,sdt,email))
            {
                MessageBox.Show("Thêm học viên thành công");
                LoadListHocVien();
            }
            else
            {
                MessageBox.Show("Lỗi thêm học viên");
            }

        }
        private void btnHVXoa_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbHVID.Text);

            if (DAO_HocVien.Instance.DeleteHocVien(id))
            {
                MessageBox.Show("Xóa học viên thành công");
                LoadListHocVien();
            }
            else
            {
                MessageBox.Show("Lỗi xóa học viên");
            }
        }
        private void btnHVSua_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbHVID.Text);
            string name = txbHVName.Text;
            string sdt = txbHVSDT.Text;
            string email = txbHVEmail.Text;

            if (DAO_HocVien.Instance.UpdateHocVien(id, name, sdt, email))
            {
                MessageBox.Show("Sửa học viên thành công");
                LoadListHocVien();
            }
            else
            {
                MessageBox.Show("Lỗi sửa học viên");
            }
        }
        private void cbLoaiKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            LoaiKhoaHoc selected = cb.SelectedItem as LoaiKhoaHoc;
            id = selected.Loaikhoahoc_ID;
            int tmp = Convert.ToInt32(checkHocLaiNhom.Checked);
            if (id == 1)
            {
                checkHocLaiNhom.Enabled = true;
                if (tmp == 1)
                {
                    cbCTNhomKyThuat.Enabled = true;
                }
                else
                {
                    cbCTNhomKyThuat.Enabled = false;
                }
            }
            else
            {
                checkHocLaiNhom.Enabled = false;
                cbCTNhomKyThuat.Enabled = false;
            }
            if (id == 2 || id == 1)
            {
                checkCapCC.Enabled = true;
            }
            else
            {
                checkCapCC.Enabled = false;
            }
            LoadKhoaHocByIDLoaiKhoaHoc(cbKhoa, id);

        }


        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            KhoaHoc selected = cb.SelectedItem as KhoaHoc;
            id = selected.Khoahoc_ID;
            LoadChiTietKhoaKyThuatByIDKhoaHoc(cbCTNhomKyThuat, id);
        }

        private void bntHVTimKiem_Click(object sender, EventArgs e)
        {
            string hocvienname = txbHVName.Text;
            hocvienList.DataSource = SearchHocVien(hocvienname);
        }

        private void btnXemHD_Click(object sender, EventArgs e)
        {
            LoaiKhoaHoc loaikhoa = (LoaiKhoaHoc)cbLoaiKhoa.SelectedItem;
            KhoaHoc khoahoc = (KhoaHoc)cbKhoa.SelectedItem;
            int tmp1 = loaikhoa.Loaikhoahoc_ID;
            int makhoahoc = khoahoc.Khoahoc_ID;
            int mahocvien = Convert.ToInt32(txbHVID.Text);
            if (tmp1 == 1)
            {
                ShowHoaDonNhomKyThuat(mahocvien, makhoahoc);
            }
            else if (tmp1 == 2)
            {
                ShowHoaDonChungChi(mahocvien, makhoahoc);
            }
            else
            {
                ShowHoaDonChuyenDe(mahocvien, makhoahoc);
            }

        }



        private void checkHocLaiNhom_CheckedChanged(object sender, EventArgs e)
        {
            LoaiKhoaHoc maloaikhoa = cbLoaiKhoa.SelectedItem as LoaiKhoaHoc;
            int tmp1 = maloaikhoa.Loaikhoahoc_ID;
            int tmp2 = Convert.ToInt32(checkHocLaiNhom.Checked);
            if (tmp1 == 1 && tmp2 == 1)
            {
                cbCTNhomKyThuat.Enabled = true;
            }
            else
            {
                cbCTNhomKyThuat.Enabled = false;
            }

        }

        private void btnHVDangKy_Click(object sender, EventArgs e)
        {
            KhoaHoc makhoahoc = cbKhoa.SelectedItem as KhoaHoc;
            int idkhoahoc = makhoahoc.Khoahoc_ID;
            LoaiKhoaHoc maloaikhoahoc = cbLoaiKhoa.SelectedItem as LoaiKhoaHoc;
            int idloaikhoahoc = maloaikhoahoc.Loaikhoahoc_ID;
            int idhocvien = Convert.ToInt32(txbHVID.Text);
            int tmp1 = Convert.ToInt32(checkHocLaiNhom.Checked);
            int tmp2 = Convert.ToInt32(checkCapCC.Checked);
            int tmp3 = Convert.ToInt32(nbSLCD.Value);
            if (tmp3 == 1)
            {
                if (idloaikhoahoc == 1 && tmp1 == 1)
                {
                    ChiTietKhoaKyThuat machitietkythuat = cbCTNhomKyThuat.SelectedItem as ChiTietKhoaKyThuat;
                    int idchitietkhoakythuat = machitietkythuat.Chitietkhoakythuat_ID;
                    int idhoadon = DAO_HoaDon.Instance.GetUnpayMaHoaDonKyThuatByMaHocVien(idhocvien, idkhoahoc);
                    if (idhoadon > 0)
                    {
                        if (tmp2 == 1)
                        {
                            if (DAO_HoaDonNhomKyThuat.Instance.InsertHoaDonCCNhomKyThuat(idhoadon, idchitietkhoakythuat))
                            {
                                MessageBox.Show("Đăng ký học lại nhóm kỹ thuật có cấp chứng chỉ thành công");
                                ShowHoaDon(idhocvien, idkhoahoc);
                            }
                            else
                            {
                                MessageBox.Show("Đăng ký học lại nhóm kỹ thuật có cấp chứng chỉ thất bại vì bạn chưa học khóa này");
                                ShowHoaDon(idhocvien, idkhoahoc);
                            }
                        }
                        else
                        {
                            if (DAO_HoaDonNhomKyThuat.Instance.InsertHoaDonNhomKyThuat(idhoadon, idchitietkhoakythuat))
                            {
                                MessageBox.Show("Đăng ký học lại nhóm kỹ thuật thành công");
                                ShowHoaDon(idhocvien, idkhoahoc);
                            }
                            else
                            {
                                MessageBox.Show("Đăng ký học lại nhóm kỹ thuật thất bại vì bạn chưa học khóa này");
                                ShowHoaDon(idhocvien, idkhoahoc);
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Đăng ký học lại nhóm kỹ thuật thất bại vì bạn chưa học khóa này");
                        ShowHoaDon(idhocvien, idkhoahoc);
                    }

                }
                else
                {
                    if (tmp2 == 1 && idloaikhoahoc == 1)
                    {
                        if (DAO_HoaDon.Instance.InsertHoaDonKyThuatCC(idhocvien, idkhoahoc))
                        {
                            MessageBox.Show("Đăng ký khóa học kỷ thuật có cấp chứng chỉ thành công");
                            ShowHoaDon(idhocvien, idkhoahoc);
                        }
                        else
                        {
                            MessageBox.Show("Lỗi Đăng ký khóa học kỷ thuật có cấp chứng chỉ");
                        }
                    }
                    else if (tmp2 == 1 && idloaikhoahoc == 2)
                    {
                        if (DAO_HoaDon.Instance.InsertHoaDonCC(idhocvien, idkhoahoc))
                        {
                            MessageBox.Show("Đăng ký khóa học chứng chỉ có cấp chứng chỉ thành công");
                            ShowHoaDon(idhocvien, idkhoahoc);
                        }
                        else
                        {
                            MessageBox.Show("Lỗi Đăng ký khóa học chứng chỉ có cấp chứng chỉ");
                        }
                    }
                    else
                    {
                        if (DAO_HoaDon.Instance.InsertHoaDon(idhocvien, idkhoahoc))
                        {
                            MessageBox.Show("Đăng ký khóa học thành công");
                            ShowHoaDon(idhocvien, idkhoahoc);
                        }
                        else
                        {
                            MessageBox.Show("Lỗi Đăng ký khóa học");
                        }
                    }
                }
            }
            else
            {
                if (idloaikhoahoc == 1 && tmp1 == 1)
                {
                    ChiTietKhoaKyThuat machitietkythuat = cbCTNhomKyThuat.SelectedItem as ChiTietKhoaKyThuat;
                    int idchitietkhoakythuat = machitietkythuat.Chitietkhoakythuat_ID;
                    int idhoadon = DAO_HoaDon.Instance.GetUnpayMaHoaDonKyThuatByMaHocVien(idhocvien, idkhoahoc);
                    int idchitiethoadonnhomkythuat = DAO_HoaDonNhomKyThuat.Instance.GetUnpayMaHoaDonChiTietNhomKyThuatByMaHoaDon(idhoadon, idchitietkhoakythuat);
                    if (DAO_HoaDonNhomKyThuat.Instance.DeleteHoaDonNhomKyThuat(idchitiethoadonnhomkythuat))
                    {
                        MessageBox.Show("Hủy đăng ký học lại nhóm kỹ thuật có cấp chứng chỉ thành công");
                        ShowHoaDon(idhocvien, idkhoahoc);
                    }
                    else
                    {
                        MessageBox.Show("Hủy đăng ký học lại nhóm kỹ thuật có cấp chứng chỉ thất bại vì bạn chưa học khóa này");
                        ShowHoaDon(idhocvien, idkhoahoc);
                    }
                }
                else
                {
                    if (DAO_HoaDon.Instance.DeleteHoaDon(idhocvien, idkhoahoc))
                    {
                        MessageBox.Show("Hủy đăng ký khóa học thành công");
                        ShowHoaDon(idhocvien, idkhoahoc);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi  hủy đăng ký khóa học");
                    }
                }
            }


        }

        private void btnHVThanhToan_Click(object sender, EventArgs e)
        {
            KhoaHoc makhoahoc = cbKhoa.SelectedItem as KhoaHoc;
            int idkhoahoc = makhoahoc.Khoahoc_ID;
            int idhocvien = Convert.ToInt32(txbHVID.Text);
            if (DAO_HoaDon.Instance.UpdateHoaDon(idhocvien, idkhoahoc))
            {
                MessageBox.Show("Thanh toán thành công");
                ShowHoaDon(idhocvien, idkhoahoc);
            }
            else
            {
                MessageBox.Show("Thanh toán thất bại");
            }
        }
        #endregion






    }
}
