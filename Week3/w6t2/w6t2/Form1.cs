
using System;
using System.Windows.Forms;
namespace w6t2
{
    public partial class Form1 : Form
    {
        public event EventHandler LoginSuccess;
        public event EventHandler LoginFail;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.");
                return;
            }

            // Xử lý mã cứng user name và password
            if (txtUsername.Text == "admin" && txtPassword.Text == "password")
            {
                LoginSuccess?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                LoginFail?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}