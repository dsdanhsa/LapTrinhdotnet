using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NHAHANG.DAL
{
    class DalBAN
    {
        LopDungChung lopchung;
        public DalBAN()
        {
            lopchung = new LopDungChung();
        }
        public DataTable DalLoadGrid()
        {
            string sqlLoadGrid = "select * from BAN";
            return lopchung.LoadDuLieu(sqlLoadGrid);
        }
        public DataTable DalLoadComboBAN()
        {
            string sqlLoadCombo = "select DISTINCT* from BAN";
            return lopchung.LoadDuLieu(sqlLoadCombo);
        }
        public DataTable DalComboBAN(string MaBan)
        {
            string sqlPhanCong ="select * from BAN where MaBan = '" + MaBan + "' ";
            return lopchung.LoadDuLieu(sqlPhanCong);
        }
        public void DalThem(string STT, string MaMon, string TenMon, string SoLuongMon, string MaDoUong, string TenDoUong, string SoLuongDU, string MaBan)
        {
            string sqlThem = "insert into BAN values('" + STT + "','" + MaMon + "', N'" + TenMon + "','" + SoLuongMon + "','" + MaDoUong + "', N'" + TenDoUong + "','" + SoLuongDU + "','" + MaBan + "')";
            lopchung.NonQuery(sqlThem);
        }
        public void DalSua(string MaMon, string TenMon, string SoLuongMon, string MaDoUong, string TenDoUong, string SoLuongDU, string MaBan, string STT)
        {
            string sqlSua = "update BAN set MaMon = '" + MaMon + "', TenMon = N'" + TenMon + "', SoLuongMon ='" + SoLuongMon + "', MaDoUong = '" + MaDoUong + "', TenDoUong = N'" + TenDoUong + "', SoLuongDU = '" + SoLuongDU + "',MaBan = '" + MaBan + "' where STT = '" + STT + "' ";
            lopchung.NonQuery(sqlSua);
        }
        public void DalXoa(string MaBan)
        {
            string sqlXoa = "delete BAN where MaBan = '" + MaBan + "' ";
            lopchung.NonQuery(sqlXoa);
        }
    }
}
