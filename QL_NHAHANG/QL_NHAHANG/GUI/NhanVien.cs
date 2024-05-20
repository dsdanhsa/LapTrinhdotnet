using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace QL_NHAHANG
{
    public partial class frm_NhanVien : Form
    {
        LopDungChung lopchung;
        BLL.BllNHANVIEN bll_NV;
        public frm_NhanVien()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
            bll_NV = new BLL.BllNHANVIEN(this);
        }
        public void LoadData()
        {
            bll_NV.BllLoadGrid();
        }
        public void LoadCongViec()
        {
            bll_NV.BllLoadCombo();
        }
        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            LoadCongViec();
            LoadData();
        }

        

        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\HINHANH\\";
        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image.Save(duongdan + txt_HinhAnh.Text);
                bll_NV.BllThem();
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa có tên hình");
            }
            LoadData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(duongdan + txt_HinhAnh.Text))
                {
                    File.Delete(duongdan + txt_HinhAnh.Text);
                    bll_NV.BllXoa();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Hình ảnh không tồn tại.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi khi xóa hình ảnh");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            
            try
            {
                pictureBox1.Image.Save(duongdan + txt_HinhAnh.Text);
                bll_NV.BllSua();
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa có tên hình");
            }
            LoadData();
        }

        private void btn_Dem_Click(object sender, EventArgs e)
        {
            bll_NV.BllDem();
        }

        int tim = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNV.Text = dataGridView1.CurrentRow.Cells["MaNV"].Value.ToString();
            txt_HoTen.Text = dataGridView1.CurrentRow.Cells["HoTen"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["NgayVaoLam"].Value.ToString();
            txt_HinhAnh.Text = dataGridView1.CurrentRow.Cells["TenHinh"].Value.ToString();
            pictureBox1.ImageLocation = duongdan + txt_HinhAnh.Text;
            tim = 1;
            cb_CongViec.SelectedValue = dataGridView1.CurrentRow.Cells["MaCongViec"].Value.ToString();
            tim = 0;
        }

        private void btn_LoadGrip_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "Hãy Chọn Hình";
            OFD.Filter = "Tất cả đuôi hình|*.*|PNG|*.png|JPG|*.jpg|JPEG|*.jpeg ";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(OFD.FileName);
            }
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            bll_NV.BllTim();
        }

        private void cb_CongViec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tim == 0)
            {
                bll_NV.BllComboCongViec();
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
