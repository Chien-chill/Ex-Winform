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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void ShowForm(Form f)
        {
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void btnCau1_Click(object sender, EventArgs e)
        {
            bai1 bai1 = new bai1();
            ShowForm(bai1);
        }

        private void btnCau2_Click(object sender, EventArgs e)
        {
            bai2 bai2 = new bai2();
            ShowForm(bai2);
        }

        private void btnCau3_Click(object sender, EventArgs e)
        {
            bai3 bai3 = new bai3();
            ShowForm(bai3);
        }

        private void btnCau33_Click(object sender, EventArgs e)
        {
            Bai3_SQL bai3 = new Bai3_SQL();
            ShowForm(bai3);
        }

        private void btnCau4_Click(object sender, EventArgs e)
        {
            bai4 bai4 = new bai4();
            ShowForm(bai4);
        }

        private void btnCau5_Click(object sender, EventArgs e)
        {
            bai5 bai5 = new bai5();
            ShowForm(bai5);
        }
    }
}
