using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bt6_doitien
{
    public partial class frmdoitien : Form
    {
        public frmdoitien()
        {
            InitializeComponent();
        }
        double USD = 24810;
        double eur = 26777;
        double sotien;
        private void btnvn_us_Click(object sender, EventArgs e)
        {
            sotien = double.Parse(txtsodoi.Text);
            double ketqua = sotien / USD;
            txtketqua.Text = ketqua.ToString("N2") + " USD";
        }

        private void btnvn_eu_Click(object sender, EventArgs e)
        {
            sotien = double.Parse(txtsodoi.Text);
            double ketqua = sotien / eur;
            txtketqua.Text = ketqua.ToString("N2") + " eur";
        }

        private void btnus_vn_Click(object sender, EventArgs e)
        {
            sotien = double.Parse(txtsodoi.Text);
            double ketqua = sotien * USD;
            txtketqua.Text = ketqua.ToString("N2") + " vnd";
        }

        private void btneu_vn_Click(object sender, EventArgs e)
        {
            sotien = double.Parse(txtsodoi.Text);
            double ketqua = eur * sotien;
            txtketqua.Text = ketqua.ToString("N2") + " vnd";
        }

        private void txtsodoi_TextChanged(object sender, EventArgs e)
        {
            kiemtra();
        }
        private void kiemtra()
        {
            btnvn_us.Enabled = !string.IsNullOrEmpty(txtsodoi.Text);
            btnvn_eu.Enabled = !string.IsNullOrEmpty(txtsodoi.Text);
            btneu_vn.Enabled = !string.IsNullOrEmpty(txtsodoi.Text);
            btnus_vn.Enabled = !string.IsNullOrEmpty(txtsodoi.Text);
        }

        private void txtsodoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
