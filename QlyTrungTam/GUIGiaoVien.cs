using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QlyTrungTam.DAO;
using QlyTrungTam.DTO;

namespace QlyTrungTam
{
    public partial class GUIGiaoVien : Form
    {
        BindingSource giaovienhocphanchungchiList = new BindingSource();
        BindingSource giaovienhocphankythuatList = new BindingSource();
        BindingSource giaovientotnghiepList = new BindingSource();
        int idgiaovien = DAO_GiaoVien.Instance.GetIDGiaoVienByUserName();
        public GUIGiaoVien()
        {
            InitializeComponent();
            LoadListGiaoVienHocPhanChungChiByIDGiaoVien(idgiaovien);
            AddGiaoVienHocPhanChungChiBiding();
            LoadKhoaHocChungChiByIDGiaoVien(cbHPCCKhoaName, idgiaovien);
            LoadListGiaoVienHocPhanKyThuatByIDGiaoVien(idgiaovien);
            AddGiaoVienHocPhanKyThuatBiding();
            LoadKhoaHocKyThuatByIDGiaoVien(cbHPKTKhoaName, idgiaovien);
            LoadListGiaoVienTotNghiep();
            AddGiaoVienTotNghiepBiding();
            LoadKhoaHocTotNghiep(cbTNKhoaName);
        }
        #region Methods
        List<GiaoVienHocPhanChungChi> SearchHPCCHocVien(string hocvienname)
        {
            List<GiaoVienHocPhanChungChi> listGiaoVienHocPhanChungChi = DAO_GiaoVienHocPhanChungChi.Instance.SearchGiaoVienHocPhanChungChiListByName(hocvienname);
            return listGiaoVienHocPhanChungChi;
        }

        List<GiaoVienHocPhanKyThuat> SearchHPKTHocVien(string hocvienname)
        {
            List<GiaoVienHocPhanKyThuat> listGiaoVienHocPhanKyThuat = DAO_GiaoVienHocPhanKyThuat.Instance.SearchGiaoVienHocPhanKyThuatListByName(hocvienname);
            return listGiaoVienHocPhanKyThuat;
        }
        List<GiaoVienTotNghiep> SearchTNHocVien(string hocvienname)
        {
            List<GiaoVienTotNghiep> listGiaoVienTotNghiep = DAO_GiaoVienTotNghiep.Instance.SearchGiaoVienTotNghiepListByName(hocvienname);
            return listGiaoVienTotNghiep;
        }
        void LoadListGiaoVienHocPhanChungChiByIDGiaoVien(int id)
        {
            giaovienhocphanchungchiList.DataSource = DAO_GiaoVienHocPhanChungChi.Instance.GetGiaoVienHocPhanChungChiListByIDGiaoVien(id);
            dtgvHPCC.DataSource = giaovienhocphanchungchiList;
        }
        void LoadListGiaoVienHocPhanKyThuatByIDGiaoVien(int id)
        {
            giaovienhocphankythuatList.DataSource = DAO_GiaoVienHocPhanKyThuat.Instance.GetGiaoVienHocPhanKyThuatListByIDGiaoVien(id);
            dtgvHPKT.DataSource = giaovienhocphankythuatList;
        }

