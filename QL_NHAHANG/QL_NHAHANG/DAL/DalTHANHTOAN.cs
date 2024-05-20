using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NHAHANG.DAL
{
    class DalTHANHTOAN
    {
        LopDungChung lopchung;
        public DalTHANHTOAN()
        {
            lopchung = new LopDungChung();
        }
        public DataTable DalLoadGrid()
        {
            string sqlLoadGrid = "select * from BAN";
            return lopchung.LoadDuLieu(sqlLoadGrid);
        }
        public DataTable DalLoadComboTT()
        {
            string sqlLoadCombo = "select MaBan from BAN";
            return lopchung.LoadDuLieu(sqlLoadCombo);
        }
        public DataTable DalbtnThanhToan(string maBan)
        {
            string sqlMonDaGoi = "SELECT MaMon, MaDoUong, SoLuongMon, SoLuongDU FROM BAN WHERE MaBan = '" + maBan + "'";
            return lopchung.LoadDuLieu(sqlMonDaGoi);
        }
        public DataTable DalComboTTBan(string MaBan)
        {
            string sqlBan = "select * from BAN where MaBan = '" + MaBan + "' ";
            return lopchung.LoadDuLieu(sqlBan);
        }
    }
}
