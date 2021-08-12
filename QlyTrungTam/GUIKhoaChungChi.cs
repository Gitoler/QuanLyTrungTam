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
    public partial class GUIKhoaChungChi : Form
    {
        public GUIKhoaChungChi()
        {
            InitializeComponent();
        }

        private void button65_Click(object sender, EventArgs e)
        {
            dtgvkhoachungchi.DataSource = DAO_KhoaChungChi_KhoaHocChungChi.Instance.XemKhoaHocCC();
        }

        private void themkhoacc_Click(object sender, EventArgs e)
        {
            string tenkhoa = p1tkcc.Text;
            if(tenkhoa == null || tenkhoa == "")
            {
                MessageBox.Show("Thêm thất bại. Tên khoá không được để trống.", "Thông báo");
                return;
            }
            string ngaybatdau = p1nbd.Value.Date.ToString();
            string chungchi = p1ncc.Text;
            int icc = 0;
            if(chungchi == "B")
            {
                icc = 2;
            }
            else
            {
                icc = 1;
            }
            string soluonghocphan = p1slhp.Text;
            int islhp = 0;
            if (Regex.IsMatch(soluonghocphan, "[0-9]", RegexOptions.IgnoreCase))
            {
                islhp = Convert.ToInt32(soluonghocphan);
            }
            else
            {
                MessageBox.Show("Thêm thất bại. Số lương học phần phải là số.", "Thông báo");
                return;
            }
            
            string mota = p1mt.Text;
            int idnhanvien = Convert.ToInt32(DAO_KhoaChungChi_KhoaHocChungChi.Instance.GetIDNhanVien());

            DTO_KhoaChungChi_KhoaHocChungChi cc = new DTO_KhoaChungChi_KhoaHocChungChi(1, icc, islhp);
            DTO_KhoaChungChi_KhoaHoc kh = new DTO_KhoaChungChi_KhoaHoc(1, tenkhoa, ngaybatdau, mota, idnhanvien);
            int rerult = DAO_KhoaChungChi_KhoaHocChungChi.Instance.ThemKhoaHoc(kh, cc);

            if (rerult != 0)
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
                EventArgs newE = new EventArgs();
                button65_Click(sender, newE);
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Thông báo");
            }
            Reload();
        }

        private void GUIKhoaChungChi_Load(object sender, EventArgs e)
        {
            p1idnv.Text = DAO_KhoaChungChi_KhoaHocChungChi.Instance.GetIDNhanVien();
            
            Reload();
        }

        private void Reload()
        {
            p2kh.Items.Clear();
            p2gv.Items.Clear();
            p2mh.Items.Clear();
            p3hp.Items.Clear();
            DataTable dataKH = DAO_KhoaChungChi_HocPhanCC.Instance.SelectKhoaHoc();
            foreach (DataRow tmp in dataKH.Rows)
            {
                p2kh.Items.Add(tmp["MaKhoaHoc"]);
            }
            DataTable dataGV = DAO_KhoaChungChi_HocPhanCC.Instance.SelectGiaoVien();
            foreach (DataRow tmp in dataGV.Rows)
            {
                p2gv.Items.Add(tmp["MaGiaoVien"]);
            }
            DataTable dataMH = DAO_KhoaChungChi_HocPhanCC.Instance.SelectMonHoc();
            foreach (DataRow tmp in dataMH.Rows)
            {
                p2mh.Items.Add(tmp["MaMonHoc"]);
            }
            DataTable datahp = DAO_KhoaChungChi_LichThi.Instance.SelectHocPhan();
            foreach (DataRow tmp in datahp.Rows)
            {
                p3hp.Items.Add(tmp["MaHPCC"]);
            }
        }
        private void dtgvkhoachungchi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int val = Convert.ToInt32(dtgvkhoachungchi.Rows[e.RowIndex].Cells["MaKhoaHoc"].FormattedValue.ToString());

            DTO_KhoaChungChi_KhoaHoc kh = new DTO_KhoaChungChi_KhoaHoc(val, "", "", "", 0);
            DTO_KhoaChungChi_KhoaHocChungChi cc = new DTO_KhoaChungChi_KhoaHocChungChi(val, 0, 0);
            DataTable data = DAO_KhoaChungChi_KhoaHocChungChi.Instance.XemKhoaHocCCWithID(kh, cc);

            p1idkcc.Text = data.Rows[0]["MaKhoaHoc"].ToString();
            p1tkcc.Text = data.Rows[0]["TenKhoaHoc"].ToString();
            p1nbd.Value = Convert.ToDateTime(data.Rows[0]["NgayBatDau"].ToString());
            if(Convert.ToInt32(data.Rows[0]["MaNhomChungChi"]) == 1)
            {
                p1ncc.Text = "A";
            }else
            {
                p1ncc.Text = "B";
            } 
            p1slhp.Text = data.Rows[0]["SoLuongHPCC"].ToString();
            p1mt.Text = data.Rows[0]["MoTa"].ToString();
            p1idnv.Text = data.Rows[0]["MaNhanVien"].ToString();
        }

        private void p1sua_Click(object sender, EventArgs e)
        {
            if (p1idkcc.Text == null || p1idkcc.Text == "")
            {
                return;
            }
            int idkhoa = Convert.ToInt32(p1idkcc.Text);
            string tenkhoa = p1tkcc.Text;
            string date = p1nbd.Value.Date.ToString();
            string chungchi = p1ncc.Text;
            int icc = 0;
            if (chungchi == "B")
            {
                
                icc = 2;
            }
            else
            {
                icc = 1;
            }
            string soluonghocphan = p1slhp.Text;
            int islhp = 0;
            if (Regex.IsMatch(soluonghocphan, "[0-9]", RegexOptions.IgnoreCase))
            {
                islhp = Convert.ToInt32(soluonghocphan);
            }
            else
            {
                MessageBox.Show("Sửa thất bại. Số lương học phần phải là số.", "Thông báo");
                return;
            }
            string mota = p1mt.Text;
            int idnhanvien = Convert.ToInt32(DAO_KhoaChungChi_KhoaHocChungChi.Instance.GetIDNhanVien());

            DTO_KhoaChungChi_KhoaHoc kh = new DTO_KhoaChungChi_KhoaHoc(idkhoa, tenkhoa, date, mota, idnhanvien);
            DTO_KhoaChungChi_KhoaHocChungChi cc = new DTO_KhoaChungChi_KhoaHocChungChi(idkhoa, icc, islhp);
           int result = DAO_KhoaChungChi_KhoaHocChungChi.Instance.CapNhatKhoaHoc(kh, cc);

            if (result != 0)
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo");
                EventArgs newE = new EventArgs();
                button65_Click(sender, newE);
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại", "Thông báo");
            }

            Reload();
        }
