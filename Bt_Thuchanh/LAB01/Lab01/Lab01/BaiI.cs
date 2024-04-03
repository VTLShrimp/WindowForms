using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class frmbaiI : Form
    {
        public frmbaiI()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmbaiI_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có thật sự muốn thoát không ???", "Ex1",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r != DialogResult.OK)
                e.Cancel = true;
        }
        private void kiemtraso()
        {
            btntinh.Enabled = !string.IsNullOrEmpty(txtso1.Text) && !string.IsNullOrEmpty(txtso2.Text);
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            double Cong = double.Parse(txtso1.Text) + double.Parse(txtso2.Text);
            txtcong.Text = Cong.ToString();
            double Hieu = double.Parse(txtso1.Text) - double.Parse(txtso2.Text);
            txthieu.Text = Hieu.ToString();
            double Nhan = double.Parse(txtso1.Text) * double.Parse(txtso2.Text);
            txtnhan.Text = Nhan.ToString();
            double Chia = double.Parse(txtso1.Text) / double.Parse(txtso2.Text);
            txtchia.Text = Chia.ToString();
        }

        private void btnlamlai_Click(object sender, EventArgs e)
        {

        }

        private void txtso1_TextChanged(object sender, EventArgs e)
        {
            kiemtraso();
        }

        private void txtso2_TextChanged(object sender, EventArgs e)
        {
            kiemtraso();
        }
    }
}
