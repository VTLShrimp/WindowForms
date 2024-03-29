using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class RegisterFrom : Form
    {
        string Stringdata = @"Data Source=LAMLMAO;Initial Catalog=User_Management;Integrated Security=True;";
        public RegisterFrom()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text)) 
            {

            }
            else {
                string username = textBox1.Text;
                string password = textBox2.Text;
                string gmail = textBox3.Text;
                DateTime now = DateTime.Now;
                string checkaccout = "select * from User_Info where UserName = '" + username + "'";
                SqlDataAdapter da = new SqlDataAdapter(checkaccout, Stringdata);
                DataSet data = new DataSet();
                da.Fill(data, "User_Info");
                DataTable dt = data.Tables["User_Info"];
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Tai khoan da co trong he thong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {

                    if (textBox3.Text.Contains("@"))
                    {
                        string NewRegister = "insert into User_Info values ('" + username + "','" + password + "','user')";
                        string UpRegisterRecord = "insert into User_Register_Record values ('" + username + "','" + password + "','" + gmail + "','" + now + "')";
                        SqlConnection connection = new SqlConnection(Stringdata);
                        connection.Open();
                        SqlCommand UpNewUser = new SqlCommand(NewRegister, connection);
                        SqlCommand UpRegister = new SqlCommand(UpRegisterRecord, connection);
                        UpNewUser.ExecuteNonQuery();
                        UpRegister.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Dang ky thanh cong", "Thong bao");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Gmail khong dung dinh dang", "Thong bao");
                    }
                }

            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Khong dang ky", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                textBox2.PasswordChar = '*';
            }
            else
            {
                textBox2.PasswordChar = '\0';
            }
        }
    }
}
