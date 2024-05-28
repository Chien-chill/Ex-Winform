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
    public partial class bai5 : Form
    {
        public bai5()
        {
            InitializeComponent();
        }
        string correct = "Bạn trả lời trúng phóc";
        string wrong = "Bạn trả lời sai bét";

        private void btnKQ_Click(object sender, EventArgs e)
        {
            lblKQ.Text = ((rb2014.Checked && Duc.Checked) || (rb2010.Checked && TayBaNha.Checked) || (rb2006.Checked && Italia.Checked) || (rb2002.Checked && Brazil.Checked) || (rb1998.Checked && Phap.Checked ))?correct:wrong;
        }
    }
}
