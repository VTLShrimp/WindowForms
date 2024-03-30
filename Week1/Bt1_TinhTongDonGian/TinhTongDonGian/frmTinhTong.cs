using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhTongDonGian
{
    public partial class frmTinhTong : Form
    {
        public frmTinhTong()
        {
            InitializeComponent();
        }

        private void btnTinhTong_click(object sender, EventArgs e)
        {
            try 
            { 
                int Tong = Int32.Parse(txtSohang1.Text) + Int32.Parse(txtSohang2.Text);
                txtTong.Text = Tong.ToString();
            } catch (Exception ex)
            { 
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSohang1_TextChanged(object sender, EventArgs e)
        {
            KiemTraTextBox();
        }

        private void txtSohang2_TextChanged(object sender, EventArgs e)
        {
            KiemTraTextBox();
        }
        private void KiemTraTextBox()
        {
            btnTinhTong.Enabled = !string.IsNullOrEmpty(txtSohang1.Text) && !string.IsNullOrEmpty(txtSohang2.Text);
        }
    }
}
