using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NHAHANG.DAL
{
    class DalMENU
    {
        LopDungChung lopchung;

        public DalMENU()
        {
            lopchung = new LopDungChung();
        }
        public DataTable DalLoadGrid()
        {
            string sqlData = "SELECT TenMon AS Ten, MaLoai, GiaMonAn FROM MONAN " +
                     "UNION ALL " +
                     "SELECT TenDoUong AS Ten, MaLoai, GiaDoUong FROM DOUONG";
            return lopchung.LoadDuLieu(sqlData);
        }
        public DataTable DalLoadComboCV()
        {
            string sqlCombo = "select * from LOAITHUCPHAM";
            return lopchung.LoadDuLieu(sqlCombo);
        }
        public DataTable DalComboLoai(string MaLoai)
        {
            string sqlLoai = "SELECT DISTINCT MaLoai, TenMon AS Ten, GiaMonAn FROM MONAN WHERE MaLoai = '" + MaLoai + "' " +
                 "UNION ALL " +
                 "SELECT DISTINCT MaLoai, TenDoUong AS Ten, GiaDoUong FROM DOUONG WHERE MaLoai = '" + MaLoai + "'";
            return lopchung.LoadDuLieu(sqlLoai);
        }
    }
}
