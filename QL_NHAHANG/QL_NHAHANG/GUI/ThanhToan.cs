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
    public partial class frm_ThanhToan : Form
    {
        LopDungChung lopchung;
        BLL.BllTHANHTOAN bll_TT;
        public frm_ThanhToan()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
            bll_TT = new BLL.BllTHANHTOAN(this);
        }

        private void frm_ThanhToan_Load(object sender, EventArgs e)
        {
            LoadBan();
            LoadData();
        }
        public void LoadData()
        {
            bll_TT.BllLoadGrid();
        }
        public void LoadBan()
        {
            DataTable table = bll_TT.BllLoadCombo();
            HashSet<string> uniqueMaBan = new HashSet<string>();
            foreach (DataRow row in table.Rows)
            {
                uniqueMaBan.Add(row["MaBan"].ToString());
            }
            cb_Ban1.DataSource = uniqueMaBan.ToList();
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            string maBan = cb_Ban1.SelectedValue.ToString();
            DataTable tableMonDaGoi = bll_TT.BllbtnThanhToan();

            decimal tongTien = 0;
            int tongSoLuongMonAn = 0;
            int tongSoLuongDoUong = 0;

            foreach (DataRow row in tableMonDaGoi.Rows)
            {
                string maMon = row["MaMon"].ToString();
                string maDoUong = row["MaDoUong"].ToString();
                int soLuongMon = Convert.ToInt32(row["SoLuongMon"]);
                int soLuongDoUong = Convert.ToInt32(row["SoLuongDU"]);

                string sqlMonAn = "SELECT GiaMonAn FROM MONAN WHERE MaMon = '" + maMon + "'";
                DataTable tableMonAn = lopchung.LoadDuLieu(sqlMonAn);

                string sqlDoUong = "SELECT GiaDoUong FROM DOUONG WHERE MaDoUong = '" + maDoUong + "'";
                DataTable tableDoUong = lopchung.LoadDuLieu(sqlDoUong);

                decimal giaMon = Convert.ToDecimal(tableMonAn.Rows[0]["GiaMonAn"]);
                decimal giaDoUong = Convert.ToDecimal(tableDoUong.Rows[0]["GiaDoUong"]);
                tongTien += (giaMon * soLuongMon) + (giaDoUong * soLuongDoUong);
                tongSoLuongMonAn += soLuongMon;
                tongSoLuongDoUong += soLuongDoUong;
            }
            MessageBox.Show("Số lượng món ăn: " + tongSoLuongMonAn.ToString() + "\nSố lượng đồ uống: " + tongSoLuongDoUong.ToString() + "\nTổng tiền của bàn " + maBan + " là: " + tongTien.ToString());

        }

        private void cb_Ban1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bll_TT.BllComboTTBan();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cb_Ban1.SelectedValue = dataGridView1.CurrentRow.Cells["MaBan"].Value.ToString();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
