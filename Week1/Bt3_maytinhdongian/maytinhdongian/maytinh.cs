using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maytinhdongian
{
    public partial class frmmaytinh : Form
    {
        public frmmaytinh()
        {
            InitializeComponent();
        }
        double Tongtong;
        private void btntinh_Click(object sender, EventArgs e)
        {
            try
            {
                txttong.Text = Tongtong.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtso1_TextChanged(object sender, EventArgs e)
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

        private void txtso2_TextChanged(object sender, EventArgs e)
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
        private void kiemtraso()
        {
            rbtcong.Enabled = !string.IsNullOrEmpty(txtso1.Text) && !string.IsNullOrEmpty(txtso2.Text);
            rbttru.Enabled = !string.IsNullOrEmpty(txtso1.Text) && !string.IsNullOrEmpty(txtso2.Text);
            rbtnhan.Enabled = !string.IsNullOrEmpty(txtso1.Text) && !string.IsNullOrEmpty(txtso2.Text);
            rbtchia.Enabled = !string.IsNullOrEmpty(txtso1.Text) && !string.IsNullOrEmpty(txtso2.Text) && !(txtso1.Text.Contains("0") || txtso2.Text.Contains("0"));
        }

        private void rbtcong_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                double Tong = Int32.Parse(txtso1.Text) + Int32.Parse(txtso2.Text);
                Tongtong = Tong;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbttru_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int Tong = Int32.Parse(txtso1.Text) - Int32.Parse(txtso2.Text);
                Tongtong = Tong;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbtnhan_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int Tong = Int32.Parse(txtso1.Text) * Int32.Parse(txtso2.Text);
                Tongtong = Tong;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbtchia_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                double Tong = double.Parse(txtso1.Text) / double.Parse(txtso2.Text);
                Tongtong = Tong;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private int UocChungLonNhat(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private int BoiChungNhoNhat(int a, int b)
        {
            return a * b / UocChungLonNhat(a, b);
        }
    }
}
