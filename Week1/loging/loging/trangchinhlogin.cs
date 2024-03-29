using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace loging
{
    public partial class trangchinhlogin : Form
    {
        public trangchinhlogin()
        {
            InitializeComponent();
        }

        private void btncancel_rightclick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.Cancel)
            {
                this.Close();
            }
        }

        private void btnlogin_rightclick(object sender, EventArgs e)
        {
            if(txtbusername.Text == "admin" && txtbpassword.Text == "123") 
            {
                if(MessageBox.Show("Logged in successfully !!!", "Error",MessageBoxButtons.OK) == System.Windows.Forms.DialogResult.OK)
                {
                this.Hide();
                Tinhtong2so Tt2s = new Tinhtong2so();
                Tt2s.ShowDialog();
                
                }
            }
            if(txtbusername.Text != "admin" && txtbpassword.Text == "123")
            {
                MessageBox.Show("wrong Name !!!", "Error");
            }
            if (txtbusername.Text == "admin" && txtbpassword.Text != "123")
            {
                MessageBox.Show("wrong Password !!!", "Error");
            }
            if (txtbusername.Text == "Enter your Name")
            {
                lblerroruser.Text = "Please ↓↓↓";
                lblerroruser.ForeColor = Color.Red;
                lblerroruser.Visible = true;
            }
            if (txtbpassword.Text == "Enter your password")
            {
                lblerrorpasswword.Text = "Please ↓↓↓";
                lblerrorpasswword.ForeColor = Color.Red;
                lblerrorpasswword.Visible = true;
            }
        }

        private void chkShowpassword_rightclick(object sender, EventArgs e)
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

        private void txtbpassword_Leave(object sender, EventArgs e)
        {
            if (txtbpassword.Text == "")
            {
                txtbpassword.Text = "Enter your password";
                txtbpassword.ForeColor = Color.Gray;
                txtbpassword.PasswordChar = (char)0;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
