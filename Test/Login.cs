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
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
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
                    string Connetdata = @"Data Source=LAMLMAO;Initial Catalog=User_Management;Integrated Security=True;";
                    string username = UserText.Text;
                    string password = PassWordTextBox.Text;
                    DateTime now = DateTime.Now;
                    string checkAccout = "select * from User_Info where UserName = '" + username + "' and UserPassword = '" + password + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter(checkAccout,Connetdata);
                    DataSet data = new DataSet();
                    adapter.Fill(data,"User_Info");
                    DataTable dt = data.Tables["User_Info"];
                    if(dt.Rows.Count > 0)
                    {
                        string checktype = "select * from User_Info where UserName = '" + username + "' and UserType = 'admin'";
                        SqlConnection sqlConnection = new SqlConnection(Connetdata);
                        SqlDataAdapter checkTypeAdapter = new SqlDataAdapter(checktype,Connetdata);
                        DataSet checkTypeData = new DataSet();
                        checkTypeAdapter.Fill(checkTypeData, "User_Info");
                        DataTable checktypetable = checkTypeData.Tables["User_Info"];
                       /* TextWriter textWriter1 = new StreamWriter("D:\\University\\Code\\CS\\Data.txt");
                        textWriter1.WriteLine("Tài khoản đã đăng nhập : " + username);
                        textWriter1.WriteLine("Vào lúc : " + now);
                        textWriter1.WriteLine("-----------------------------------");
                        textWriter1.Close();*/
                        if (checktypetable.Rows.Count > 0 )
                        {
                            MessageBox.Show("Dang nhap admin thanh cong","Thong bao",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            string uprecord = "insert into User_Login_Record values ('"+username+"','admin','"+now+"') ";
                            sqlConnection.Open();
                            SqlCommand insertrecord = new SqlCommand(uprecord,sqlConnection);
                            insertrecord.ExecuteNonQuery();
                            sqlConnection.Close();
                            AdminForm adminForm = new AdminForm();
                            adminForm.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("dang nhap user thanh cong","Thong bao",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            string uprecord = "insert into User_Login_Record values ('" + username + "','user','" + now + "') ";
                            sqlConnection.Open();
                            SqlCommand insertrecord = new SqlCommand(uprecord, sqlConnection);
                            insertrecord.ExecuteNonQuery();
                            sqlConnection.Close();
                            UserForm userForm = new UserForm();
                            userForm.Show();
                            Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sai tai khoan hoac mat khau", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch
                {
                    MessageBox.Show("Co loi xay ra", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            DialogResult a =MessageBox.Show("Ban co chac muon thoat", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(a == DialogResult.Yes)
            {
                Close();
            }
        }

        private void ForgetPasswordLink_Click(object sender, EventArgs e)
        {
            ResetForm resetForm = new ResetForm();         
            resetForm.Show();  
            Hide();
           
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

        private void ForgetPasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetForm reset = new ResetForm();
            reset.Show();   
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterFrom registerFrom = new RegisterFrom();
            registerFrom.Show();
        }
    }
}
