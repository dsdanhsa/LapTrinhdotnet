using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NHAHANG.BLL
{
    class BllDANGKY
    {
        DAL.DalDANGKY dal_DK;
        frm_DangKy DK;
        public BllDANGKY(frm_DangKy fDK)
        {
            dal_DK = new DAL.DalDANGKY();
            DK = fDK;
        }
        public void BllLoadGrid()
        {
            DK.dataGridView1.DataSource = dal_DK.DalLoadGrid();
        }
        public void BllBtnDangKy()
        {
            dal_DK.DalBtnDangKy(DK.txt_TenDangNhap.Text, DK.txt_MatKhauDangKy.Text, DK.txt_xnMatKhau.Text, DK.txt_Email.Text, DK.txt_DiaChi.Text, DK.txt_TenDangKy.Text );
        }
        public void BllBtnXoa()
        {
            dal_DK.DalBtnXoa(DK.txt_TenDangNhap.Text);
        }
        public void BllBtnSua()
        {
            dal_DK.DalBtnSua(DK.txt_MatKhauDangKy.Text, DK.txt_xnMatKhau.Text, DK.txt_Email.Text, DK.txt_DiaChi.Text, DK.txt_TenDangKy.Text, DK.txt_TenDangNhap.Text);
        }
    }
}
