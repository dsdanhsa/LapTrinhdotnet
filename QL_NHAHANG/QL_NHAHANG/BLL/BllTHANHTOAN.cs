using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NHAHANG.BLL
{
    class BllTHANHTOAN
    {
        DAL.DalTHANHTOAN dal_TT;
        frm_ThanhToan TT;
        public BllTHANHTOAN(frm_ThanhToan fTT)
        {
            dal_TT = new DAL.DalTHANHTOAN();
            TT = fTT;
        }
        public void BllLoadGrid()
        {
            TT.dataGridView1.DataSource = dal_TT.DalLoadGrid();
        }
        public DataTable BllLoadCombo()
        {
            return dal_TT.DalLoadComboTT();
        }
        public DataTable BllbtnThanhToan()
        {
            return dal_TT.DalbtnThanhToan(TT.cb_Ban1.SelectedValue.ToString());
        }
        public void BllComboTTBan()
        {
            TT.dataGridView1.DataSource = dal_TT.DalComboTTBan(TT.cb_Ban1.SelectedValue.ToString());
        }
    }
}