//---------------------------------------------------------------------P2---------------------------------------
        private void p2them_Click(object sender, EventArgs e)
        {
            int idmh = 0;
            if (Regex.IsMatch(p2mh.Text, "[0-9]", RegexOptions.IgnoreCase))
            {
                idmh = Convert.ToInt32(p2mh.Text);
            }
            else
            {
                MessageBox.Show("Thêm thất bại. Môn học phải là số.", "Thông báo");
                return;
            }

            int namhoc = 0;
            if (Regex.IsMatch(p2idhp.Text, "[0-9]", RegexOptions.IgnoreCase))
            {
                namhoc = Convert.ToInt32(p2nh.Text);
            }
            else
            {
                MessageBox.Show("Thêm thất bại. Năm học phải là số.", "Thông báo");
                return;
            }

            int hocki = 0;
            if (Regex.IsMatch(p2hk.Text, "[0-9]", RegexOptions.IgnoreCase))
            {
                hocki = Convert.ToInt32(p2hk.Text);
                if (hocki < 1 && hocki > 3)
                {
                    hocki = 1;
                }
            }
            else
            {
                MessageBox.Show("Thêm thất bại. Học kì phải là số.", "Thông báo");
                return;
            }
            int kh1 = 0;
            if (Regex.IsMatch(p2kh.Text, "[0-9]", RegexOptions.IgnoreCase))
            {
                kh1 = Convert.ToInt32(p2kh.Text);
            }
            else
            {
                MessageBox.Show("Thêm thất bại. Học kì phải là số.", "Thông báo");
                return;
            }
            string lichhoc = p2lh.Text;

            int giaovien = 0;
            if (Regex.IsMatch(p2gv.Text, "[0-9]", RegexOptions.IgnoreCase))
            {
                giaovien = Convert.ToInt32(p2gv.Text);
            }
            else
            {
                MessageBox.Show("Thêm thất bại. Giáo viên phải là số.", "Thông báo");
                return;
            }

            string phonghoc = p2ph.Text;

            DTO_KhoaChungChi_HocPhanCC kh = new DTO_KhoaChungChi_HocPhanCC(0, kh1, 0, idmh, namhoc, hocki, lichhoc, giaovien, phonghoc);

            int rerult = DAO_KhoaChungChi_HocPhanCC.Instance.ThemCTKhoaHoc(kh);

            if (rerult != 0)
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
                EventArgs newE = new EventArgs();
                p2xem_Click(sender, newE);
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Thông báo");
            }
        }

        private void p2xem_Click(object sender, EventArgs e)
        {
            p2dtgv.DataSource = DAO_KhoaChungChi_HocPhanCC.Instance.XemHocPhan();
        }

        private void p2dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int val = Convert.ToInt32(p2dtgv.Rows[e.RowIndex].Cells["MaHPCC"].FormattedValue.ToString());

            DTO_KhoaChungChi_HocPhanCC kh = new DTO_KhoaChungChi_HocPhanCC(val,0,0,0,0,0,"",0,"");

            DataTable data = DAO_KhoaChungChi_HocPhanCC.Instance.XemHocPhanWithID(kh);

            p2idhp.Text = data.Rows[0]["MaHPCC"].ToString();
            p2nh.Text = data.Rows[0]["NamHoc"].ToString();
            p2hk.Text = data.Rows[0]["HocKy"].ToString();
            p2lh.Text = data.Rows[0]["LichHoc"].ToString();
            p2ph.Text = data.Rows[0]["Phong"].ToString();
            p2mh.Text = data.Rows[0]["MaMonHoc"].ToString();
            p2gv.Text = data.Rows[0]["MaGiaoVien"].ToString();
            p2ncc.Text = data.Rows[0]["TenNhomChungChi"].ToString();
            p2kh.Text = data.Rows[0]["MaKhoaHoc"].ToString();
        }

        private void p2sua_Click(object sender, EventArgs e)
        {
            if(p2idhp.Text == null || p2idhp.Text == "")
            {
                return;
            }

            int idhp = Convert.ToInt32(p2idhp.Text);

            int idmh = 0;
            if (Regex.IsMatch(p2mh.Text, "[0-9]", RegexOptions.IgnoreCase))
            {
                idmh = Convert.ToInt32(p2mh.Text);
            }
            else
            {
                MessageBox.Show("Sửa thất bại. Môn học phải là số.", "Thông báo");
                return;
            }

            int kh1 = 0;
            if (Regex.IsMatch(p2kh.Text, "[0-9]", RegexOptions.IgnoreCase))
            {
                kh1 = Convert.ToInt32(p2kh.Text);
            }
            else
            {
                MessageBox.Show("Sửa thất bại. Môn học phải là số.", "Thông báo");
                return;
            }

            int namhoc = 0;
            if (Regex.IsMatch(p2idhp.Text, "[0-9]", RegexOptions.IgnoreCase))
            {
                namhoc = Convert.ToInt32(p2nh.Text);
            }
            else
            {
                MessageBox.Show("Sửa thất bại. Năm học phải là số.", "Thông báo");
                return;
            }

            int hocki = 0;
            if (Regex.IsMatch(p2hk.Text, "[0-9]", RegexOptions.IgnoreCase))
            {
                hocki = Convert.ToInt32(p2hk.Text);
                if(hocki < 1 && hocki > 3)
                {
                    hocki = 1;
                }
            }
            else
            {
                MessageBox.Show("Sửa thất bại. Học kì phải là số.", "Thông báo");
                return;
            }

            string lichhoc = p2lh.Text;

            int giaovien = 0;
            if (Regex.IsMatch(p2gv.Text, "[0-9]", RegexOptions.IgnoreCase))
            {
                giaovien = Convert.ToInt32(p2gv.Text);
            }
            else
            {
                MessageBox.Show("Sửa thất bại. Giáo viên phải là số.", "Thông báo");
                return;
            }

            string phonghoc = p2ph.Text;

            DTO_KhoaChungChi_HocPhanCC kh = new DTO_KhoaChungChi_HocPhanCC(idhp, kh1, 0, idmh, namhoc, hocki, lichhoc, giaovien, phonghoc);

            int rerult = DAO_KhoaChungChi_HocPhanCC.Instance.CapNhatHPCC(kh);

            if (rerult != 0)
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo");
                EventArgs newE = new EventArgs();
                p2xem_Click(sender, newE);
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại", "Thông báo");
            }
        }
