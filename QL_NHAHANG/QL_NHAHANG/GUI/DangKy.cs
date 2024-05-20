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

namespace QL_NHAHANG
{
    public partial class frm_DangKy : Form
    {
        LopDungChung lopchung;
        BLL.BllDANGKY bll_DK;
        public frm_DangKy()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
            bll_DK = new BLL.BllDANGKY(this);
        }
        public bool CheckEmail(string mail)
        {
            return Regex.IsMatch(mail, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_MatKhauDangKy.Text != txt_xnMatKhau.Text)
                {
                    MessageBox.Show("Mật khẩu xác nhận phải giống với mật khẩu");
                }
                else if (txt_TenDangKy.Text == "" || txt_TenDangNhap.Text == "" || txt_MatKhauDangKy.Text == "")
                    MessageBox.Show("bạn phải nhập tên đăng ký, tên đăng nhập, mật khẩu");
                else if (txt_TenDangNhap.Text == "")
                    MessageBox.Show("bạn phải nhập tên đăng nhập");
                else if (txt_MatKhauDangKy.Text == "")
                    MessageBox.Show("bạn phải nhập mật khẩu");
                else if (!CheckEmail(txt_Email.Text))
                    MessageBox.Show("bạn phải nhập đúng định dạng email");
                else
                {
                    bll_DK.BllBtnDangKy();
                    MessageBox.Show("Đăng ký thành công");
                }
            }
            catch
            {
                MessageBox.Show("Đã đăng ký tài khoản này");
            }
            LoadGrid();
        }
        public void LoadGrid()
        {
            bll_DK.BllLoadGrid();
        }

        private void frm_DangKy_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_TenDangNhap.Text = dataGridView1.CurrentRow.Cells["TenDangNhap"].Value.ToString();
            txt_MatKhauDangKy.Text = dataGridView1.CurrentRow.Cells["MatKhau"].Value.ToString();
            txt_xnMatKhau.Text = dataGridView1.CurrentRow.Cells["XacNhanMatKhau"].Value.ToString();
            txt_Email.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            txt_TenDangKy.Text = dataGridView1.CurrentRow.Cells["TenDangKy"].Value.ToString();
            txt_DiaChi.Text = dataGridView1.CurrentRow.Cells["DiaChi"].Value.ToString();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            bll_DK.BllBtnXoa();
            LoadGrid();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_MatKhauDangKy.Text != txt_xnMatKhau.Text)
                {
                    MessageBox.Show("Mật khẩu xác nhận phải giống với mật khẩu");
                }
                else if (txt_TenDangKy.Text == "")
                    MessageBox.Show("bạn phải nhập tên đăng ký");
                else if (txt_TenDangNhap.Text == "")
                    MessageBox.Show("bạn phải nhập tên đăng nhập");
                else if (txt_MatKhauDangKy.Text == "")
                    MessageBox.Show("bạn phải nhập mật khẩu");
                else if (!CheckEmail(txt_Email.Text))
                    MessageBox.Show("bạn phải nhập đúng định dạng email");
                else
                {
                    bll_DK.BllBtnSua();
                    MessageBox.Show("Sửa thành công");
                }
            }
            catch
            {
                MessageBox.Show("Sửa không thành công");
            }
            LoadGrid();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            this.Close();
            if (Application.OpenForms["frm_DangNhap"] == null)
            {
                frm_DangNhap TT = new frm_DangNhap();
                TT.MdiParent = this;
                TT.Show();
            }
            else Application.OpenForms["frm_DangNhap"].Activate();
        }
    }
}
