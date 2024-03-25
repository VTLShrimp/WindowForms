using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{

    public partial class Login : Form
    {    
        
        public Login()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UserText.Text == "Enter your name")
            {
                MessageBox.Show("Chua nhap tai khoan", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (PassWordTextBox.Text == "Enter your password")
            {
                MessageBox.Show("Chua nhap mat khau", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=LAMLMAO;Initial Catalog=User_Management;Integrated Security=True;");
                    con.Open();
                    string UserName = UserText.Text;
                    string Password = PassWordTextBox.Text;
                    string sql = "select * from User_Info where UserName = '" + UserName + "' and UserPassword = '" + Password + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        reader.Close();
                        string UserType = "select * from User_Info where UserName = '" + UserName + "' and UserType = 'admin'";
                        SqlCommand cmd2 = new SqlCommand(UserType, con);
                        SqlDataReader CheckAdmin = cmd2.ExecuteReader();
                        if (CheckAdmin.Read() == true)
                        {
                            MessageBox.Show("Dang nhap admin thanh cong", "Thong bao",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                            CheckAdmin.Close();
                            AdminForm adminForm = new AdminForm();
                            adminForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Dang nhap user thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            CheckAdmin.Close();
                            UserForm userForm = new UserForm();
                            userForm.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tai khoan hoac mat khau khong dung", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch
                {
                    MessageBox.Show("Co loi xay ra", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning );
                }
            }          
        }
        private void PassWordTextBox_Enter(object sender, EventArgs e)
        {
            if (PassWordTextBox.Text == "Enter your password")
            {
                PassWordTextBox.Text = null;
                PassWordTextBox.PasswordChar = '*';
            }
            PassWordTextBox.ForeColor = Color.Black;

            if (ShowPass.Checked == true)
            {
                PassWordTextBox.PasswordChar = '\0';
            }
        }

        private void PassWordTextBox_Leave(object sender, EventArgs e)
        {
            if (PassWordTextBox.Text == "")
            {
                PassWordTextBox.Text = "Enter your password";
                PassWordTextBox.PasswordChar = '\0';
            }
            PassWordTextBox.ForeColor = Color.Gray;
        }

        private void UserText_Enter(object sender, EventArgs e)
        {
            if (UserText.Text == "Enter your name")
            {
                UserText.Text = "";
            }
            UserText.ForeColor = Color.Black;
        }

        private void UserText_Leave(object sender, EventArgs e)
        {
            if (UserText.Text == "")
            {
                UserText.Text = "Enter your name";
            }
            UserText.ForeColor = Color.Gray;
        }

     
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ForgetPasswordLink_Click(object sender, EventArgs e)
        {
            ResetForm resetForm = new ResetForm();         
            resetForm.Show();  
            this.Hide();
           
        }

        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(ShowPass.Checked)
            {
                PassWordTextBox.PasswordChar = '\0';
            }
            else
            {
                if (PassWordTextBox.Text != "Enter your password")
                {
                    PassWordTextBox.PasswordChar = '*';                   
                }
            }
        }

        private void PassWordTextBox_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void UserText_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void ForgetPasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetForm reset = new ResetForm();
            reset.Show();   
        }
    }
}
