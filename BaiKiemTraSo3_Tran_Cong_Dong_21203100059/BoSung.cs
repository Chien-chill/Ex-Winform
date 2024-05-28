using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiKiemTraSo3_Tran_Cong_Dong_21203100059
{
    public partial class BoSung : Form
    {
        public BoSung()
        {
            InitializeComponent();
        }
        dbSQL_Bai3 db = new dbSQL_Bai3();
        public Bai3_SQL bai3 { get; set; }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtma.Text == "")
            {
                MessageBox.Show("Chưa nhập mã sinh viên");
            }
            else if (txtten.Text == "")
            {
                MessageBox.Show("Chưa nhập tên sinh viên");
            }
           else if (txtkhoa.Text == "")
            {
                MessageBox.Show("Chưa nhập khoa");
            }
           else if (txtquequan.Text == "")
            {
                MessageBox.Show("Chưa nhập quê quán");
            }
            else
            {
            string query = "Insert into sinhvien(masv,tensv,khoa,quequan) values" +
                    $"(N'{txtma.Text}',N'{txtten.Text}',N'{ txtkhoa.Text}',N'{ txtquequan.Text}')";
                db.ExcuteQuery(query);
                MessageBox.Show("Thêm thành công");
                TextBox[] txt = { txtma, txtkhoa, txtten, txtquequan };
                db.ResetTxt(txt);
                bai3.Bai3_SQL_Load(sender, e);  
            }    
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
