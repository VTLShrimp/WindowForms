using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CongTruNhanChia
{
    public partial class frmCongTruNhanChia : Form
    {
        public frmCongTruNhanChia()
        {
            InitializeComponent();
        }

        private void txtSohang1_changed(object sender, EventArgs e)
        {
            kiemtraso();
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
            {
                this.ErrorProvider.SetError(ctr, "Vui lòng nhập số !!!");
            }
            else
            {
                this.ErrorProvider.Clear();
            }
        }

        private void txtSohang2_changed(object sender, EventArgs e)
        {
            kiemtraso();
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
                this.ErrorProvider.SetError(ctr, "Vui lòng nhập số !!!");
            else
                this.ErrorProvider.Clear();
        }

        private void kiemtraso()
        {
            btnCong.Enabled = !string.IsNullOrEmpty(txtSohang1.Text) && !string.IsNullOrEmpty(txtSohang2.Text);
            btnTru.Enabled = !string.IsNullOrEmpty(txtSohang1.Text) && !string.IsNullOrEmpty(txtSohang2.Text);
            btnNhan.Enabled = !string.IsNullOrEmpty(txtSohang1.Text) && !string.IsNullOrEmpty(txtSohang2.Text);
            btnChia.Enabled = !string.IsNullOrEmpty(txtSohang1.Text) && !string.IsNullOrEmpty(txtSohang2.Text) && !(txtSohang1.Text.Contains("0") || txtSohang2.Text.Contains("0"));
        }

        private void btnCong_click(object sender, EventArgs e)
        {
            try
            {
                int Tong = Int32.Parse(txtSohang1.Text) + Int32.Parse(txtSohang2.Text);
                txtTong.Text =   Tong.ToString();
            }catch (Exception ex)
            { 
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTru_click(object sender, EventArgs e)
        {
            try
            {
                int Tong = Int32.Parse(txtSohang1.Text) - Int32.Parse(txtSohang2.Text);
                txtTong.Text = Tong.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNhan_click(object sender, EventArgs e)
        {
            try
            {
                int Tong = Int32.Parse(txtSohang1.Text) * Int32.Parse(txtSohang2.Text);
                txtTong.Text = Tong.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChia_click(object sender, EventArgs e)
        {
            try
            {
                double Tong = double.Parse(txtSohang1.Text) / double.Parse(txtSohang2.Text);
                txtTong.Text = Tong.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
 