using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NHAHANG
{
    public partial class frm_DangNhap : Form
    {
        LopDungChung lopchung;
        BLL.BllDANGNHAP bll_DN;
        public frm_DangNhap()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
            bll_DN = new BLL.BllDANGNHAP(this);
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            bll_DN.BllLogin();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_DangKy"] == null)
            {
                frm_DangKy NV = new frm_DangKy();
                NV.Show();
            }
            else Application.OpenForms["frm_DangKy"].Activate();
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
