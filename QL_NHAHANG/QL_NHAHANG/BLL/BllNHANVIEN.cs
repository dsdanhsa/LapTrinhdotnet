using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NHAHANG.BLL
{
    class BllNHANVIEN
    {
        DAL.DalNHANVIEN dal_NV;
        frm_NhanVien NV;
        public BllNHANVIEN(frm_NhanVien fNV)
        {
            dal_NV = new DAL.DalNHANVIEN();
            NV = fNV;
        }
        public void BllLoadGrid()
        {
            NV.dataGridView1.DataSource = dal_NV.DalLoadGrid();
        }
        public void BllLoadCombo()
        {
            NV.cb_CongViec.DataSource = dal_NV.DalLoadGrid();
            NV.cb_CongViec.DisplayMember = "TenCongViec";
            NV.cb_CongViec.ValueMember = "MaCongViec";
        }
        public void BllThem()
        {
            dal_NV.DalThem(NV.txt_MaNV.Text, NV.txt_HoTen.Text, NV.dateTimePicker1.Value, NV.cb_CongViec.SelectedValue.ToString(), NV.txt_HinhAnh.Text);
        }
        public void BllSua()
        {
            dal_NV.DalSua(NV.txt_HoTen.Text, NV.dateTimePicker1.Value, NV.cb_CongViec.SelectedValue.ToString(), NV.txt_HinhAnh.Text, NV.txt_MaNV.Text);
        }
        public void BllXoa()
        {
            dal_NV.DalXoa(NV.txt_MaNV.Text);
        }
        public void BllDem()
        {
            NV.txt_Dem.Text = dal_NV.DalDem().ToString();
        }
        public void BllTim()
        {
            NV.dataGridView1.DataSource = dal_NV.DalTim();
        }
        public void BllComboCongViec()
        {
            NV.dataGridView1.DataSource = dal_NV.DalComboCongViec(NV.txt_MaNV.Text);
        }
    }
}
