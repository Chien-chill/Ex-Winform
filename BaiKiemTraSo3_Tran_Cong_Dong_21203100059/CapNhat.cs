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
    public partial class CapNhat : Form
    {
        public CapNhat()
        {
            InitializeComponent();
        }
        dbSQL_Bai3 db = new dbSQL_Bai3();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtma.Text == "")
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
                string query = $"Update sinhvien set masv = N'{txtma.Text}' , tensv = N'{txtten.Text}' , khoa = N'{txtkhoa.Text}' , quequan = N'{txtquequan.Text}' where masv = N'{bai3.Ma}'";
                db.ExcuteQuery(query);
                MessageBox.Show("Lưu thành công");
                TextBox[] txt = { txtma, txtkhoa, txtten, txtquequan };
                db.ResetTxt(txt);
                bai3.Bai3_SQL_Load(sender, e);
            }
        }
        public Bai3_SQL bai3 { get; set; }
        private void CapNhat_Load(object sender, EventArgs e)
        {
            txtma.Text = bai3.Ma;
            txtten.Text = bai3.Ten;
            txtkhoa.Text = bai3.Khoa;
            txtquequan.Text = bai3.Que;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
