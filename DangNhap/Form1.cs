using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DangNhap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void Pass_Click(object sender, EventArgs e)
        {

        }

        private void PhoneNumber_Click(object sender, EventArgs e)
        {

        }

        private void Address_Click(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(AddressBox.Text) || String.IsNullOrEmpty(PasswordBox.Text) || String.IsNullOrEmpty(IDBox.Text) || String.IsNullOrEmpty(PhoneNumberBox.Text))
            {
                MessageBox.Show("Không được bỏ trống");
                return;
            }



            if (IDBox.Text == "TDMU" || PasswordBox.Text == "TDMU")
            {
                // IDBox.Text.IndexOf("TDMU");

                MessageBox.Show("Vui lòng nhập lại");
                IDBox.Clear();
                PasswordBox.Clear();
                PhoneNumberBox.Clear();
                AddressBox.Clear();
                return;

            }
            else
            {
                MessageBox.Show("Đăng ký thành công");
                IDBox.Clear();
                PasswordBox.Clear();
                PhoneNumberBox.Clear();
                AddressBox.Clear();
                return;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PhoneNumberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void PasswordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            IDBox.Clear();
            PasswordBox.Clear();
            PhoneNumberBox.Clear();
            AddressBox.Clear();
            return;
        }
    }
}
   

