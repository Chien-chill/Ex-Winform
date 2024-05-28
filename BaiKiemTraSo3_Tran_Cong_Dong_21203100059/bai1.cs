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
    public partial class bai1 : Form
    {
        public bai1()
        {
            InitializeComponent();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double c = double.Parse(txtC.Text);
            double d = double.Parse(txtD.Text);
            double m = double.Parse(txtM.Text);
            double n = double.Parse(txtN.Text);
            double D = (a*d) - (c*b);
            double Dx = (m*d) - (n*b);
            double Dy = (a * n) - (c * m);
            lblKQ.Text = (D == 0) ? ((Dx + Dy == 0) ? "Hệ phương trình có vô số nghiệm" : "Hệ phương trình vô nghiệm)") : $"x = {Dx / D}, y= {Dy / D} .";
        }
    }
}
