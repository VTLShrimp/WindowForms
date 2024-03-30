using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt7_xemnam
{
    public partial class frmtinhnam : Form
    {
        public frmtinhnam()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            int namDuongLich = Int32.Parse(txtnamd.Text);
            string[] can = { "Canh", "Tân", "Nhâm", "Quý", "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ" };
            string[] chi = { "Thân", "Dậu", "Tuất", "Hợi", "Tý", "Sửu", "Dần", "Mẹo", "Thìn", "Tỵ", "Ngọ", "Mùi" };

            int canIndex = (namDuongLich - 4) % 10; // Can của năm Âm lịch
            if (canIndex < 0) canIndex += 10;

            int chiIndex = (namDuongLich - 4) % 12; // Chi của năm Âm lịch
            if (chiIndex < 0) chiIndex += 12;

            string canNam = can[canIndex];
            string chiNam = chi[chiIndex];
            txtnama.Text = $"{canNam} {chiNam}";
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtnamd_TextChanged(object sender, EventArgs e)
        {
            kiemtra();
        }

        private void txtnama_TextChanged(object sender, EventArgs e)
        {
            kiemtra();
        }
        private void kiemtra()
        {
            btntinh.Enabled = !string.IsNullOrEmpty(txtnamd.Text);
        }

        private void txtnamd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
