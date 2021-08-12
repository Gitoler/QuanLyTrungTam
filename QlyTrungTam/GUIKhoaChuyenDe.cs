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
    public partial class GUIKhoaChuyenDe : Form
    {
        public GUIKhoaChuyenDe()
        {
            InitializeComponent();
            //Reload();
        }

        private void GUIKhoaChuyenDe_Load(object sender, EventArgs e)
        {

        }
        private void Reload()
        {
      
            cmbHPCD_GV.Items.Clear();
            cmbHPCD_KHOA.Items.Clear();
            cmbHPCD_CHUYENDE.Items.Clear();
            cmbCD_HPCD_NAM.Items.Clear();
            cmbCD_HPCD_LICHHOC.Items.Clear();
            cmbCD_HPCD_HOCKY.Items.Clear();
        
            
            DataTable dataHPCD = DAO_Tung_KhoaChuyenDe_HocPhanChuyenDe.Instance.XemHPCD();
            foreach (DataRow tmp in dataHPCD.Rows)
            {
                cmbHPCD_GV.Items.Add(tmp["MaGiaoVien"]);
            }
            foreach(DataRow tmp in dataHPCD.Rows)
            {
                cmbHPCD_KHOA.Items.Add(tmp["MaKhoaHoc"]);
            }
            foreach (DataRow tmp in dataHPCD.Rows)
            {
                cmbHPCD_CHUYENDE.Items.Add(tmp["MaChuyenDe"]);
            }
            foreach (DataRow tmp in dataHPCD.Rows)
            {
                cmbCD_HPCD_NAM.Items.Add(tmp["NamHoc"]);
            }
            foreach (DataRow tmp in dataHPCD.Rows)
            {
                cmbCD_HPCD_LICHHOC.Items.Add(tmp["LichHoc"]);
            }
            foreach (DataRow tmp in dataHPCD.Rows)
            {
                cmbCD_HPCD_HOCKY.Items.Add(tmp["HocKy"]);
            }

            //DataTable dataGV = DAO_GiaoVien_DiemThiTotNghiep.Instance.SelectTN();
        }
        //KHOAHOCCHUYENDE

        private void btn_CD_KHCD_XEM_Click(object sender, EventArgs e)
        {
            dataGridViewKHCD.DataSource = DAO_Tung_KhoaHoc.Instance.XemKhoaHocChuyenDe();
        }

        private void KHCDCellClick(object sender, DataGridViewCellEventArgs e)
        {
            int val = Convert.ToInt32(dataGridViewKHCD.Rows[e.RowIndex].Cells["MaKhoaHoc"].FormattedValue.ToString());

            DTO_Tung_KhoaDaoTaoChuyenDe kh = new DTO_Tung_KhoaDaoTaoChuyenDe(val);

            DataTable data = DAO_Tung_KhoaChuyenDe_KhoaHocChuyenDe.Instance.XemKhoaHocCDWithID(kh);

            txtKHCD_MAKHOA.Text = data.Rows[0]["MaKhoaHoc"].ToString();

            DTO_Tung_KhoaHoc myKh = new DTO_Tung_KhoaHoc(Convert.ToInt32(txtKHCD_MAKHOA.Text), "", "", "", 0, 0);
            data = DAO_Tung_KhoaHoc.Instance.XemKhoaHocWithID(myKh);

            txtKHCD_TENKHOA.Text = data.Rows[0]["TenKhoaHoc"].ToString();
            dateTime_HPCD_NGAYBD.Value = Convert.ToDateTime(data.Rows[0]["NgayBatDau"].ToString());
            txtKHCD_MANV.Text = data.Rows[0]["MaNhanVien"].ToString();
            rtxtKHCD_MOTA.Text = data.Rows[0]["MoTa"].ToString();
        }

        private void btn_CD_KHCD_THEM_Click(object sender, EventArgs e)
        {
            string ten = txtKHCD_TENKHOA.Text;
            string date = dateTime_HPCD_NGAYBD.Value.Date.ToString();
            int nv = Convert.ToInt32(txtKHCD_MANV.Text);
            string mota = rtxtKHCD_MOTA.Text;

            DTO_Tung_KhoaHoc myKh = new DTO_Tung_KhoaHoc(0, ten, date, mota, 3, nv);

            int result = DAO_Tung_KhoaHoc.Instance.ThemKhoaHoc(myKh);

                if (result != 0)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    EventArgs newE = new EventArgs();
                    btn_CD_KHCD_XEM_Click(sender, newE);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo");
                }
           

        }
        private void btn_CD_KHCD_SUA_Click(object sender, EventArgs e)
        {
            int idkhoa = Convert.ToInt32(txtKHCD_MAKHOA.Text);
            string ten = txtKHCD_TENKHOA.Text;
            string date = dateTime_HPCD_NGAYBD.Value.Date.ToString();
            //int sl = Convert.ToInt32(txtKHKT_SL.Text);
            int nv = Convert.ToInt32(txtKHCD_MANV.Text);
            string mota = rtxtKHCD_MOTA.Text;

            DTO_Tung_KhoaHoc myKh = new DTO_Tung_KhoaHoc(idkhoa, ten, date, mota, 3, nv);

            int result = DAO_Tung_KhoaHoc.Instance.CapNhatKhoaHoc(myKh);

                if (result != 0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo");
                    EventArgs newE = new EventArgs();
                    btn_CD_KHCD_XEM_Click(sender, newE);
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Thông báo");
                }
            
        }

        //HOCPHANCHUYENDE
        private void btn_CD_HPCD_XEM_Click(object sender, EventArgs e)
        {
            dataGridViewHPCD.DataSource = DAO_Tung_KhoaChuyenDe_HocPhanChuyenDe.Instance.XemHPCD();
        }

        private void HPCDCellClick(object sender, DataGridViewCellEventArgs e)
        {
            int mahp = Convert.ToInt32(dataGridViewHPCD.Rows[e.RowIndex].Cells["MaHPChuyenDe"].FormattedValue.ToString());
            DataTable dataHPCD = DAO_Tung_KhoaChuyenDe_HocPhanChuyenDe.Instance.XemHPCD_WithID(mahp);
            txt_HPCD_MAHP.Text = dataHPCD.Rows[0]["MaHPChuyenDe"].ToString();
            cmbHPCD_KHOA.Text = dataHPCD.Rows[0]["MaKhoaHoc"].ToString();
            cmbHPCD_CHUYENDE.Text = dataHPCD.Rows[0]["MaChuyenDe"].ToString();
            cmbCD_HPCD_NAM.Text = dataHPCD.Rows[0]["NamHoc"].ToString();
            cmbCD_HPCD_HOCKY.Text = dataHPCD.Rows[0]["HocKy"].ToString();
            cmbCD_HPCD_LICHHOC.Text = dataHPCD.Rows[0]["LichHoc"].ToString();
            //txtHPCD_NAM.Text = dataHPCD.Rows[0]["NamHoc"].ToString();
            //txtHPCD_HOCKI.Text = dataHPCD.Rows[0]["HocKy"].ToString();
            //txtHPCD_LICHHOC.Text = dataHPCD.Rows[0]["LichHoc"].ToString();
            cmbHPCD_GV.Text = dataHPCD.Rows[0]["MaGiaoVien"].ToString();
        }

        private void btn_CD_HPCD_THEM_Click(object sender, EventArgs e)
        {
            int nam = Convert.ToInt32(cmbCD_HPCD_NAM.Text);
            string hocky = cmbCD_HPCD_HOCKY.Text;
            string lich = cmbCD_HPCD_LICHHOC.Text;
            string phong = cmbHPCD_PHONG.Text;
            int gv = Convert.ToInt32(cmbHPCD_GV.Text);
            int cd = Convert.ToInt32(cmbHPCD_CHUYENDE.Text);
            int ct = Convert.ToInt32(cmbHPCD_KHOA.Text);


            DTO_Tung_HocPhanChuyenDe kh = new DTO_Tung_HocPhanChuyenDe(0, nam, hocky, lich, phong, cd, gv, ct);

            int rerult = DAO_Tung_KhoaChuyenDe_HocPhanChuyenDe.Instance.ThemHPCD(kh);

            if (rerult != 0)
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo");
                EventArgs newE = new EventArgs();
                btn_CD_HPCD_XEM_Click(sender, newE);
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại", "Thông báo");
            }
        }

        private void btn_CD_HPCD_SUA_Click(object sender, EventArgs e)
        {
            int mahp = Convert.ToInt32(txt_HPCD_MAHP.Text);
           
            int nam = Convert.ToInt32(cmbCD_HPCD_NAM.Text);
            string hocky = cmbCD_HPCD_HOCKY.Text;
            string lich =cmbCD_HPCD_LICHHOC.Text;
            string phong = cmbHPCD_PHONG.Text;
            int gv = Convert.ToInt32(cmbHPCD_GV.Text);
            int cd = Convert.ToInt32(cmbHPCD_CHUYENDE.Text);
            int ct = Convert.ToInt32(cmbHPCD_KHOA.Text);


            DTO_Tung_HocPhanChuyenDe kh = new DTO_Tung_HocPhanChuyenDe(mahp, nam, hocky, lich, phong, cd, gv, ct);

            int rerult = DAO_Tung_KhoaChuyenDe_HocPhanChuyenDe.Instance.CapNhatHPCD(kh);

            if (rerult != 0)
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo");
                EventArgs newE = new EventArgs();
                btn_CD_HPCD_XEM_Click(sender, newE);
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại", "Thông báo");
            }
        }

   
    }
}
