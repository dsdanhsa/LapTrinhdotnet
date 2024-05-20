using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NHAHANG.DAL
{
    class DalNHANVIEN
    {
        LopDungChung lopchung;
        public DalNHANVIEN()
        {
            lopchung = new LopDungChung();
        }
        public DataTable DalLoadGrid()
        {
            string sqlLoadGrid = "select * from NHANVIEN"; 
            return lopchung.LoadDuLieu(sqlLoadGrid);
        }
        public DataTable DalLoadComboCV()
        {
            string sqlLoadCombo = "select * from PHANCONG"; ;
            return lopchung.LoadDuLieu(sqlLoadCombo);
        }
        public void DalThem(string MaNV, string HoTen, DateTime NgayVaoLam, string MaCongViec, string TenHinh)
        {
            string sqlThem = "insert into NHANVIEN values('" + MaNV + "', N'" + HoTen + "', Convert(DateTime, '" + NgayVaoLam + "',103),'" + MaCongViec + "','" + TenHinh + "')";
            lopchung.NonQuery(sqlThem);
        }
        public void DalSua(string HoTen, DateTime NgayVaoLam, string MaCongViec, string TenHinh, string MaNV)
        {
            string sqlSua = "update NHANVIEN set HoTen = N'" + HoTen + "', NgayVaoLam = Convert(DateTime,'" + NgayVaoLam + "',103), MaCongViec = '" + MaCongViec + "', TenHinh ='" + TenHinh + "' where MaNV = '" + MaNV + "' ";
            lopchung.NonQuery(sqlSua);
        }
        public void DalXoa(string MaNV)
        {
            string sqlXoa = "delete NHANVIEN where MaNV = '" + MaNV + "' ";
            lopchung.NonQuery(sqlXoa);
        }


        public int DalDem()
        {
            string sqlDem = "select count(*) from NHANVIEN";
            int ketqua = (int)lopchung.Scalar(sqlDem);
            return ketqua;
        }
        public DataTable DalTim()
        {
            string nhap = Interaction.InputBox("Nhập vào tên hoặc mã");
            string sqlTim = "select * from NHANVIEN where MaNV like '%" + nhap + "%' or HoTen like '%" + nhap + "%' ";
            return lopchung.LoadDuLieu(sqlTim);
        }
        public DataTable DalComboCongViec(string MaCongViec)
        {
            string sqlPhanCong = "select * from NHANVIEN where MaCongViec = '" + MaCongViec + "' ";
            return lopchung.LoadDuLieu(sqlPhanCong);
        }
    }
}
