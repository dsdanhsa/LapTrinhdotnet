using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NHAHANG.DAL
{
    class DalDANGKY
    {
        LopDungChung lopchung;
        public DalDANGKY()
        {
            lopchung = new LopDungChung();
        }
        public DataTable DalLoadGrid()
        {
            string sqlLoadGrid = "select * from TAIKHOAN";
            return lopchung.LoadDuLieu(sqlLoadGrid);
        }
        public void DalBtnDangKy(string TenDangNhap, string MatKhauDangKy, string XnMatKhau, string Email, string DiaChi, string TenDangKy)
        {
            string sqlDangKy = "insert into TAIKHOAN values('" + TenDangNhap + "', '" + MatKhauDangKy + "', '" +
                XnMatKhau + "', '" + Email + "', N'" + DiaChi + "', N'" + TenDangKy + "')";
            lopchung.LoadDuLieu(sqlDangKy);
        }
        public void DalBtnXoa(string TenDangNhap)
        {
            string sqlXoa = "delete from TAIKHOAN where TenDangNhap = '" + TenDangNhap + "'";
            lopchung.LoadDuLieu(sqlXoa);
        }
        public void DalBtnSua(string MatKhauDangKy, string XnMatKhau, string Email, string DiaChi, string TenDangKy, string TenDangNhap)
        {
            string sqlSua = "update TAIKHOAN set MatKhau = '" + MatKhauDangKy + "', XacNhanMatKhau = '" +
               XnMatKhau + "', Email = '" + Email + "', DiaChi = N'" + DiaChi + "', TenDangKy = N'" +
               TenDangKy + "' where TenDangNhap = '" + TenDangNhap + "' ";
            lopchung.LoadDuLieu(sqlSua);
        }
    }
}
