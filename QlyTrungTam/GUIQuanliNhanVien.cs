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
    public partial class GUIQuanliNhanVien : Form
    {
        BindingSource giaovienList = new BindingSource();
        BindingSource nhanvienList = new BindingSource();
        public GUIQuanliNhanVien()
        {
            InitializeComponent();
            LoadListGiaoVien();
            AddGiaoVienBiding();
            LoadListNhanVien();
            AddNhanVienBiding();

        }
        #region Methods
        List<GiaoVien> SearchGiaoVien(string giaovienname)
        {
            List<GiaoVien> listGiaoVien = DAO_GiaoVien.Instance.SearchGiaoVienListByName(giaovienname);
            return listGiaoVien;
        }
        List<NhanVien> SearchNhanVien(string nhanvienname)
        {
            List<NhanVien> listNhanVien = DAO_NhanVien.Instance.SearchNhanVienListByName(nhanvienname);
            return listNhanVien;
        }
        void LoadListGiaoVien()
        {
            giaovienList.DataSource = DAO_GiaoVien.Instance.GetGiaoVienList();
            dtgvGiaoVien.DataSource = giaovienList;
        }
        void AddGiaoVienBiding()
        {
            txbGiaoVienName.DataBindings.Add(new Binding("text", dtgvGiaoVien.DataSource, "giaovien_Name", true, DataSourceUpdateMode.Never));
            txbGiaoVienEmail.DataBindings.Add(new Binding("text", dtgvGiaoVien.DataSource, "giaovien_Email", true, DataSourceUpdateMode.Never));
            txbGiaoVienID.DataBindings.Add(new Binding("text", dtgvGiaoVien.DataSource, "giaovien_ID", true, DataSourceUpdateMode.Never));
            txbGiaoVienSDT.DataBindings.Add(new Binding("text", dtgvGiaoVien.DataSource, "giaovien_SDT", true, DataSourceUpdateMode.Never));
            txbGiaoVienAdress.DataBindings.Add(new Binding("text", dtgvGiaoVien.DataSource, "giaovien_Adress", true, DataSourceUpdateMode.Never));
        }

        void LoadListNhanVien()
        {
            nhanvienList.DataSource = DAO_NhanVien.Instance.GetNhanVienList();
            dtgvNhanVien.DataSource = nhanvienList;
        }
        void AddNhanVienBiding()
        {
            txbNhanVienName.DataBindings.Add(new Binding("text", dtgvNhanVien.DataSource, "nhanvien_Name", true, DataSourceUpdateMode.Never));
            txbNhanVienEmail.DataBindings.Add(new Binding("text", dtgvNhanVien.DataSource, "nhanvien_Email", true, DataSourceUpdateMode.Never));
            txbNhanVienID.DataBindings.Add(new Binding("text", dtgvNhanVien.DataSource, "nhanvien_ID", true, DataSourceUpdateMode.Never));
            txbNhanVienSDT.DataBindings.Add(new Binding("text", dtgvNhanVien.DataSource, "nhanvien_SDT", true, DataSourceUpdateMode.Never));
            txbNhanVienAdress.DataBindings.Add(new Binding("text", dtgvNhanVien.DataSource, "nhanvien_Adress", true, DataSourceUpdateMode.Never));
        }
        #endregion

        #region Events
        private void btnGiaoVienXem_Click(object sender, EventArgs e)
        {
            LoadListGiaoVien();
        }

        private void btnGiaoVienSua_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbGiaoVienID.Text);
            string name = txbGiaoVienName.Text;
            string sdt = txbGiaoVienSDT.Text;
            string email = txbGiaoVienEmail.Text;
            string adress = txbGiaoVienAdress.Text;

            if (DAO_GiaoVien.Instance.UpdateGiaoVien(id, name, sdt, email, adress))
            {
                MessageBox.Show("Sửa giáo viên thành công");
                LoadListGiaoVien();
            }
            else
            {
                MessageBox.Show("Lỗi sửa giáo viên");
            }
        }

        private void btnGiaoVienXoa_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbGiaoVienID.Text);

            if (DAO_GiaoVien.Instance.DeleteGiaoVien(id))
            {
                MessageBox.Show("Xóa giáo viên thành công");
                LoadListGiaoVien();
            }
            else
            {
                MessageBox.Show("Lỗi xóa giáo viên");
            }
        }

        private void btnGiaoVienThem_Click(object sender, EventArgs e)
        {
            string name = txbGiaoVienName.Text;
            string sdt = txbGiaoVienSDT.Text;
            string email = txbGiaoVienEmail.Text;
            string adress = txbGiaoVienAdress.Text;

            if (DAO_GiaoVien.Instance.InsertGiaoVien( name, sdt, email, adress))
            {
                MessageBox.Show("Thêm giáo viên thành công");
                LoadListGiaoVien();
            }
            else
            {
                MessageBox.Show("Lỗi thêm giáo viên");
            }
        }

        private void btnGiaoVienTimKiem_Click(object sender, EventArgs e)
        {
            string GiaoVienname = txbGiaoVienTimKiem.Text;
            giaovienList.DataSource = SearchGiaoVien(GiaoVienname);
        }

        private void btnNhanVienXem_Click(object sender, EventArgs e)
        {
            LoadListGiaoVien();
        }

        private void btnNhanVienSua_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbNhanVienID.Text);
            string name = txbNhanVienName.Text;
            string sdt = txbNhanVienSDT.Text;
            string email = txbNhanVienEmail.Text;
            string adress = txbNhanVienAdress.Text;

            if (DAO_NhanVien.Instance.UpdateNhanVien(id, name, sdt, email, adress))
            {
                MessageBox.Show("Sửa nhân viên thành công");
                LoadListNhanVien();
            }
            else
            {
                MessageBox.Show("Lỗi sửa nhân viên");
            }
        }

        private void btnNhanVienXoa_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbNhanVienID.Text);

            if (DAO_NhanVien.Instance.DeleteNhanVien(id))
            {
                MessageBox.Show("Xóa nhân viên thành công");
                LoadListNhanVien();
            }
            else
            {
                MessageBox.Show("Lỗi xóa nhân viên");
            }
        }

        private void btnNhanVienThem_Click(object sender, EventArgs e)
        {
            string name = txbNhanVienName.Text;
            string sdt = txbNhanVienSDT.Text;
            string email = txbNhanVienEmail.Text;
            string adress = txbNhanVienAdress.Text;

            if (DAO_NhanVien.Instance.InsertNhanVien(name, sdt, email, adress))
            {
                MessageBox.Show("Thêm nhân viên thành công");
                LoadListNhanVien();
            }
            else
            {
                MessageBox.Show("Lỗi thêm nhân viên");
            }
        }

        private void btnNhanVienTimKiem_Click(object sender, EventArgs e)
        {
            string NhanVienname = txbNhanVienTimKiem.Text;
            nhanvienList.DataSource = SearchNhanVien(NhanVienname);
        }
        #endregion
    }
}


