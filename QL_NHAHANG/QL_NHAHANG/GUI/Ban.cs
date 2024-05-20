using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NHAHANG
{
    public partial class frm_Ban : Form
    {
        LopDungChung lopchung;
        BLL.BllBAN bll_BAN;
        public frm_Ban()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
            bll_BAN = new BLL.BllBAN(this);
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_Menu"] == null)
            {
                frm_Menu NV = new frm_Menu();
                NV.Show();
            }
            else Application.OpenForms["frm_Menu"].Activate();
        }
        public void LoadData()
        {
            bll_BAN.BllLoadGrid();
        }
        public void LoadBan()
        {
            bll_BAN.BllLoadComboBAN();
        }
        private void frm_Ban_Load(object sender, EventArgs e)
        {
            LoadBan();
            LoadData();
        }
        private void cb_Ban_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tim == 0)
            {
                bll_BAN.BllLoadComboBAN();
            }
        }

        private void btn_ThemB_Click(object sender, EventArgs e)
        {
            bll_BAN.BllThem();
            LoadData();
        }

        private void btn_SuaB_Click(object sender, EventArgs e)
        {
            bll_BAN.BllSua();
            LoadData();
        }

        private void btn_XoaB_Click(object sender, EventArgs e)
        {
            bll_BAN.BllXoa();
            LoadData();
        }
        int tim = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_STT.Text = dataGridView1.CurrentRow.Cells["STT"].Value.ToString();
            txt_MaMonAn.Text = dataGridView1.CurrentRow.Cells["MaMon"].Value.ToString();
            txt_TenMonAn.Text = dataGridView1.CurrentRow.Cells["TenMon"].Value.ToString();
            txt_SoLuongMonAn.Text = dataGridView1.CurrentRow.Cells["SoLuongMon"].Value.ToString();
            txt_MaDoUong.Text = dataGridView1.CurrentRow.Cells["MaDoUong"].Value.ToString();
            txt_TenDoUong.Text = dataGridView1.CurrentRow.Cells["TenDoUong"].Value.ToString();
            txt_SoLuongDU.Text = dataGridView1.CurrentRow.Cells["SoLuongDU"].Value.ToString();
            txt_MaBan.Text = dataGridView1.CurrentRow.Cells["MaBan"].Value.ToString();
            tim = 1;
            cb_Ban.SelectedValue = dataGridView1.CurrentRow.Cells["MaBan"].Value.ToString();
            tim = 0;
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
