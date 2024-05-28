using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BaiKiemTraSo3_Tran_Cong_Dong_21203100059
{
    public partial class Bai3_SQL : Form
    {
        public Bai3_SQL()
        {
            InitializeComponent();
        }
            dbSQL_Bai3 db = new dbSQL_Bai3();
        
        public void Bai3_SQL_Load(object sender, EventArgs e)
        {
            string query = "Select * from sinhvien";
            dtgSV.DataSource =  db.readData(query);
        }

        private void btnBoSung_Click(object sender, EventArgs e)
        {
            BoSung bs  = new BoSung();
            bs.bai3 = this;
            bs.ShowDialog();

        }
        int nurrow;
       public string Ma="", Ten="",Khoa = "", Que = "";

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(Ma == "")
            {
                MessageBox.Show("Chưa chọn dòng để cập nhật");
            }
            else
            {
            CapNhat cn = new CapNhat();
                cn.bai3 = this;
                cn.ShowDialog();
            }    
        }

        private void dtgSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nurrow = e.RowIndex;
            if (nurrow >= 0)
            {
               Ma = dtgSV.Rows[nurrow].Cells[0].Value.ToString();
               Ten = dtgSV.Rows[nurrow].Cells[1].Value.ToString();
                Khoa = dtgSV.Rows[nurrow].Cells[2].Value.ToString();
                Que = dtgSV.Rows[nurrow].Cells[3].Value.ToString();
            }
        }
    }
}
