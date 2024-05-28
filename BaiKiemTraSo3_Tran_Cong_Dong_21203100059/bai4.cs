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
    public partial class bai4 : Form
    {
        public bai4()
        {
            InitializeComponent();
        }

        private void cbToanTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtA.Text == "" || txtB.Text =="")
            {
                MessageBox.Show("Chưa nhập đủ 2 hệ số");
                cbToanTu.SelectedIndex = -1;
            }
            else
            {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            txtKQ.Text = (cbToanTu.Text == "+") ? $"{a + b}" : ((cbToanTu.Text == "-") ? $"{a - b}" : ((cbToanTu.Text == "*") ? $"{a * b}" :$"{(double)a/b}"));
            }
        }

        private void bai4_Load(object sender, EventArgs e)
        {
        }
    }
}
