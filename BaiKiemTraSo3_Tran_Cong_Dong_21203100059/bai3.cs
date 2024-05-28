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
    public partial class bai3 : Form
    {
        public bai3()
        {
            InitializeComponent();
        }

        private void btnTinhToan_Click(object sender, EventArgs e)
        {
            double x1 = double.Parse(txtX1.Text);
            double x2 = double.Parse(txtX2.Text);
            double y1 = double.Parse(txtY1.Text);
            double y2 = double.Parse(txtY2.Text);
            lblHSG.Text  =((double)((y2-y1)  / (x2 - x1))).ToString();
            double v1 = Math.Pow(x2- x1, 2);
            double v2 = Math.Pow(y2 - y1, 2);
            lblKC.Text = ((double)(Math.Sqrt(v1 + v2))).ToString();
        }
    }
}
