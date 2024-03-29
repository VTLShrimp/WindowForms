using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Test
{
    public partial class ResetForm : Form
    {
        string conStr = @"Data Source=LAMLMAO;Initial Catalog=User_Management;Integrated Security=True;";
        public ResetForm()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                string username = Usernametextbox.Text;
                string newpass = NewPassTextBox.Text;
                DateTime now = DateTime.Now;
                string sqlStr = "select * from User_Info where UserName = '" + username + "' ";
                SqlDataAdapter da = new SqlDataAdapter(sqlStr, conStr);
                DataSet data = new DataSet();
                da.Fill(data, "User_Info");
                DataTable dt = data.Tables["User_Info"];
                DataRow[] oldpass = dt.Select(); 
                if (dt.Rows.Count > 0)
                {
                    if(NewPassTextBox.Text == ConfirmTextBox.Text)
                    {
     
                        string updatePass = "update User_Info set UserPassword = '" + newpass + "' where UserName  = '" + username + "'";
                        SqlConnection sqlConnection = new SqlConnection(conStr);
                        SqlCommand command = new SqlCommand(updatePass, sqlConnection);
                        string uprecord = "insert into Reset_Pass_Record values ('" + username + "','" + oldpass[0]["UserPassword"] + "','" + newpass + "','" + now + "')";
                        SqlCommand command1 = new SqlCommand(uprecord, sqlConnection);
                        sqlConnection.Open();
                        command.ExecuteNonQuery();
                        command1.ExecuteNonQuery();
                        sqlConnection.Close();
                        DialogResult a = MessageBox.Show("Cap nhat thanh cong", "Thong bao",MessageBoxButtons.OK);
                       if(a==DialogResult.OK)
                        {
                            Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xac nhan khong khop", "Thong bao");
                        NewPassTextBox.Clear();
                        ConfirmTextBox.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Khong co tai khoan trong he thong","Thong bao");
                    Usernametextbox.Clear(); 
                }
            }
            catch 
            {

            }
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                NewPassTextBox.PasswordChar = '\0';
                ConfirmTextBox.PasswordChar = '\0';
            }
            else
            {
                NewPassTextBox.PasswordChar = '*';
                ConfirmTextBox.PasswordChar = '*';
            }
        }
    }
}
