using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiKiemTraSo3_Tran_Cong_Dong_21203100059
{
    internal class dbSQL_Bai3
    {
        SqlConnection conn = new SqlConnection(@"Data Source=MENEISKYE\MENEISKY;Initial Catalog=qlsv;Integrated Security=True;");
        public DataTable readData(string query)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(query,conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public void ExcuteQuery(string query)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(query,conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void ResetTxt(TextBox[] txt)
        {
            foreach (TextBox b in txt)
            {
                b.Clear();
            }
        }
    }
}
