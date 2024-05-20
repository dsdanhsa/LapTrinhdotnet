using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NHAHANG.BLL
{
    class BllMENU
    {
        DAL.DalMENU dal_MN;
        frm_Menu MN;
        public BllMENU(frm_Menu fMN)
        {
            dal_MN = new DAL.DalMENU();
            MN = fMN;
        }
        public void BllLoadGrid()
        {
            MN.dataGridView1.DataSource = dal_MN.DalLoadGrid();
        }
        public void BllLoadCombo()
        {
            MN.cb_Loai.DataSource = dal_MN.DalLoadGrid();
            MN.cb_Loai.DisplayMember = "TenLoai";
            MN.cb_Loai.ValueMember = "MaLoai";
        }
        public void BllComboLoai()
        {
            MN.dataGridView1.DataSource = dal_MN.DalComboLoai(MN.cb_Loai.SelectedValue.ToString());
        }
    }
}
