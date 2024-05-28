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
    public partial class bai2 : Form
    {
        public bai2()
        {
            InitializeComponent();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            lblKQ.Text = (a == 0 && b == 0) ? "Phương trình vô số nghiệm" : ((a == 0 && b != 0) ? "Phương trình vô nghiệm" : $"x= {(double)-b / a}");
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtA.Focus();
        }
    }
}
