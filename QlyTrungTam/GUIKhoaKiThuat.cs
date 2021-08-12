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
using QlyTrungTam.DAO;
using QlyTrungTam.DTO;

namespace QlyTrungTam
{
    public partial class GUIKhoaKiThuat : Form
    {

        public GUIKhoaKiThuat()
        {
            InitializeComponent();
        }

        private void btnThemKHKT_Click(object sender, EventArgs e)
        {
            if (txtKHKT_TenKhoa.Text != "" && txtKHKT_SL.Text != "" &&
                cmbKHKT_IDNV.Text != "" && rtxtKHKT_MoTa.Text != "")
            {
                string ten = txtKHKT_TenKhoa.Text;
                string date = dateKHKT_NgayBD.Value.Date.ToString();
                int sl = Convert.ToInt32(txtKHKT_SL.Text);
                int nv = Convert.ToInt32(cmbKHKT_IDNV.Text);
                string mota = rtxtKHKT_MoTa.Text;

                DTO_Vy_KhoaHoc myKh = new DTO_Vy_KhoaHoc(0, ten, date, mota, 1, nv);

                int result = DAO_Vy_KhoaHoc.Instance.ThemKhoaHoc(myKh);

                if (result != 0)
                {
                    int getMax = DAO_Vy_KhoaHoc.Instance.DemKhoaHoc();

                    DTO_Vy_KhoaDaoTaoKyThuat kh = new DTO_Vy_KhoaDaoTaoKyThuat(getMax, sl);

                    result = DAO_Vy_KhoaDaoTaoKyThuat.Instance.ThemKhoaHoc(kh);

                    if (result != 0)
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo");
                        EventArgs newE = new EventArgs();
                        btnXemKHKT_Click(sender, newE);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo");
            }
        }

        private void btnXemKHKT_Click(object sender, EventArgs e)
        {
            dgvKHKT.DataSource = DAO_Vy_KhoaHoc.Instance.XemKhoaHocKyThuat();
        }

        private void dgvKHKT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int val = Convert.ToInt32(dgvKHKT.Rows[e.RowIndex].Cells["MaKhoaHoc"].FormattedValue.ToString());

            DTO_Vy_KhoaDaoTaoKyThuat kh = new DTO_Vy_KhoaDaoTaoKyThuat(val, 0);

            DataTable data = DAO_Vy_KhoaDaoTaoKyThuat.Instance.XemKhoaHocKTWithID(kh);

            if (data.Rows.Count > 0)
            {
                txtKHKT_IDKhoa.Text = data.Rows[0]["MaKhoaHoc"].ToString();
                txtKHKT_SL.Text = data.Rows[0]["SoLuongNhomHP"].ToString();

                DTO_Vy_KhoaHoc myKh = new DTO_Vy_KhoaHoc(Convert.ToInt32(txtKHKT_IDKhoa.Text), "", "", "", 0, 0);
                data = DAO_Vy_KhoaHoc.Instance.XemKhoaHocWithID(myKh);

                txtKHKT_TenKhoa.Text = data.Rows[0]["TenKhoaHoc"].ToString();
                dateKHKT_NgayBD.Value = Convert.ToDateTime(data.Rows[0]["NgayBatDau"].ToString());
                cmbKHKT_IDNV.Text = data.Rows[0]["MaNhanVien"].ToString();
                rtxtKHKT_MoTa.Text = data.Rows[0]["MoTa"].ToString();
            }
        }

        private void btnResetKHKT_Click(object sender, EventArgs e)
        {
        }

        private void GUIKhoaKiThuat_Load(object sender, EventArgs e)
        {
            DataTable data = DAO_Vy_NhanVien.Instance.XemIDNhanVien();

            foreach (DataRow row in data.Rows)
            {
                cmbKHKT_IDNV.Items.Add(row["MaNhanVien"].ToString());
            }    
        }

