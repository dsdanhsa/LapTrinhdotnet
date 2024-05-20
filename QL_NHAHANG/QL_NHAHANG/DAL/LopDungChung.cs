using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QL_NHAHANG
{
    class LopDungChung
    {
        string ketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\QLNH.mdf;Integrated Security=True";
        SqlConnection conn;
        public LopDungChung()
        {
            conn = new SqlConnection(ketnoi);
        }
        public DataTable LoadDuLieu(string sqlLoad)
        {
            SqlDataAdapter da = new SqlDataAdapter(sqlLoad,conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void NonQuery(string sqlNon)
        {
            SqlCommand comm = new SqlCommand(sqlNon,conn);
            conn.Open();
            int ketqua = comm.ExecuteNonQuery();
            conn.Close();
            if (ketqua >= 1)
                MessageBox.Show("Thành Công");
            else
                MessageBox.Show("Thất Bại");
        }
        public object Scalar(string sqlScalar)
        {
            SqlCommand comm = new SqlCommand(sqlScalar,conn);
            conn.Open();
            int ketqua = (int)comm.ExecuteScalar();
            conn.Close();
            return ketqua;
        }
    }
}