        void LoadListGiaoVienTotNghiep()
        {
            giaovientotnghiepList.DataSource = DAO_GiaoVienTotNghiep.Instance.GetGiaoVienTotNghiepList();
            dtgvTN.DataSource = giaovientotnghiepList;
        }
        void LoadListGiaoVienTotNghiepByIDKhoaHoc(int idkhoahoc)
        {
            giaovientotnghiepList.DataSource = DAO_GiaoVienTotNghiep.Instance.GetGiaoVienTotNghiepListByIDKhoaHoc(idkhoahoc);
            dtgvTN.DataSource = giaovientotnghiepList;
        }
        void LoadListGiaoVienTotNghiepByLanThi(int idkhoahoc,int lanthi)
        {
            giaovientotnghiepList.DataSource = DAO_GiaoVienTotNghiep.Instance.GetGiaoVienTotNghiepListByLanThi(idkhoahoc, lanthi);
            dtgvTN.DataSource = giaovientotnghiepList;
        }
        void LoadListGiaoVienTotNghiepByHocVien(int idkhoahoc,int  lanthi,int  idhocvien)
        {
            giaovientotnghiepList.DataSource = DAO_GiaoVienTotNghiep.Instance.GetGiaoVienTotNghiepListByIDHocVien(idkhoahoc, lanthi, idhocvien);
            dtgvTN.DataSource = giaovientotnghiepList;
        }
        void LoadListGiaoVienHocPhanChungChiByIDKhoaHoc(int idkhoahoc, int idgiaovien)
        {
            giaovienhocphanchungchiList.DataSource = DAO_GiaoVienHocPhanChungChi.Instance.GetGiaoVienHocPhanChungChiListByIDKhoaHoc(idkhoahoc, idgiaovien);
            dtgvHPCC.DataSource = giaovienhocphanchungchiList;
        }

        void LoadListGiaoVienHocPhanKyThuatByIDKhoaHoc(int idkhoahoc, int idgiaovien)
        {
            giaovienhocphankythuatList.DataSource = DAO_GiaoVienHocPhanKyThuat.Instance.GetGiaoVienHocPhanKyThuatListByIDKhoaHoc(idkhoahoc, idgiaovien);
            dtgvHPKT.DataSource = giaovienhocphankythuatList;
        }
        void LoadListGiaoVienHocPhanChungChiByIDHPCC(int idkhoahoc, int idhpcc, int idgiaovien)
        {
            giaovienhocphanchungchiList.DataSource = DAO_GiaoVienHocPhanChungChi.Instance.GetGiaoVienHocPhanChungChiListByIDHPCC(idkhoahoc, idhpcc, idgiaovien);
            dtgvHPCC.DataSource = giaovienhocphanchungchiList;
        }

        void LoadListGiaoVienHocPhanKyThuatByIDHPKT(int idkhoahoc, int idhpkt, int idgiaovien)
        {
            giaovienhocphankythuatList.DataSource = DAO_GiaoVienHocPhanKyThuat.Instance.GetGiaoVienHocPhanKyThuatListByIDHPKT(idkhoahoc, idhpkt, idgiaovien);
            dtgvHPKT.DataSource = giaovienhocphankythuatList;
        }

        void LoadListGiaoVienHocPhanKyThuatByLanThi(int idkhoahoc, int idhpkt, int lanthi, int idgiaovien)
        {
            giaovienhocphankythuatList.DataSource = DAO_GiaoVienHocPhanKyThuat.Instance.GetGiaoVienHocPhanKyThuatListByLanThi(idkhoahoc, idhpkt, lanthi, idgiaovien);
            dtgvHPKT.DataSource = giaovienhocphankythuatList;
        }

        void LoadListGiaoVienHocPhanChungChiByIDHocVien(int idkhoahoc, int idhpcc, int idgiaovien, int idhocvien)
        {
            giaovienhocphanchungchiList.DataSource = DAO_GiaoVienHocPhanChungChi.Instance.GetGiaoVienHocPhanChungChiListByIDHocVien(idkhoahoc, idhpcc, idgiaovien, idhocvien);
            dtgvHPCC.DataSource = giaovienhocphanchungchiList;
        }

