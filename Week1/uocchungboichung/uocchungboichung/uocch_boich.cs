using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uocchungboichung
{
    public partial class frmuocch_boich : Form
    {
        public frmuocch_boich()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            int so1 = Convert.ToInt32(txtso1.Text);
            int so2 = Convert.ToInt32(txtso2.Text);

            int ucln = UocChungLonNhat(so1, so2);
            int bcnn = BoiChungNhoNhat(so1, so2);

            txtucln.Text = ucln.ToString();
            txtbcnn.Text = bcnn.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txthoten.Clear();
            txtso1.Clear();
            txtso2.Clear();
            txtucln.Clear();
            txtbcnn.Clear();
            txthoten.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
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
            btntim.Enabled = !string.IsNullOrEmpty(txtso1.Text) && !string.IsNullOrEmpty(txtso2.Text) && !string.IsNullOrEmpty(txthoten.Text);
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

        private void txthoten_TextChanged(object sender, EventArgs e)
        {
            kiemtraso();
        }
    }
}
