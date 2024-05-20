using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NHAHANG.DAL
{
    class DalDANGNHAP
    {
        LopDungChung lopchung;
        public DalDANGNHAP()
        {
            lopchung = new LopDungChung();
        }
        public int DalLogin(string TenDangNhap, string MatKhau)
        {
            string sqlDN = "select count (*) from TAIKHOAN where TenDangNhap = '" + TenDangNhap + "' and MatKhau='" + MatKhau + "'";
            int ketqua = (int)lopchung.Scalar(sqlDN);
            return ketqua;
        }
    }
}