        void LoadListGiaoVienHocPhanKyThuatByIDHocVien(int idkhoahoc, int idhpkt, int lanthi, int idgiaovien, int idhocvien)
        {
            giaovienhocphankythuatList.DataSource = DAO_GiaoVienHocPhanKyThuat.Instance.GetGiaoVienHocPhanKyThuatListByIDHocVien(idkhoahoc, idhpkt, lanthi, idgiaovien, idhocvien);
            dtgvHPKT.DataSource = giaovienhocphankythuatList;
        }
        void AddGiaoVienHocPhanChungChiBiding()
        {
            txbHPCCGiaoVienID.DataBindings.Add(new Binding("text", dtgvHPCC.DataSource, "giaovien_ID", true, DataSourceUpdateMode.Never));
            txbHPCCGiaoVienName.DataBindings.Add(new Binding("text", dtgvHPCC.DataSource, "giaovien_Name", true, DataSourceUpdateMode.Never));
            txbHPCCKhoaID.DataBindings.Add(new Binding("text", dtgvHPCC.DataSource, "giaovien_KhoaHoc_ID", true, DataSourceUpdateMode.Never));
            cbHPCCKhoaName.DataBindings.Add(new Binding("text", dtgvHPCC.DataSource, "giaovien_KhoaHoc_Name", true, DataSourceUpdateMode.Never));
            txbHPCCID.DataBindings.Add(new Binding("text", dtgvHPCC.DataSource, "giaovien_HPCC_ID", true, DataSourceUpdateMode.Never));
            txbHPCCHocVienID.DataBindings.Add(new Binding("text", dtgvHPCC.DataSource, "giaovien_HocVien_ID", true, DataSourceUpdateMode.Never));
            cbHPCCHocVienName.DataBindings.Add(new Binding("text", dtgvHPCC.DataSource, "giaovien_HocVien_Name", true, DataSourceUpdateMode.Never));
            txbHPCCMonHocID.DataBindings.Add(new Binding("text", dtgvHPCC.DataSource, "giaovien_MonHoc_ID", true, DataSourceUpdateMode.Never));
            cbHPCCMonHocName.DataBindings.Add(new Binding("text", dtgvHPCC.DataSource, "giaovien_MonHoc_Name", true, DataSourceUpdateMode.Never));
            txbHPCCHocKy.DataBindings.Add(new Binding("text", dtgvHPCC.DataSource, "giaovien_HPCC_KyHoc", true, DataSourceUpdateMode.Never));
            txbHPCCNam.DataBindings.Add(new Binding("text", dtgvHPCC.DataSource, "giaovien_HPCC_NamHoc", true, DataSourceUpdateMode.Never));
            txbHPCCLichHoc.DataBindings.Add(new Binding("text", dtgvHPCC.DataSource, "giaovien_HPCC_LichHoc", true, DataSourceUpdateMode.Never));
            dtHPCCLichThi.DataBindings.Add(new Binding("text", dtgvHPCC.DataSource, "giaovien_HPCC_LichThi", true, DataSourceUpdateMode.Never));
            txbHPCCDiem.DataBindings.Add(new Binding("text", dtgvHPCC.DataSource, "giaovien_HPCC_Diem", true, DataSourceUpdateMode.Never));
            txbHPCCDiemID.DataBindings.Add(new Binding("text", dtgvHPCC.DataSource, "giaovien_HPCC_Diem_ID", true, DataSourceUpdateMode.Never));
        }

