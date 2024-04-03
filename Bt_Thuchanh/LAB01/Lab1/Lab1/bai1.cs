using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class frmbai1 : Form
    {
        private Dictionary<string, string> tenmk;
        private int loginAttempts = 0;
        private const int maxLoginAttempts = 3;

    public frmbai1()
        {
            InitializeComponent();

            tenmk = new Dictionary<string, string>
            {
                { "admin", "123" },
                { "hoanggia", "1006" }
            };
        }

        private void btnlamlai_Click(object sender, EventArgs e)
        {
            txtso1.Clear();
            txtso2.Clear();
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
            if (txtso1.Text.Trim() == "0" || txtso1.Text.Trim() == "0")
            {
                txtchia.Text = "nhập số khác 0 !!!";
            }
            else
            {
                txtchia.Text = Chia.ToString();
            }

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
            btntim.Enabled = !string.IsNullOrEmpty(txtsoa.Text) && !string.IsNullOrEmpty(txtsob.Text);
            btntinhngay.Enabled = !string.IsNullOrEmpty(txtthang.Text) && !string.IsNullOrEmpty(txtnam.Text);
            btnlogin.Enabled = !String.IsNullOrEmpty(txtbpassword.Text) && !string.IsNullOrEmpty(txtbusername.Text);
            btntinh.Enabled = !string.IsNullOrEmpty(txtso1.Text) && !string.IsNullOrEmpty(txtso2.Text);
        }

        private void frmbai1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có thật sự muốn tắt không ???", "Ex1",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r != DialogResult.OK)
                e.Cancel = true;
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

        private void btnxoa_Click(object sender, EventArgs e)
        {
            txtsoa.Clear();
            txtsob.Clear();
            txtketqua.Clear();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            if(double.TryParse(txtsoa.Text, out double v1) && double.TryParse(txtsob.Text, out double v2))
            {
                double kq = -v2 / v1;
                if (v1 == 0 && v2 != 0) txtketqua.Text = "Phương trình vô nghiệm";
                else txtketqua.Text = "Phương trình có nghiệm là: " + kq.ToString();
            }
            else
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ!");
            }
        }

        private void txtsoa_TextChanged(object sender, EventArgs e)
        {
            kiemtraso();
        }

        private void txtsob_TextChanged(object sender, EventArgs e)
        {
            kiemtraso();
        }

        private void btnxoa31_Click(object sender, EventArgs e)
        {
            txtngay.Clear();
            txtthang.Clear();
            txtnam.Clear();
        }

        private void btntinhngay_Click(object sender, EventArgs e)
        {
            int thang = Int32.Parse(txtthang.Text);
            int nam = Int32.Parse(txtnam.Text);
            if (thang < 1 || thang > 12)
            {
                MessageBox.Show("Vui lòng nhập tháng từ 1 đến 12!");
                return;
            }
            label13.Text = "Số ngày của tháng " + thang + " năm " + nam + " là:";
            txtngay.Text = DateTime.DaysInMonth(nam,thang).ToString();
        }

        private void txtthang_TextChanged(object sender, EventArgs e)
        {
            kiemtraso();
        }

        private void txtnam_TextChanged(object sender, EventArgs e)
        {
            kiemtraso();
        }

        private void txtsoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtsob_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtthang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtnam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string ten = txtbusername.Text;
            string mk = txtbpassword.Text;

            if (!tenmk.ContainsKey(ten))
            {
                MessageBox.Show("Tên đăng nhập không tồn tại!");
                return;
            }

            if (tenmk[ten] != mk)
            {
                loginAttempts++;
                if (loginAttempts >= maxLoginAttempts)
                {
                    MessageBox.Show("Bạn đã nhập sai quá 3 lần. Ứng dụng sẽ thoát.");
                    Application.Exit();
                }
                MessageBox.Show("Sai mật khẩu! Vui lòng thử lại.");
                return;
            }

            MessageBox.Show("Bạn đã đăng nhập thành công!");
            loginAttempts = 0;
        }

        private void chkShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (txtbpassword.Text == "Enter your password")
            {
                return;
            }
            if (chkShowpassword.Checked)
            {
                txtbpassword.PasswordChar = (char)0;
            }
            else
            {
                txtbpassword.PasswordChar = '*';
            }
        }

        private void txtbusername_Leave(object sender, EventArgs e)
        {
            if (txtbusername.Text == "")
            {
                txtbusername.Text = "Enter your Name";
                txtbusername.ForeColor = Color.Gray;
            }
        }

        private void txtbusername_Enter(object sender, EventArgs e)
        {
            if (txtbusername.Text == "Enter your Name")
            {
                txtbusername.Text = "";
                txtbusername.ForeColor = Color.Black;
                lblerroruser.Visible = false;
            }
        }

        private void txtbpassword_Leave(object sender, EventArgs e)
        {
            if (txtbpassword.Text == "")
            {
                txtbpassword.Text = "Enter your password";
                txtbpassword.ForeColor = Color.Gray;
                txtbpassword.PasswordChar = (char)0;
            }
        }

        private void txtbpassword_Enter(object sender, EventArgs e)
        {
            if (txtbpassword.Text == "Enter your password")
            {
                txtbpassword.Text = "";
                txtbpassword.ForeColor = Color.Black;
                txtbpassword.PasswordChar = '*';
                lblerrorpasswword.Visible = false;
            }
        }

        private void txtbusername_TextChanged(object sender, EventArgs e)
        {
            kiemtraso();
        }

        private void txtbpassword_TextChanged(object sender, EventArgs e)
        {
            kiemtraso();
        }

        private void txtbpassword_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtbusername_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