        private void btnSuaKHKT_Click(object sender, EventArgs e)
        {
            if (txtKHKT_IDKhoa.Text != "" && txtKHKT_TenKhoa.Text != "" && txtKHKT_SL.Text != "" && 
                cmbKHKT_IDNV.Text != "" && rtxtKHKT_MoTa.Text != "")
            {
                int idkhoa = Convert.ToInt32(txtKHKT_IDKhoa.Text);
                string ten = txtKHKT_TenKhoa.Text;
                string date = dateKHKT_NgayBD.Value.Date.ToString();
                int sl = Convert.ToInt32(txtKHKT_SL.Text);
                int nv = Convert.ToInt32(cmbKHKT_IDNV.Text);
                string mota = rtxtKHKT_MoTa.Text;

                DTO_Vy_KhoaHoc myKh = new DTO_Vy_KhoaHoc(idkhoa, ten, date, mota, 1, nv);

                int result = DAO_Vy_KhoaHoc.Instance.CapNhatKhoaHoc(myKh);

                if (result != 0)
                {
                    DTO_Vy_KhoaDaoTaoKyThuat kh = new DTO_Vy_KhoaDaoTaoKyThuat(idkhoa, sl);

                    result = DAO_Vy_KhoaDaoTaoKyThuat.Instance.CapNhatKhoaHoc(kh);

                    if (result != 0)
                    {
                        MessageBox.Show("Cập nhật thành công", "Thông báo");
                        EventArgs newE = new EventArgs();
                        btnXemKHKT_Click(sender, newE);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo");
                }
            }    
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo");
            }    
        }

        private void btnXemCTKKT_Click(object sender, EventArgs e)
        {
            dgvCTKKT.DataSource = DAO_Vy_ChiTietKhoaKyThuat.Instance.XemCTKH();
        }

        private void dgvCTKKT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int val = Convert.ToInt32(dgvCTKKT.Rows[e.RowIndex].Cells["MaChiTietKhoaKyThuat"].FormattedValue.ToString());

            DTO_Vy_ChiTietKhoaKyThuat kh = new DTO_Vy_ChiTietKhoaKyThuat(val, 0, 0);

            DataTable data = DAO_Vy_ChiTietKhoaKyThuat.Instance.XemCTKHWithID(kh);