        void AddGiaoVienHocPhanKyThuatBiding()
        {
            txbHPKTGiaoVienID.DataBindings.Add(new Binding("text", dtgvHPKT.DataSource, "giaovien_ID", true, DataSourceUpdateMode.Never));
            txbHPKTGiaoVienName.DataBindings.Add(new Binding("text", dtgvHPKT.DataSource, "giaovien_Name", true, DataSourceUpdateMode.Never));
            txbHPKTKhoaID.DataBindings.Add(new Binding("text", dtgvHPKT.DataSource, "giaovien_KhoaHoc_ID", true, DataSourceUpdateMode.Never));
            cbHPKTKhoaName.DataBindings.Add(new Binding("text", dtgvHPKT.DataSource, "giaovien_KhoaHoc_Name", true, DataSourceUpdateMode.Never));
            txbHPKTID.DataBindings.Add(new Binding("text", dtgvHPKT.DataSource, "giaovien_HPKT_ID", true, DataSourceUpdateMode.Never));
            txbHPKTHocVienID.DataBindings.Add(new Binding("text", dtgvHPKT.DataSource, "giaovien_HocVien_ID", true, DataSourceUpdateMode.Never));
            cbHPKTHocVienName.DataBindings.Add(new Binding("text", dtgvHPKT.DataSource, "giaovien_HocVien_Name", true, DataSourceUpdateMode.Never));
            txbHPKTMonHocID.DataBindings.Add(new Binding("text", dtgvHPKT.DataSource, "giaovien_MonHoc_ID", true, DataSourceUpdateMode.Never));
            cbHPKTMonHocName.DataBindings.Add(new Binding("text", dtgvHPKT.DataSource, "giaovien_MonHoc_Name", true, DataSourceUpdateMode.Never));
            txbHPKTHocKy.DataBindings.Add(new Binding("text", dtgvHPKT.DataSource, "giaovien_HPKT_KyHoc", true, DataSourceUpdateMode.Never));
            txbHPKTNamHoc.DataBindings.Add(new Binding("text", dtgvHPKT.DataSource, "giaovien_HPKT_NamHoc", true, DataSourceUpdateMode.Never));
            txbHPKTLichHoc.DataBindings.Add(new Binding("text", dtgvHPKT.DataSource, "giaovien_HPKT_LichHoc", true, DataSourceUpdateMode.Never));
            dtHPKTLichThi.DataBindings.Add(new Binding("text", dtgvHPKT.DataSource, "giaovien_HPKT_LichThi", true, DataSourceUpdateMode.Never));
            txbHPKTDiem.DataBindings.Add(new Binding("text", dtgvHPKT.DataSource, "giaovien_HPKT_Diem", true, DataSourceUpdateMode.Never));
            txbHPKTDiemID.DataBindings.Add(new Binding("text", dtgvHPKT.DataSource, "giaovien_HPKT_Diem_ID", true, DataSourceUpdateMode.Never));
            txbHPKTNhomKTName.DataBindings.Add(new Binding("text", dtgvHPKT.DataSource, "giaovien_HPKT_NhomKT_Name", true, DataSourceUpdateMode.Never));
            cbHPKTLanThi.DataBindings.Add(new Binding("text", dtgvHPKT.DataSource, "giaovien_HPKT_LanThi", true, DataSourceUpdateMode.Never));
        }

