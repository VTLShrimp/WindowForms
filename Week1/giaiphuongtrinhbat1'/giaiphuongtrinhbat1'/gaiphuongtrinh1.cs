using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giaiphuongtrinhbat1_
{
    public partial class frmgaiphuongtrinh1 : Form
    {
        public frmgaiphuongtrinh1()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtso1.Text);
            double b = Convert.ToDouble(txtso2.Text);
            if (a == 0)
            {
                MessageBox.Show("Đây không phải là phương trình bậc nhất!");
                return;
            }
            double nghiem = -b / a;
            txtnghiem.Text = "X = " + nghiem.ToString();
        }

        private void txtso1_TextChanged(object sender, EventArgs e)
        {
            kiemtraso();
        }

        private void txtso2_TextChanged(object sender, EventArgs e)
        {
            kiemtraso();
        }
        private void kiemtraso()
        {
            btntinh.Enabled = !string.IsNullOrEmpty(txtso1.Text) && !string.IsNullOrEmpty(txtso2.Text);
        }

        private void txtso1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtso2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