            if (data.Rows.Count > 0)
            {
                txtCTKKT_IDCTK.Text = data.Rows[0]["MaChiTietKhoaKyThuat"].ToString();
                cmbCTKKT_KKT.Text = data.Rows[0]["MaKhoaHoc"].ToString();
                cmbCTKKT_NHP.Text = data.Rows[0]["MaNhomHocPhan"].ToString();
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            cmbCTKKT_KKT.Items.Clear();
            cmbCTKKT_NHP.Items.Clear();

            DataTable nhom = DAO_Vy_NhomHPKyThuat.Instance.XemNhomHPKyThuat();

            foreach(DataRow row in nhom.Rows)
            {
                cmbCTKKT_NHP.Items.Add(row["MaNhomHocPhan"]);
            }

            nhom = DAO_Vy_KhoaDaoTaoKyThuat.Instance.XemKhoaHocKT();

            foreach (DataRow row in nhom.Rows)
            {
                cmbCTKKT_KKT.Items.Add(row["MaKhoaHoc"]);
            }

            cmbHPKT_CTKhoa.Items.Clear();
            cmbHPKT_GV.Items.Clear();
            cmbHPKT_Mon.Items.Clear();

            nhom = DAO_Vy_GiaoVien.Instance.XemGiaoVien();

            foreach (DataRow row in nhom.Rows)
            {
                cmbHPKT_GV.Items.Add(row["MaGiaoVien"]);
            }

            nhom = DAO_Vy_ChiTietKhoaKyThuat.Instance.XemCTKH();

            foreach (DataRow row in nhom.Rows)
            {
                cmbHPKT_CTKhoa.Items.Add(row["MaChiTietKhoaKyThuat"]);
            }

            nhom = DAO_Vy_MonHoc.Instance.XemMonHoc();

            foreach (DataRow row in nhom.Rows)
            {
                cmbHPKT_Mon.Items.Add(row["MaMonHoc"]);
            }

            cmbLT_IDHP.Items.Clear();
            cmbLT_NV.Items.Clear();

            nhom = DAO_Vy_NhanVien.Instance.XemIDNhanVien();

            foreach (DataRow row in nhom.Rows)
            {
                cmbLT_NV.Items.Add(row["MaNhanVien"]);
            }

            nhom = DAO_Vy_HocPhanKyThuat.Instance.XemHocPhan();

            foreach (DataRow row in nhom.Rows)
            {
                cmbLT_IDHP.Items.Add(row["MaHPKyThuat"]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void btnThemCTKKT_Click(object sender, EventArgs e)
        {
            if (cmbCTKKT_KKT.Text != "" && cmbCTKKT_NHP.Text != "")
            {
                int maKT = Convert.ToInt32(cmbCTKKT_KKT.Text);
                int maNhom = Convert.ToInt32(cmbCTKKT_NHP.Text);

                DTO_Vy_ChiTietKhoaKyThuat kh = new DTO_Vy_ChiTietKhoaKyThuat(0, maKT, maNhom);


                int result = DAO_Vy_ChiTietKhoaKyThuat.Instance.ThemCTKhoaHoc(kh);

                if (result != 0)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    EventArgs newE = new EventArgs();
                    btnXemCTKKT_Click(sender, newE);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
            }   
        }

        private void btnSuaCTKKT_Click(object sender, EventArgs e)
        {
            if (txtCTKKT_IDCTK.Text != "" && cmbCTKKT_KKT.Text != "" && cmbCTKKT_NHP.Text != "")
            {
                int maCT = Convert.ToInt32(txtCTKKT_IDCTK.Text);
                int maKT = Convert.ToInt32(cmbCTKKT_KKT.Text);
                int maNhom = Convert.ToInt32(cmbCTKKT_NHP.Text);

                DTO_Vy_ChiTietKhoaKyThuat kh = new DTO_Vy_ChiTietKhoaKyThuat(maCT, maKT, maNhom);

                int result = DAO_Vy_ChiTietKhoaKyThuat.Instance.CapNhatCTKhoaHoc(kh);

                if (result != 0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo");
                    EventArgs newE = new EventArgs();
                    btnXemCTKKT_Click(sender, newE);
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
            }
        }

        private void btnXemHPKT_Click(object sender, EventArgs e)
        {
            dgvHPKT.DataSource = DAO_Vy_HocPhanKyThuat.Instance.XemHocPhan();
        }

        private void dgvHPKT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int val = Convert.ToInt32(dgvHPKT.Rows[e.RowIndex].Cells["MaHPKyThuat"].FormattedValue.ToString());

            DTO_Vy_HocPhanKyThuat kh = new DTO_Vy_HocPhanKyThuat(val, 0, 0, "", "", 0, 0, 0);

            DataTable data = DAO_Vy_HocPhanKyThuat.Instance.XemHocPhanWithID(kh);

            if (data.Rows.Count > 0)
            {
                txtHPKT_IDHP.Text = data.Rows[0]["MaHPKyThuat"].ToString();
                cmbHPKT_Mon.Text = data.Rows[0]["MaMonHoc"].ToString();
                txtHPKT_Nam.Text = data.Rows[0]["NamHoc"].ToString();
                txtHPKT_HocKy.Text = data.Rows[0]["HocKy"].ToString();
                txtHPKT_Lich.Text = data.Rows[0]["LichHoc"].ToString();
                cmbHPKT_GV.Text = data.Rows[0]["MaGiaoVien"].ToString();

                cmbHPKT_CTKhoa.Text = data.Rows[0]["MaChiTietKhoaKyThuat"].ToString();
                txtHPKT_Phong.Text = data.Rows[0]["Phong"].ToString();
            }
        }

        private void btnSuaHPKT_Click(object sender, EventArgs e)
        {
            if (txtHPKT_IDHP.Text != "" && cmbHPKT_Mon.Text != "" && txtHPKT_Nam.Text != "" && txtHPKT_HocKy.Text != "" 
                && txtHPKT_Lich.Text != "" && cmbHPKT_GV.Text != "" && txtHPKT_Phong.Text != "" && cmbHPKT_CTKhoa.Text != "")
            {
                int idhp = Convert.ToInt32(txtHPKT_IDHP.Text);
                int mon = Convert.ToInt32(cmbHPKT_Mon.Text);
                int nam = Convert.ToInt32(txtHPKT_Nam.Text);
                int hocky = Convert.ToInt32(txtHPKT_HocKy.Text);
                string lich = txtHPKT_Lich.Text;
                int gv = Convert.ToInt32(cmbHPKT_GV.Text);
                string phong = txtHPKT_Phong.Text;
                int ct = Convert.ToInt32(cmbHPKT_CTKhoa.Text);


                DTO_Vy_HocPhanKyThuat kh = new DTO_Vy_HocPhanKyThuat(idhp, nam, hocky, lich, phong, mon, gv, ct);

                int result = DAO_Vy_HocPhanKyThuat.Instance.CapNhatCTKhoaHoc(kh);

                if (result != 0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo");
                    EventArgs newE = new EventArgs();
                    btnXemHPKT_Click(sender, newE);
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
            }    
        }

        private void btnThemHPKT_Click(object sender, EventArgs e)
        {
            if (cmbHPKT_Mon.Text != "" && txtHPKT_Nam.Text != "" && txtHPKT_HocKy.Text != ""
                && txtHPKT_Lich.Text != "" && cmbHPKT_GV.Text != "" && txtHPKT_Phong.Text != "" && cmbHPKT_CTKhoa.Text != "")
            {
                int mon = Convert.ToInt32(cmbHPKT_Mon.Text);
                int nam = Convert.ToInt32(txtHPKT_Nam.Text);
                int hocky = Convert.ToInt32(txtHPKT_HocKy.Text);
                string lich = txtHPKT_Lich.Text;
                int gv = Convert.ToInt32(cmbHPKT_GV.Text);
                string phong = txtHPKT_Phong.Text;
                int ct = Convert.ToInt32(cmbHPKT_CTKhoa.Text);

                DTO_Vy_HocPhanKyThuat hp = new DTO_Vy_HocPhanKyThuat(0, nam, hocky, lich, phong, mon, gv, ct);

                int result = DAO_Vy_HocPhanKyThuat.Instance.ThemHPKyThuat(hp);

                if (result != 0)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    EventArgs newE = new EventArgs();
                    btnXemHPKT_Click(sender, newE);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
            } 
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void btnXem_LT_Click(object sender, EventArgs e)
        {
            dgvLT.DataSource = DAO_Vy_LichThiHPKT.Instance.XemLichThi();
        }

        private void dgvLT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int val = Convert.ToInt32(dgvLT.Rows[e.RowIndex].Cells["MaLichThiHPKT"].FormattedValue.ToString());

            DTO_Vy_LichThiHPKT kh = new DTO_Vy_LichThiHPKT(val, "", 0, "", 0, 0);

            DataTable data = DAO_Vy_LichThiHPKT.Instance.XemLichThiWithID(kh);

            if (data.Rows.Count > 0)
            {
                txtLT_IDLT.Text = data.Rows[0]["MaLichThiHPKT"].ToString();
                cmbLT_IDHP.Text = data.Rows[0]["MaHPKyThuat"].ToString();
                dateLT_NgayThi.Value = Convert.ToDateTime(data.Rows[0]["NgayThi"].ToString());
                txtLT_LanThi.Text = data.Rows[0]["LanThi"].ToString();
                txtLT_Phong.Text = data.Rows[0]["PhongThi"].ToString();
                cmbLT_NV.Text = data.Rows[0]["MaNhanVien"].ToString();

                DTO_Vy_HocPhanKyThuat hpkt = new DTO_Vy_HocPhanKyThuat(Convert.ToInt32(cmbLT_IDHP.Text), 0, 0, "", "", 0, 0, 0);
                data = DAO_Vy_HocPhanKyThuat.Instance.XemHocPhanWithID(hpkt);

                if (data.Rows.Count > 0)
                {
                    int mamon = Convert.ToInt32(data.Rows[0]["MaMonHoc"].ToString());
                    int mact = Convert.ToInt32(data.Rows[0]["MaChiTietKhoaKyThuat"].ToString());

                    DTO_Vy_ChiTietKhoaKyThuat ctkkt = new DTO_Vy_ChiTietKhoaKyThuat(mact, 0, 0);
                    data = DAO_Vy_ChiTietKhoaKyThuat.Instance.XemCTKHWithID(ctkkt);

                    if (data.Rows.Count > 0)
                    {
                        txtLT_Khoa.Text = data.Rows[0]["MaKhoaHoc"].ToString();
                        txtLT_NhomKT.Text = data.Rows[0]["MaNhomHocphan"].ToString();

                        DTO_Vy_MonHoc mh = new DTO_Vy_MonHoc(mamon, "", "", 0, 0);
                        data = DAO_Vy_MonHoc.Instance.XemMonHocWithID(mh);
                        if (data.Rows.Count > 0)
                        {
                            txtLT_MonHoc.Text = data.Rows[0]["TenMonHoc"].ToString();
                        }
                    }    
                    
                }     
            }    
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void btnSua_LT_Click(object sender, EventArgs e)
        {
            if (txtLT_IDLT.Text != "" && cmbLT_IDHP.Text != "" && txtLT_LanThi.Text != "" && txtLT_Phong.Text != "" && cmbLT_NV.Text != "")
            {
                int idlt = Convert.ToInt32(txtLT_IDLT.Text);
                int idhp = Convert.ToInt32(cmbLT_IDHP.Text);
                string date = dateLT_NgayThi.Value.Date.ToString();
                int lanthi = Convert.ToInt32(txtLT_LanThi.Text);
                string phong = txtLT_Phong.Text;
                int nv = Convert.ToInt32(cmbLT_NV.Text);

                DTO_Vy_LichThiHPKT kh = new DTO_Vy_LichThiHPKT(idlt, date, lanthi, phong, idhp, nv);

                int result = DAO_Vy_LichThiHPKT.Instance.CapNhatLichThi(kh);

                if (result != 0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo");
                    EventArgs newE = new EventArgs();
                    btnXem_LT_Click(sender, newE);
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
            }
        }

        private void btnThem_LT_Click(object sender, EventArgs e)
        {
            if (cmbLT_IDHP.Text != "" && txtLT_LanThi.Text != "" && txtLT_Phong.Text != "" && cmbLT_NV.Text != "")
            {
                int idhp = Convert.ToInt32(cmbLT_IDHP.Text);
                string date = dateLT_NgayThi.Value.Date.ToString();
                int lanthi = Convert.ToInt32(txtLT_LanThi.Text);
                string phong = txtLT_Phong.Text;
                int nv = Convert.ToInt32(cmbLT_NV.Text);

                DTO_Vy_LichThiHPKT kh = new DTO_Vy_LichThiHPKT(0, date, lanthi, phong, idhp, nv);

                int result = DAO_Vy_LichThiHPKT.Instance.ThemLichThi(kh);

                if (result != 0)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    EventArgs newE = new EventArgs();
                    btnXem_LT_Click(sender, newE);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
            }
        }

        private void btnTimKiemKHKT_Click(object sender, EventArgs e)
        {
            string getVal = txtKHKT_TimKiem.Text;
            if (getVal != "")
            {
                if (Regex.IsMatch(getVal, "[0-9]", RegexOptions.IgnoreCase))
                {
                    int val = Convert.ToInt32(getVal);

                    DTO_Vy_KhoaDaoTaoKyThuat kh = new DTO_Vy_KhoaDaoTaoKyThuat(val, 0);

                    DataTable data = DAO_Vy_KhoaDaoTaoKyThuat.Instance.XemKhoaHocKTWithID(kh);

                    if (data.Rows.Count > 0)
                    {
                        txtKHKT_IDKhoa.Text = data.Rows[0]["MaKhoaHoc"].ToString();
                        txtKHKT_SL.Text = data.Rows[0]["SoLuongNhomHP"].ToString();

                        DTO_Vy_KhoaHoc myKh = new DTO_Vy_KhoaHoc(Convert.ToInt32(txtKHKT_IDKhoa.Text), "", "", "", 0, 0);
                        data = DAO_Vy_KhoaHoc.Instance.XemKhoaHocWithID(myKh);

                        txtKHKT_TenKhoa.Text = data.Rows[0]["TenKhoaHoc"].ToString();
                        dateKHKT_NgayBD.Value = Convert.ToDateTime(data.Rows[0]["NgayBatDau"].ToString());
                        cmbKHKT_IDNV.Text = data.Rows[0]["MaNhanVien"].ToString();
                        rtxtKHKT_MoTa.Text = data.Rows[0]["MoTa"].ToString();
                        setDgvKHTK(val);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số", "Thông báo");
                }
            }
        }

        private void setDgvKHTK(int id)
        {
            DTO_Vy_KhoaHoc dt = new DTO_Vy_KhoaHoc(id, "", "", "", 1, 0);
            dgvKHKT.DataSource = DAO_Vy_KhoaHoc.Instance.XemKhoaHocWithID(dt);
        }

        private void btnCTKKT_TimKiem_Click(object sender, EventArgs e)
        {
            string getVal = txtCTKKT_TimKiem.Text;
            if (getVal != "")
            {
                if (Regex.IsMatch(getVal, "[0-9]", RegexOptions.IgnoreCase))
                {
                    int val = Convert.ToInt32(getVal);

                    DTO_Vy_ChiTietKhoaKyThuat kh = new DTO_Vy_ChiTietKhoaKyThuat(val, 0, 0);

                    DataTable data = DAO_Vy_ChiTietKhoaKyThuat.Instance.XemCTKHWithID(kh);

                    if (data.Rows.Count > 0)
                    {
                        txtCTKKT_IDCTK.Text = data.Rows[0]["MaChiTietKhoaKyThuat"].ToString();
                        cmbCTKKT_KKT.Text = data.Rows[0]["MaKhoaHoc"].ToString();
                        cmbCTKKT_NHP.Text = data.Rows[0]["MaNhomHocPhan"].ToString();

                        setDgvCTKKT(val);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số", "Thông báo");
                }                    
            }    
        }

        private void setDgvCTKKT(int id)
        {
            DTO_Vy_ChiTietKhoaKyThuat dt = new DTO_Vy_ChiTietKhoaKyThuat(id, 0, 0);
            dgvCTKKT.DataSource = DAO_Vy_ChiTietKhoaKyThuat.Instance.XemCTKHWithID(dt);
        }

        private void btnHPKT_TimKiem_Click(object sender, EventArgs e)
        {
            string getVal = txtHPKT_TimKiem.Text;
            if (getVal != "")
            {
                if (Regex.IsMatch(getVal, "[0-9]", RegexOptions.IgnoreCase))
                {
                    int val = Convert.ToInt32(getVal);

                    DTO_Vy_HocPhanKyThuat kh = new DTO_Vy_HocPhanKyThuat(val, 0, 0, "", "", 0, 0, 0);

                    DataTable data = DAO_Vy_HocPhanKyThuat.Instance.XemHocPhanWithID(kh);

                    if (data.Rows.Count > 0)
                    {
                        txtHPKT_IDHP.Text = data.Rows[0]["MaHPKyThuat"].ToString();
                        cmbHPKT_Mon.Text = data.Rows[0]["MaMonHoc"].ToString();
                        txtHPKT_Nam.Text = data.Rows[0]["NamHoc"].ToString();
                        txtHPKT_HocKy.Text = data.Rows[0]["HocKy"].ToString();
                        txtHPKT_Lich.Text = data.Rows[0]["LichHoc"].ToString();
                        cmbHPKT_GV.Text = data.Rows[0]["MaGiaoVien"].ToString();

                        cmbHPKT_CTKhoa.Text = data.Rows[0]["MaChiTietKhoaKyThuat"].ToString();
                        txtHPKT_Phong.Text = data.Rows[0]["Phong"].ToString();

                        setDgvHPKT(val);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số", "Thông báo");
                }
            }    
        }

        private void setDgvHPKT(int id)
        {
            DTO_Vy_HocPhanKyThuat dt = new DTO_Vy_HocPhanKyThuat(id, 0, 0, "", "", 0, 0, 0);
            dgvHPKT.DataSource = DAO_Vy_HocPhanKyThuat.Instance.XemHocPhanWithID(dt);
        }

        private void btnLT_TimKiem_Click(object sender, EventArgs e)
        {
            string getVal = txtLT_TimKiem.Text;
            if (getVal != "")
            {
                if (Regex.IsMatch(getVal, "[0-9]", RegexOptions.IgnoreCase))
                {
                    int val = Convert.ToInt32(getVal);

                    DTO_Vy_LichThiHPKT kh = new DTO_Vy_LichThiHPKT(val, "", 0, "", 0, 0);

                    DataTable data = DAO_Vy_LichThiHPKT.Instance.XemLichThiWithID(kh);

                    if (data.Rows.Count > 0)
                    {
                        txtLT_IDLT.Text = data.Rows[0]["MaLichThiHPKT"].ToString();
                        cmbLT_IDHP.Text = data.Rows[0]["MaHPKyThuat"].ToString();
                        dateLT_NgayThi.Value = Convert.ToDateTime(data.Rows[0]["NgayThi"].ToString());
                        txtLT_LanThi.Text = data.Rows[0]["LanThi"].ToString();
                        txtLT_Phong.Text = data.Rows[0]["PhongThi"].ToString();
                        cmbLT_NV.Text = data.Rows[0]["MaNhanVien"].ToString();

                        DTO_Vy_HocPhanKyThuat hpkt = new DTO_Vy_HocPhanKyThuat(Convert.ToInt32(cmbLT_IDHP.Text), 0, 0, "", "", 0, 0, 0);
                        data = DAO_Vy_HocPhanKyThuat.Instance.XemHocPhanWithID(hpkt);

                        int mamon = Convert.ToInt32(data.Rows[0]["MaMonHoc"].ToString());
                        int mact = Convert.ToInt32(data.Rows[0]["MaChiTietKhoaKyThuat"].ToString());

                        DTO_Vy_ChiTietKhoaKyThuat ctkkt = new DTO_Vy_ChiTietKhoaKyThuat(mact, 0, 0);
                        data = DAO_Vy_ChiTietKhoaKyThuat.Instance.XemCTKHWithID(ctkkt);

                        txtLT_Khoa.Text = data.Rows[0]["MaKhoaHoc"].ToString();
                        txtLT_NhomKT.Text = data.Rows[0]["MaNhomHocphan"].ToString();

                        DTO_Vy_MonHoc mh = new DTO_Vy_MonHoc(mamon, "", "", 0, 0);
                        data = DAO_Vy_MonHoc.Instance.XemMonHocWithID(mh);

                        txtLT_MonHoc.Text = data.Rows[0]["TenMonHoc"].ToString();

                        setDgvLT(val);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số", "Thông báo");
                }   
            }        
        }

        private void setDgvLT(int id)
        {
            DTO_Vy_LichThiHPKT dt = new DTO_Vy_LichThiHPKT(id, "", 0, "", 0, 0);
            dgvLT.DataSource = DAO_Vy_LichThiHPKT.Instance.XemLichThiWithID(dt);
        }

    }
}