        void AddGiaoVienTotNghiepBiding()
        {
            txbTNDiemID.DataBindings.Add(new Binding("text", dtgvTN.DataSource, "giaovientotnghiep_Diem_ID", true, DataSourceUpdateMode.Never));
            txbTNDiem.DataBindings.Add(new Binding("text", dtgvTN.DataSource, "giaovientotnghiep_Diem", true, DataSourceUpdateMode.Never));
            txbTNKhoaID.DataBindings.Add(new Binding("text", dtgvTN.DataSource, "giaovientotnghiep_Khoa_ID", true, DataSourceUpdateMode.Never));
            cbTNKhoaName.DataBindings.Add(new Binding("text", dtgvTN.DataSource, "giaovientotnghiep_Khoa_Name", true, DataSourceUpdateMode.Never));
            dtTNLichThi.DataBindings.Add(new Binding("text", dtgvTN.DataSource, "giaovientotnghiep_LichThi", true, DataSourceUpdateMode.Never));
            cbTNLanThi.DataBindings.Add(new Binding("text", dtgvTN.DataSource, "giaovientotnghiep_LanThi", true, DataSourceUpdateMode.Never));
            cbTNHocVienName.DataBindings.Add(new Binding("text", dtgvTN.DataSource, "giaovientotnghiep_HocVien_Name", true, DataSourceUpdateMode.Never));
            txbTNHocVienID.DataBindings.Add(new Binding("text", dtgvTN.DataSource, "giaovientotnghiep_HocVien_ID", true, DataSourceUpdateMode.Never));
            txbTNGiaoVienID.DataBindings.Add(new Binding("text", dtgvTN.DataSource, "giaovientotnghiep_GiaoVien_ID", true, DataSourceUpdateMode.Never));

        }
        void LoadKhoaHocTotNghiep(ComboBox cb)
        {
            List<KhoaHoc> listKhoaHoc = DAO_KhoaHoc.Instance.GetKhoaHocTotNghiep();
            cb.DataSource = listKhoaHoc;
            cb.DisplayMember = "khoahoc_Name";
        }
        void LoadLanThiByKhoaHocTotNgiep(ComboBox cb, int idkhoahoc)
        {
            List<LichThiTotNghiep> listLichThiTotNghiep = DAO_LichThiTotNghiep.Instance.GetLichThiTotNghiepLanThiListByIDKhoaHoc(idkhoahoc);
            cb.DataSource = listLichThiTotNghiep;
            cb.DisplayMember = "lichthitotnghiep_LanThi";
        }
        void LoadHocVienTotNghiepByLanThi(ComboBox cb, int idkhoahoc, int lanthi)
        {
            List<HocVien> listHocVien = DAO_HocVien.Instance.GetHocVienTotNghiepListByLanThi(idkhoahoc, lanthi);
            cb.DataSource = listHocVien;
            cb.DisplayMember = "Hocvien_Name";
        }
        void LoadKhoaHocChungChiByIDGiaoVien(ComboBox cb, int id)
        {
            List<KhoaHoc> listKhoaHoc = DAO_KhoaHoc.Instance.GetKhoaHocChungChiListByIDGiaoVien(id);
            cb.DataSource = listKhoaHoc;
            cb.DisplayMember = "khoahoc_Name";
        }
        void LoadMonHocByKhoaHocChungChi(ComboBox cb, int idkhoahoc, int idgiaovien)
        {
            List<HocPhanChungChi> listHocPhanChungChi = DAO_HocPhanChungChi.Instance.GetHocPhanChungChiListByMaKhoaHoc(idkhoahoc, idgiaovien);
            cb.DataSource = listHocPhanChungChi;
            cb.DisplayMember = "Hocphanchungchi_MonHoc_Name";
        }
        void LoadHocVienByHPCC(ComboBox cb, int idhpcc)
        {
            List<HocVien> listHocVien = DAO_HocVien.Instance.GetHocVienListByMaHPCC(idhpcc);
            cb.DataSource = listHocVien;
            cb.DisplayMember = "Hocvien_Name";
        }

        void LoadKhoaHocKyThuatByIDGiaoVien(ComboBox cb, int id)
        {
            List<KhoaHoc> listKhoaHoc = DAO_KhoaHoc.Instance.GetKhoaHocKyThuatListByIDGiaoVien(id);
            cb.DataSource = listKhoaHoc;
            cb.DisplayMember = "khoahoc_Name";
        }
        void LoadMonHocByKhoaHocKyThuat(ComboBox cb, int idkhoahoc, int idgiaovien)
        {
            List<HocPhanKyThuat> listHocPhanKyThuat = DAO_HocPhanKyThuat.Instance.GetHocPhanKyThuatListByMaKhoaHoc(idkhoahoc, idgiaovien);
            cb.DataSource = listHocPhanKyThuat;
            cb.DisplayMember = "Hocphankythuat_MonHoc_Name";
        }
        void LoadLanThiByHPKT(ComboBox cb, int idhptk)
        {
            List<LichThiHocPhanKyThuat> listLichThiHocPhanKyThuat = DAO_LichThiHocPhanKyThuat.Instance.GetLichThiHocPhanKyThuatListByHPKT(idhptk);
            cb.DataSource = listLichThiHocPhanKyThuat;
            cb.DisplayMember = "Lichthihocphankythuat_LanThi";
        }
        void LoadHocVienByLanThi(ComboBox cb, int idhpkt, int lanthi)
        {
            List<HocVien> listHocVienHPKT = DAO_HocVien.Instance.GetHocVienListByLanThi(idhpkt, lanthi);
            cb.DataSource = listHocVienHPKT;
            cb.DisplayMember = "Hocvien_Name";
        }

        #endregion

        #region Events
        private void GUIGiaoVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnHPCCXem_Click(object sender, EventArgs e)
        {
            LoadListGiaoVienHocPhanChungChiByIDGiaoVien(idgiaovien);
        }


