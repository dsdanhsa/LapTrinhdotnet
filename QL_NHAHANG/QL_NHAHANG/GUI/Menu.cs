using Microsoft.VisualBasic;
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

namespace QL_NHAHANG
{
    public partial class frm_Menu : Form
    {
        LopDungChung lopchung;
        BLL.BllMENU bll_MN;
        public frm_Menu()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
            bll_MN = new BLL.BllMENU(this);
        }

        private void frm_Menu_Load(object sender, EventArgs e)
        {
            LoadLoai();
            LoadData();
        }

        public void LoadLoai()
        {
            bll_MN.BllLoadCombo();
        }
        public void LoadData()
        {
            bll_MN.BllLoadGrid();
        }

        private void btn_ExitM_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_Loai_SelectedIndexChanged(object sender, EventArgs e)
        {
            bll_MN.BllComboLoai();
        }

        private void btn_LoadGrip_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
