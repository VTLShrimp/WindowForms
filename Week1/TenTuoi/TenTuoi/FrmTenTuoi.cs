using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TenTuoi
{
    public partial class FrmTenTuoi : Form
    {
        public FrmTenTuoi()
        {
            InitializeComponent();
        }

        private void txtHVT_textchanged(object sender, EventArgs e)
        {
            kiemtratextbox();
        }

        private void txtNTNS_textchanged(object sender, EventArgs e)
        {
            kiemtratextbox();
            Control ctr =  (Control)sender;
            if (ctr.Text.Length > 0 && !char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
                this.errorProvider.SetError(ctr, "This is avalid number");
            else
                this.errorProvider.Clear();
        }

        private void txtHVT_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider.SetError(ctr, "you must enter your name");
            else
                this.errorProvider.Clear();
        }

        private void kiemtratextbox()
        {
            btnShow.Enabled = !string.IsNullOrEmpty(txtHVT.Text) && !string.IsNullOrEmpty(txtNTNS.Text);
        }
        private void btnExit_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTenTuoi_closing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có thật sự muốn tắt không ???", "Ex1",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r != DialogResult.OK)
                e.Cancel = true;
        }

        private void btnShow_click(object sender, EventArgs e)
        {
            int age;
            string s;
            s = "My name is : " + txtHVT.Text + "\n";
            age = DateTime.Now.Year - Convert.ToInt32(txtNTNS.Text);
            s = s + "Age: " + age.ToString();
            MessageBox.Show(s);
        }

        private void btnclear_click(object sender, EventArgs e)
        {
            txtHVT.Clear();
            txtNTNS.Clear();
            txtHVT.Focus();
        }
    }
}