        private void cbHPCCKhoaName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            KhoaHoc selected = cb.SelectedItem as KhoaHoc;
            id = selected.Khoahoc_ID;
            LoadMonHocByKhoaHocChungChi(cbHPCCMonHocName, id, idgiaovien);
            LoadListGiaoVienHocPhanChungChiByIDKhoaHoc(id, idgiaovien);

        }

        private void cbHPCCMonHocName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            HocPhanChungChi selected = cb.SelectedItem as HocPhanChungChi;
            id = selected.Hocphanchungchi_ID;
            KhoaHoc khoa = (KhoaHoc)cbHPCCKhoaName.SelectedItem;
            int makhoahoc = khoa.Khoahoc_ID;
            LoadHocVienByHPCC(cbHPCCHocVienName, id);
            LoadListGiaoVienHocPhanChungChiByIDHPCC(makhoahoc, id, idgiaovien);
        }

        private void cbHocVienName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            HocVien selected = cb.SelectedItem as HocVien;
            id = selected.Hocvien_ID;
            KhoaHoc khoa = (KhoaHoc)cbHPCCKhoaName.SelectedItem;
            int makhoahoc = khoa.Khoahoc_ID;
            HocPhanChungChi HPCC = (HocPhanChungChi)cbHPCCMonHocName.SelectedItem;
            int mahpcc = HPCC.Hocphanchungchi_ID;
            LoadListGiaoVienHocPhanChungChiByIDHocVien(makhoahoc, mahpcc, idgiaovien, id);

        }

        private void btnHPCCSua_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(txbHPCCDiemID.Text);
            int diem = Convert.ToInt32(txbHPCCDiem.Text);

            if (DAO_GiaoVienHocPhanChungChi.Instance.UpdateGiaoVienHocPhanChungChi(id, diem))
            {
                MessageBox.Show("Sửa điểm thành công");
                LoadListGiaoVienHocPhanChungChiByIDGiaoVien(idgiaovien);
            }
            else
            {
                MessageBox.Show("Lỗi sửa điểm");
            }
        }
        #endregion
        private void cbHPKTKhoaName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            KhoaHoc selected = cb.SelectedItem as KhoaHoc;
            id = selected.Khoahoc_ID;
            LoadMonHocByKhoaHocKyThuat(cbHPKTMonHocName, id, idgiaovien);
            LoadListGiaoVienHocPhanKyThuatByIDKhoaHoc(id, idgiaovien);
        }
        private void cbHPKTMonHocName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            HocPhanKyThuat selected = cb.SelectedItem as HocPhanKyThuat;
            id = selected.Hocphankythuat_ID;
            KhoaHoc khoa = (KhoaHoc)cbHPKTKhoaName.SelectedItem;
            int makhoahoc = khoa.Khoahoc_ID;
            LoadLanThiByHPKT(cbHPKTLanThi, id);
            LoadListGiaoVienHocPhanKyThuatByIDHPKT(makhoahoc, id, idgiaovien);
        }
        private void cbHPKTLanThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int lanthi = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            LichThiHocPhanKyThuat selected = cb.SelectedItem as LichThiHocPhanKyThuat;
            lanthi = selected.Lichthihocphankythuat_LanThi;
            HocPhanKyThuat hpkt = (HocPhanKyThuat)cbHPKTMonHocName.SelectedItem;
            int mahpkt = hpkt.Hocphankythuat_ID;
            KhoaHoc khoa = (KhoaHoc)cbHPKTKhoaName.SelectedItem;
            int makhoahoc = khoa.Khoahoc_ID;
            LoadHocVienByLanThi(cbHPKTHocVienName, mahpkt, lanthi);
            LoadListGiaoVienHocPhanKyThuatByLanThi(makhoahoc, mahpkt, lanthi, idgiaovien);
        }

        private void cbHPKTHocVienName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            HocVien selected = cb.SelectedItem as HocVien;
            id = selected.Hocvien_ID;
            KhoaHoc khoa = (KhoaHoc)cbHPKTKhoaName.SelectedItem;
            int makhoahoc = khoa.Khoahoc_ID;
            HocPhanKyThuat hpkt = (HocPhanKyThuat)cbHPKTMonHocName.SelectedItem;
            int mahpkt = hpkt.Hocphankythuat_ID;
            LichThiHocPhanKyThuat lthpkt = (LichThiHocPhanKyThuat)cbHPKTLanThi.SelectedItem;
            int lanthi = lthpkt.Lichthihocphankythuat_LanThi;
            LoadListGiaoVienHocPhanKyThuatByIDHocVien(makhoahoc, mahpkt, lanthi, idgiaovien, id);
        }


        private void bntHPKTXem_Click(object sender, EventArgs e)
        {
            LoadListGiaoVienHocPhanKyThuatByIDGiaoVien(idgiaovien);
        }

        private void bntHPKTSua_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbHPKTDiemID.Text);
            int diem = Convert.ToInt32(txbHPKTDiem.Text);

            if (DAO_GiaoVienHocPhanKyThuat.Instance.UpdateGiaoVienHocPhanKyThuat(id, diem))
            {
                MessageBox.Show("Sửa điểm thành công");
                LoadListGiaoVienHocPhanKyThuatByIDGiaoVien(idgiaovien);
            }
            else
            {
                MessageBox.Show("Lỗi sửa điểm");
            }
        }

        private void cbTNKhoaName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            KhoaHoc selected = cb.SelectedItem as KhoaHoc;
            id = selected.Khoahoc_ID;
            LoadLanThiByKhoaHocTotNgiep(cbTNLanThi, id);
            LoadListGiaoVienTotNghiepByIDKhoaHoc(id);
        }

        private void cbTNLanThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int lanthi = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            LichThiTotNghiep selected = cb.SelectedItem as LichThiTotNghiep;
            lanthi = selected.Lichthitotnghiep_LanThi;
            KhoaHoc khoa = (KhoaHoc)cbTNKhoaName.SelectedItem;
            int makhoahoc = khoa.Khoahoc_ID;
            LoadHocVienTotNghiepByLanThi(cbTNHocVienName, makhoahoc, lanthi);
            LoadListGiaoVienTotNghiepByLanThi(makhoahoc, lanthi);
        }

        private void cbTNHocVienName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            HocVien selected = cb.SelectedItem as HocVien;
            id = selected.Hocvien_ID;
            KhoaHoc khoa = (KhoaHoc)cbTNKhoaName.SelectedItem;
            int makhoahoc = khoa.Khoahoc_ID;
            LichThiTotNghiep lichthitotnghiep = (LichThiTotNghiep)cbTNLanThi.SelectedItem;
            int lanthi = lichthitotnghiep.Lichthitotnghiep_LanThi;
            LoadListGiaoVienTotNghiepByHocVien(makhoahoc, lanthi, id);
        }

        private void btnTNSua_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbTNDiemID.Text);
            int diem = Convert.ToInt32(txbTNDiem.Text);

            if (DAO_GiaoVienTotNghiep.Instance.UpdateGiaoVienTotNghiep(id, diem))
            {
                MessageBox.Show("Sửa điểm thành công");
                LoadListGiaoVienTotNghiep();
            }
            else
            {
                MessageBox.Show("Lỗi sửa điểm");
            }
        }

        private void btnTNXem_Click(object sender, EventArgs e)
        {
            LoadListGiaoVienTotNghiep();
        }

        private void btnTNTimKiem_Click(object sender, EventArgs e)
        {
            string hocvienname = txbTNTimKiem.Text;
            giaovientotnghiepList.DataSource = SearchTNHocVien(hocvienname);
        }

        private void bntHPKTTimKiem_Click(object sender, EventArgs e)
        {
            string hocvienname = txbHPKTTimKiem.Text;
            giaovienhocphankythuatList.DataSource = SearchHPKTHocVien(hocvienname);
        }

        private void btnHPCCTimKiem_Click(object sender, EventArgs e)
        {
            string hocvienname = txbHPCCTimKiem.Text;
            giaovienhocphanchungchiList.DataSource = SearchHPCCHocVien(hocvienname);
        }
    }
}