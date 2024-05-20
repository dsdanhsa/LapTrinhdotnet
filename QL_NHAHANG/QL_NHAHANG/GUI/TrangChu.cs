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
    public partial class frm_TrangChu : Form
    {
        public frm_TrangChu()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_NhanVien"] == null)
            {
                frm_NhanVien NV = new frm_NhanVien();
                NV.MdiParent = this;
                NV.Show();
            }
            else Application.OpenForms["frm_NhanVien"].Activate();
        }

        private void bànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_Ban"] == null)
            {
                frm_Ban BAN = new frm_Ban();
                BAN.MdiParent = this;
                BAN.Show();
            }
            else Application.OpenForms["frm_Ban"].Activate();
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_ThanhToan"] == null)
            {
                frm_ThanhToan TT = new frm_ThanhToan();
                TT.MdiParent = this;
                TT.Show();
            }
            else Application.OpenForms["frm_ThanhToan"].Activate();
        }
        
        private void CloseForm(string formName)
        {
            Form activeForm = this.ActiveMdiChild; // Lấy form con đang được mở
            if (activeForm != null)
            {
                activeForm.Close(); // Đóng form con đang được mở
            }
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseForm("frm_NhanVien");
            CloseForm("frm_Ban");
            CloseForm("frm_ThanhToan");
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_NhanVien"] == null)
            {
                frm_NhanVien NV = new frm_NhanVien();
                NV.MdiParent = this;
                NV.Show();
            }
            else Application.OpenForms["frm_NhanVien"].Activate();
        }

        private void bànToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_Ban"] == null)
            {
                frm_Ban BAN = new frm_Ban();
                BAN.MdiParent = this;
                BAN.Show();
            }
            else Application.OpenForms["frm_Ban"].Activate();
        }

        private void thanhToánToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_ThanhToan"] == null)
            {
                frm_ThanhToan TT = new frm_ThanhToan();
                TT.MdiParent = this;
                TT.Show();
            }
            else Application.OpenForms["frm_ThanhToan"].Activate();
        }

        private void frm_TrangChu_Load(object sender, EventArgs e)
        {
            this.ContextMenuStrip = contextMenuStrip1;
        }

        private void backToLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void thựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_Menu"] == null)
            {
                frm_Menu TT = new frm_Menu();
                TT.MdiParent = this;
                TT.Show();
            }
            else Application.OpenForms["frm_Menu"].Activate();
        }
    }
}