//---------------------------------------------------------------------P3---------------------------------------
        private void p3xem_Click(object sender, EventArgs e)
        {
            p3dtgv.DataSource = DAO.DAO_KhoaChungChi_LichThi.Instance.XemLichThi();
        }

        private void p3dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int val = Convert.ToInt32(p3dtgv.Rows[e.RowIndex].Cells["MaLichThiHPCC"].FormattedValue.ToString());

            DTO_KhoaChungChi_LichThi kh = new DTO_KhoaChungChi_LichThi(val,"","", 0, 0);

            DataTable data = DAO_KhoaChungChi_LichThi.Instance.XemLichThiWithID(kh);

            p3idlt.Text = data.Rows[0]["MaLichThiHPCC"].ToString();
            p3ncc.Text = data.Rows[0]["TenNhomChungChi"].ToString();
            p3mh.Text = data.Rows[0]["TenMonHoc"].ToString();
            p3hp.Text = data.Rows[0]["MaHPCC"].ToString();
            p3nt.Text = data.Rows[0]["NgayThi"].ToString();
            p3pt.Text = data.Rows[0]["PhongThi"].ToString();
            p3nv.Text = data.Rows[0]["MaNhanVien"].ToString();
        }

        private void p3them_Click(object sender, EventArgs e)
        {
            string mhp = p3hp.Text;
            int imhp = 0;
            if (Regex.IsMatch(p3hp.Text, "[0-9]", RegexOptions.IgnoreCase))
            {
                imhp = Convert.ToInt32(p3hp.Text);
            }
            else
            {
                MessageBox.Show("Sửa thất bại. Học phần phải là số.", "Thông báo");
                return;
            }
            string nt = p3nt.Value.Date.ToString();
            string pt = p3pt.Text;

            DTO_KhoaChungChi_LichThi kh = new DTO_KhoaChungChi_LichThi(0, nt, pt, imhp,
                    Convert.ToInt32(DAO_KhoaChungChi_KhoaHocChungChi.Instance.GetIDNhanVien()));

            int rerult = DAO_KhoaChungChi_LichThi.Instance.ThemLT(kh);

            if (rerult != 0)
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
                EventArgs newE = new EventArgs();
                p3xem_Click(sender, newE);
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Thông báo");
            }
        }

        private void p3sua_Click(object sender, EventArgs e)
        {
            string mlt = p3idlt.Text;
            string mhpcc = p3hp.Text;
            string nt = p3nt.Value.Date.ToString();
            string pt = p3pt.Text;

            DTO_KhoaChungChi_LichThi kh = new DTO_KhoaChungChi_LichThi(Convert.ToInt32(mlt),nt,pt, Convert.ToInt32(mhpcc), 0);
            DTO_KhoaChungChi_HocPhan hp = new DTO_KhoaChungChi_HocPhan(Convert.ToInt32(mhpcc));
            int rerult = DAO_KhoaChungChi_LichThi.Instance.SuaLT(kh, hp);

            if (rerult != 0)
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo");
                EventArgs newE = new EventArgs();
                p2xem_Click(sender, newE);
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại", "Thông báo");
            }
        }

        private void p1timkiem_Click(object sender, EventArgs e)
        {
            int val = 1;
            if (Regex.IsMatch(p1tktb.Text, "[0-9]", RegexOptions.IgnoreCase))
            {
                val = Convert.ToInt32(p1tktb.Text);
            }
            else
            {
                MessageBox.Show("Tìm kiếm thất bại. Mã lịch phải là số.", "Thông báo");
                return;
            }
            
            DTO_KhoaChungChi_KhoaHoc kh = new DTO_KhoaChungChi_KhoaHoc(val, "", "", "", 0);
            DTO_KhoaChungChi_KhoaHocChungChi cc = new DTO_KhoaChungChi_KhoaHocChungChi(val, 0, 0);
            DataTable data = DAO_KhoaChungChi_KhoaHocChungChi.Instance.XemKhoaHocCCWithID(kh, cc);
            if(data.Rows.Count == 0)
            {
                MessageBox.Show("Tìm kiếm thất bại. Không tồn tại.", "Thông báo");
                return;
            }
            dtgvkhoachungchi.DataSource = data;

            p1idkcc.Text = data.Rows[0]["MaKhoaHoc"].ToString();
            p1tkcc.Text = data.Rows[0]["TenKhoaHoc"].ToString();
            p1nbd.Value = Convert.ToDateTime(data.Rows[0]["NgayBatDau"].ToString());
            if (Convert.ToInt32(data.Rows[0]["MaNhomChungChi"]) == 1)
            {
                p1ncc.Text = "A";
            }
            else
            {
                p1ncc.Text = "B";
            }
            p1slhp.Text = data.Rows[0]["SoLuongHPCC"].ToString();
            p1mt.Text = data.Rows[0]["MoTa"].ToString();
            p1idnv.Text = data.Rows[0]["MaNhanVien"].ToString();
        }

        private void p2tk_Click(object sender, EventArgs e)
        {
            int val = 1;
            if (Regex.IsMatch(p2tktb.Text, "[0-9]", RegexOptions.IgnoreCase))
            {
                val = Convert.ToInt32(p2tktb.Text);
            }
            else
            {
                MessageBox.Show("Tìm kiếm thất bại. Mã lịch phải là số.", "Thông báo");
                return;
            }

            DTO_KhoaChungChi_HocPhanCC kh = new DTO_KhoaChungChi_HocPhanCC(val, 0, 0, 0, 0, 0, "", 0, "");

            DataTable data = DAO_KhoaChungChi_HocPhanCC.Instance.XemHocPhanWithID(kh);
            if (data.Rows.Count == 0)
            {
                MessageBox.Show("Tìm kiếm thất bại. Không tồn tại.", "Thông báo");
                return;
            }
            p2dtgv.DataSource = data;
            p2idhp.Text = data.Rows[0]["MaHPCC"].ToString();
            p2nh.Text = data.Rows[0]["NamHoc"].ToString();
            p2hk.Text = data.Rows[0]["HocKy"].ToString();
            p2lh.Text = data.Rows[0]["LichHoc"].ToString();
            p2ph.Text = data.Rows[0]["Phong"].ToString();
            p2mh.Text = data.Rows[0]["MaMonHoc"].ToString();
            p2gv.Text = data.Rows[0]["MaGiaoVien"].ToString();
            p2ncc.Text = data.Rows[0]["TenNhomChungChi"].ToString();
            p2kh.Text = data.Rows[0]["MaKhoaHoc"].ToString();
        }

        private void p3timkiem_Click(object sender, EventArgs e)
        {
            int val = 1;
            if (Regex.IsMatch(p3tktb.Text, "[0-9]", RegexOptions.IgnoreCase))
            {
                val = Convert.ToInt32(p3tktb.Text);
            }
            else
            {
                MessageBox.Show("Tìm kiếm thất bại. Mã lịch phải là số.", "Thông báo");
                return;
            }
            DTO_KhoaChungChi_LichThi kh = new DTO_KhoaChungChi_LichThi(val, "", "", 0, 0);

            DataTable data = DAO_KhoaChungChi_LichThi.Instance.XemLichThiWithID(kh);
            if (data.Rows.Count == 0)
            {
                MessageBox.Show("Tìm kiếm thất bại. Không tồn tại.", "Thông báo");
                return;
            }
            p3dtgv.DataSource = data;
            p3idlt.Text = data.Rows[0]["MaLichThiHPCC"].ToString();
            p3ncc.Text = data.Rows[0]["TenNhomChungChi"].ToString();
            p3mh.Text = data.Rows[0]["TenMonHoc"].ToString();
            p3hp.Text = data.Rows[0]["MaHPCC"].ToString();
            p3nt.Text = data.Rows[0]["NgayThi"].ToString();
            p3pt.Text = data.Rows[0]["PhongThi"].ToString();
            p3nv.Text = data.Rows[0]["MaNhanVien"].ToString();
        }
    }
}
