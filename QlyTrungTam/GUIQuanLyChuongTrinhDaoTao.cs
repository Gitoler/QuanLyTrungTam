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
    public partial class GUIQuanLyChuongTrinhDaoTao : Form
    {
        public GUIQuanLyChuongTrinhDaoTao()
        {
            InitializeComponent();
        }

        private void btnXem_NhomHPKT_Click(object sender, EventArgs e)
        {
            dgvNhomHPKT.DataSource = DAO_Vy_NhomHPKyThuat.Instance.XemNhomHPKyThuat();
        }

        private void GUIQuanLyChuongTrinhDaoTao_Load(object sender, EventArgs e)
        {
            
        }

        private void dgvNhomHPKT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int val = Convert.ToInt32(dgvNhomHPKT.Rows[e.RowIndex].Cells["MaNhomHocPhan"].FormattedValue.ToString());

            DTO_Vy_NhomHPKyThuat kh = new DTO_Vy_NhomHPKyThuat(val, "", "");

            DataTable data = DAO_Vy_NhomHPKyThuat.Instance.XemNhomHPKyThuatWithID(kh);

            if (data.Rows.Count > 0)
            {
                txtNhomHPKT_IDNhom.Text = data.Rows[0]["MaNhomHocPhan"].ToString();
                txtNhomHPKT_TenNhom.Text = data.Rows[0]["TenNhomHocPhan"].ToString();
                cmbNhomHPKT_Loai.Text = data.Rows[0]["Loai"].ToString();
            }
        }

        private void btnSua_NhomHPKT_Click(object sender, EventArgs e)
        {
            if (txtNhomHPKT_IDNhom.Text != "" && txtNhomHPKT_TenNhom.Text != "" && cmbNhomHPKT_Loai.Text != "")
            {
                int ma = Convert.ToInt32(txtNhomHPKT_IDNhom.Text);
                string ten = txtNhomHPKT_TenNhom.Text;
                string loai = cmbNhomHPKT_Loai.Text;

                DTO_Vy_NhomHPKyThuat hp = new DTO_Vy_NhomHPKyThuat(ma, ten, loai);

                int result = DAO_Vy_NhomHPKyThuat.Instance.CapNhatNhomHP(hp);

                if (result != 0)
                {
                    MessageBox.Show("Cập nhập thành công", "Thông báo");
                    EventArgs newE = new EventArgs();
                    btnXem_NhomHPKT_Click(sender, newE);
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

        private void btnThem_NhomHPKT_Click(object sender, EventArgs e)
        {
            if (txtNhomHPKT_TenNhom.Text != "" && cmbNhomHPKT_Loai.Text != "")
            {
                string ten = txtNhomHPKT_TenNhom.Text;
                string loai = cmbNhomHPKT_Loai.Text;

                DTO_Vy_NhomHPKyThuat hp = new DTO_Vy_NhomHPKyThuat(0, ten, loai);

                int result = DAO_Vy_NhomHPKyThuat.Instance.ThemNhomHP(hp);

                if (result != 0)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    EventArgs newE = new EventArgs();
                    btnXem_NhomHPKT_Click(sender, newE);
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

        private void btnNhomHPKT_TimKiem_Click(object sender, EventArgs e)
        {
            string tim = txtNhomHPKT_TimKiem.Text;
            if (tim != "")
            {
                DTO_Vy_NhomHPKyThuat hp = new DTO_Vy_NhomHPKyThuat(Convert.ToInt32(tim), "", "");

                DataTable data = DAO_Vy_NhomHPKyThuat.Instance.XemNhomHPKyThuatWithID(hp);

                if (data.Rows.Count > 0)
                {
                    txtNhomHPKT_IDNhom.Text = data.Rows[0]["MaNhomHocPhan"].ToString();
                    txtNhomHPKT_TenNhom.Text = data.Rows[0]["TenNhomHocPhan"].ToString();
                    cmbNhomHPKT_Loai.Text = data.Rows[0]["Loai"].ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy", "Thông báo");
                }    
            }    
        }

        private void btnXem_MonHoc_Click(object sender, EventArgs e)
        {
            dgvMonHoc.DataSource = DAO_Vy_MonHoc.Instance.XemMonHoc();
        }

        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int val = Convert.ToInt32(dgvMonHoc.Rows[e.RowIndex].Cells["MaMonHoc"].FormattedValue.ToString());

            DTO_Vy_MonHoc kh = new DTO_Vy_MonHoc(val, "", "", 0, 0);

            DataTable data = DAO_Vy_MonHoc.Instance.XemMonHocWithID(kh);

            if (data.Rows.Count > 0)
            {
                txtMonHoc_IDMon.Text = data.Rows[0]["MaMonHoc"].ToString();
                txtMonHoc_TenMon.Text = data.Rows[0]["TenMonHoc"].ToString();
                cmbMonHoc_Loai.Text = data.Rows[0]["LoaiMonHoc"].ToString();
                cmbMonHoc_NhomKT.Text = data.Rows[0]["MaNhomHocPhan"].ToString();
                cmbMonHoc_NhomCC.Text = data.Rows[0]["MaNhomChungChi"].ToString();
            }

        }

        private void btnSua_MonHoc_Click(object sender, EventArgs e)
        {
            if (txtMonHoc_IDMon.Text != "" && txtMonHoc_TenMon.Text != "" && cmbMonHoc_Loai.Text != "" &&
                cmbMonHoc_NhomKT.Text != "" && cmbMonHoc_NhomCC.Text != "")
            {
                int ma = Convert.ToInt32(txtMonHoc_IDMon.Text);
                string ten = txtMonHoc_TenMon.Text;
                string loai = cmbMonHoc_Loai.Text;
                int kt = Convert.ToInt32(cmbMonHoc_NhomKT.Text);
                int cc = Convert.ToInt32(cmbMonHoc_NhomCC.Text);

                DTO_Vy_MonHoc hp = new DTO_Vy_MonHoc(ma, ten, loai, kt, cc);

                int result = DAO_Vy_MonHoc.Instance.CapNhatMonHoc(hp);

                if (result != 0)
                {
                    MessageBox.Show("Cập nhập thành công", "Thông báo");
                    EventArgs newE = new EventArgs();
                    btnXem_MonHoc_Click(sender, newE);
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

        private void btnThem_MonHoc_Click(object sender, EventArgs e)
        {
            if (txtMonHoc_TenMon.Text != "" && cmbMonHoc_Loai.Text != "" &&
                cmbMonHoc_NhomKT.Text != "" && cmbMonHoc_NhomCC.Text != "")
            {
                string ten = txtMonHoc_TenMon.Text;
                string loai = cmbMonHoc_Loai.Text;
                int kt = Convert.ToInt32(cmbMonHoc_NhomKT.Text);
                int cc = Convert.ToInt32(cmbMonHoc_NhomCC.Text);

                DTO_Vy_MonHoc hp = new DTO_Vy_MonHoc(0, ten, loai, kt, cc);

                int result = DAO_Vy_MonHoc.Instance.ThemMonHoc(hp);

                if (result != 0)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    EventArgs newE = new EventArgs();
                    btnXem_MonHoc_Click(sender, newE);
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

        private void btnXem_ChuyenDe_Click(object sender, EventArgs e)
        {
            dgvChuyenDe.DataSource = DAO_Vy_ChuyenDe.Instance.XemChuyenDe();
        }

        private void btnSua_ChuyenDe_Click(object sender, EventArgs e)
        {
            if (txtChuyenDe_ID.Text != "" && txtChuyenDe_Ten.Text != "" && cmbChuyenDe_NhomCD.Text != "")
            {
                int ma = Convert.ToInt32(txtChuyenDe_ID.Text);
                string ten = txtChuyenDe_Ten.Text;
                int cd = Convert.ToInt32(cmbChuyenDe_NhomCD.Text);

                DTO_Vy_ChuyenDe hp = new DTO_Vy_ChuyenDe(ma, ten, cd);

                int result = DAO_Vy_ChuyenDe.Instance.CapNhatChuyenDe(hp);

                if (result != 0)
                {
                    MessageBox.Show("Cập nhập thành công", "Thông báo");
                    EventArgs newE = new EventArgs();
                    btnXem_ChuyenDe_Click(sender, newE);
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

        private void btnThem_ChuyenDe_Click(object sender, EventArgs e)
        {
            if (txtChuyenDe_Ten.Text != "" && cmbChuyenDe_NhomCD.Text != "")
            {
                string ten = txtChuyenDe_Ten.Text;
                int cd = Convert.ToInt32(cmbChuyenDe_NhomCD.Text);

                DTO_Vy_ChuyenDe hp = new DTO_Vy_ChuyenDe(0, ten, cd);

                int result = DAO_Vy_ChuyenDe.Instance.ThemChuyenDe(hp);

                if (result != 0)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    EventArgs newE = new EventArgs();
                    btnXem_ChuyenDe_Click(sender, newE);
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

        private void dgvChuyenDe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int val = Convert.ToInt32(dgvChuyenDe.Rows[e.RowIndex].Cells["MaChuyenDe"].FormattedValue.ToString());

            DTO_Vy_ChuyenDe kh = new DTO_Vy_ChuyenDe(val, "", 0);

            DataTable data = DAO_Vy_ChuyenDe.Instance.XemChuyenDeWithID(kh);

            if (data.Rows.Count > 0)
            {
                txtChuyenDe_ID.Text = data.Rows[0]["MaChuyenDe"].ToString();
                txtChuyenDe_Ten.Text = data.Rows[0]["TenChuyenDe"].ToString();
                cmbChuyenDe_NhomCD.Text = data.Rows[0]["MaNhomChuyenDe"].ToString();
            }

        }

        private void btnTimKiem_ChuyenDe_Click(object sender, EventArgs e)
        {
            string getVal = txtChuyenDe_TimKiem.Text;
            if (getVal != "")
            {
                int val = Convert.ToInt32(getVal);

                DTO_Vy_ChuyenDe kh = new DTO_Vy_ChuyenDe(val, "", 0);

                DataTable data = DAO_Vy_ChuyenDe.Instance.XemChuyenDeWithID(kh);

                if (data.Rows.Count > 0)
                {
                    txtChuyenDe_ID.Text = data.Rows[0]["MaChuyenDe"].ToString();
                    txtChuyenDe_Ten.Text = data.Rows[0]["TenChuyenDe"].ToString();
                    cmbChuyenDe_NhomCD.Text = data.Rows[0]["MaNhomChuyenDe"].ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy", "Thông báo");
                }
            }
        }

        private void btnXem_NhomCD_Click(object sender, EventArgs e)
        {
            dgvNhomCD.DataSource = DAO_Vy_NhomChuyenDe.Instance.XemNhomChuyenDe();
        }

        private void btnSua_NhomCD_Click(object sender, EventArgs e)
        {
            if (txtNhomCD_ID.Text != "" && txtNhomCD_TenNhom.Text != "")
            {
                int ma = Convert.ToInt32(txtNhomCD_ID.Text);
                string ten = txtNhomCD_TenNhom.Text;

                DTO_Vy_NhomChuyenDe hp = new DTO_Vy_NhomChuyenDe(ma, ten);

                int result = DAO_Vy_NhomChuyenDe.Instance.CapNhatNhomChuyenDe(hp);

                if (result != 0)
                {
                    MessageBox.Show("Cập nhập thành công", "Thông báo");
                    EventArgs newE = new EventArgs();
                    btnXem_NhomCD_Click(sender, newE);
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

        private void btnThem_NhomCD_Click(object sender, EventArgs e)
        {
            if (txtNhomCD_TenNhom.Text != "")
            {
                string ten = txtNhomCD_TenNhom.Text;

                DTO_Vy_NhomChuyenDe hp = new DTO_Vy_NhomChuyenDe(0, ten);

                int result = DAO_Vy_NhomChuyenDe.Instance.ThemNhomChuyenDe(hp);

                if (result != 0)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    EventArgs newE = new EventArgs();
                    btnXem_NhomCD_Click(sender, newE);
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

        private void dgvNhomCD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int val = Convert.ToInt32(dgvNhomCD.Rows[e.RowIndex].Cells["MaNhomChuyenDe"].FormattedValue.ToString());

            DTO_Vy_NhomChuyenDe kh = new DTO_Vy_NhomChuyenDe(val, "");

            DataTable data = DAO_Vy_NhomChuyenDe.Instance.XemNhomChuyenDeWithID(kh);

            if (data.Rows.Count > 0)
            {
                txtNhomCD_ID.Text = data.Rows[0]["MaNhomChuyenDe"].ToString();
                txtNhomCD_TenNhom.Text = data.Rows[0]["TenNhomChuyenDe"].ToString();
            }
        }

        private void btnTimKiem_NhomCD_Click(object sender, EventArgs e)
        {
            string getVal = txtNhomCD_TimKiem.Text;
            if (getVal != "")
            {
                int val = Convert.ToInt32(getVal);

                DTO_Vy_NhomChuyenDe kh = new DTO_Vy_NhomChuyenDe(val, "");

                DataTable data = DAO_Vy_NhomChuyenDe.Instance.XemNhomChuyenDeWithID(kh);

                if (data.Rows.Count > 0)
                {
                    txtNhomCD_ID.Text = data.Rows[0]["MaNhomChuyenDe"].ToString();
                    txtNhomCD_TenNhom.Text = data.Rows[0]["TenNhomChuyenDe"].ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy", "Thông báo");
                }
            }    
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            cmbMonHoc_NhomKT.Items.Clear();
            cmbMonHoc_NhomCC.Items.Clear();

            DataTable data = DAO_Vy_NhomHPKyThuat.Instance.XemNhomHPKyThuat();

            if (data.Rows.Count > 0)
            {
                foreach(DataRow row in data.Rows)
                {
                    cmbMonHoc_NhomKT.Items.Add(row["MaNhomHocPhan"]);
                }    
            }

            data = DAO_Vy_NhomChungChi.Instance.XemNhomChuyenChungChi();

            if (data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    cmbMonHoc_NhomCC.Items.Add(row["MaNhomChungChi"]);
                }
            }

            cmbChuyenDe_NhomCD.Items.Clear();

            data = DAO_Vy_NhomChuyenDe.Instance.XemNhomChuyenDe();

            if (data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    cmbChuyenDe_NhomCD.Items.Add(row["MaNhomChuyenDe"]);
                }
            }
        }
    }
}
