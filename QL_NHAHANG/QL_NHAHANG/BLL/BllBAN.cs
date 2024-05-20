using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NHAHANG.BLL
{
    class BllBAN
    {
        DAL.DalBAN dal_BAN;
        frm_Ban BAN;
        public BllBAN(frm_Ban fBAN)
        {
            dal_BAN = new DAL.DalBAN();
            BAN = fBAN;
        }
        public void BllLoadGrid()
        {
            BAN.dataGridView1.DataSource = dal_BAN.DalLoadGrid();
        }
        public void BllLoadComboBAN()
        {
            BAN.cb_Ban.DataSource = dal_BAN.DalLoadGrid();
            BAN.cb_Ban.DisplayMember = "MaBan";
            BAN.cb_Ban.ValueMember = "MaBan";
        }
        public void BllComboBAN()
        {
            BAN.dataGridView1.DataSource = dal_BAN.DalComboBAN(BAN.cb_Ban.SelectedValue.ToString());
        }
        public void BllThem()
        {
            dal_BAN.DalThem(BAN.txt_STT.Text, BAN.txt_MaMonAn.Text, BAN.txt_TenMonAn.Text, BAN.txt_SoLuongMonAn.Text, BAN.txt_MaDoUong.Text, BAN.txt_TenDoUong.Text, BAN.txt_SoLuongDU.Text, BAN.txt_MaBan.Text);
        }
        public void BllSua()
        {
            dal_BAN.DalSua(BAN.txt_MaMonAn.Text, BAN.txt_TenMonAn.Text, BAN.txt_SoLuongMonAn.Text, BAN.txt_MaDoUong.Text, BAN.txt_TenDoUong.Text, BAN.txt_SoLuongDU.Text, BAN.txt_MaBan.Text, BAN.txt_STT.Text);
        }
        public void BllXoa()
        {
            dal_BAN.DalXoa(BAN.txt_MaBan.Text);
        }
    }
}
