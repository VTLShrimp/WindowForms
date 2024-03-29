using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cannangchuan
{
    public partial class frmcannangchuan : Form
    {
        public frmcannangchuan()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            string hoten = txthoten.Text;
            int height = int.Parse(txtchieucao.Text);
            int cannang = int.Parse(txtcannang.Text);
            int N = (chknam.Checked) ? 4 : 2;
            int canNangLyTuong = height - 100 - (height - 150) / (int)N;
            int chenhLech = 0;
            string result = $"Chào bạn: {hoten} \n";
            result += $"Bạn có cân nặng lý tưởng là {canNangLyTuong}.\n";
            if (cannang < canNangLyTuong)
            {
                chenhLech = canNangLyTuong - cannang;
                result += $"So với hiện tại bạn đang thiếu khoản {chenhLech}.\n";
            }
            else if (cannang > canNangLyTuong)
            {
                chenhLech =cannang - canNangLyTuong;
                result += $"So với hiện tại bạn đang thừa khoản {chenhLech} .\n";
            }
            else
            {
                result += "Bạn đang ở trạng thái cân đối.\n";
            }
            rtbketqua.Text = result;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txthoten.Clear();
            txtchieucao.Clear();
            txtcannang.Clear();
            rtbketqua.Clear();
            chknam.Checked = false;
            chkbnu.Checked = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txthoten_TextChanged(object sender, EventArgs e)
        {
            kiemtra();
        }

        private void txtchieucao_TextChanged(object sender, EventArgs e)
        {
            kiemtra();
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
                this.errorProvider.SetError(ctr, "Vui lòng nhập số !!!");
            else
                this.errorProvider.Clear();
        }

        private void txtcannang_TextChanged(object sender, EventArgs e)
        {
            kiemtra();
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
                this.errorProvider.SetError(ctr, "Vui lòng nhập số !!!");
            else
                this.errorProvider.Clear();
        }

        private void kiemtra()
        {
            btnXoa.Enabled = !string.IsNullOrEmpty(txthoten.Text) || !string.IsNullOrEmpty(txtchieucao.Text) || !string.IsNullOrEmpty(txtcannang.Text) || (chknam.Checked || chkbnu.Checked);
            btnTinh.Enabled = !string.IsNullOrEmpty(txthoten.Text) && !string.IsNullOrEmpty(txtchieucao.Text) && !string.IsNullOrEmpty(txtcannang.Text) && (chknam.Checked || chkbnu.Checked);
        }

        private void chknam_checkChanged(object sender, EventArgs e)
        {
            kiemtra();
            if (chknam.Checked)
            {
                chkbnu.Checked = false;
            }
        }
        private void chkbnu_checkChanged(object sender, EventArgs e)
        {
            kiemtra();
            if (chkbnu.Checked)
            {
                chknam.Checked = false;
            }
        }

        private void frmcannangchuan_clos(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có thật sự muốn tắt không ???", "Thoat!!!",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r != DialogResult.OK)
                e.Cancel = true;
        }
    }
}
