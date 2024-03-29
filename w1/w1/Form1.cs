namespace w1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbTenKhachHang.Items.Add("Nguyen Van A");
            cbTenKhachHang.Items.Add("Nguyen Van B");
            cbTenKhachHang.Items.Add("Nguyen Van C");
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int n1, n2, n3, n4 = 50, n5, n6;
        private void btTinh_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToInt32(KhungCSCu.Text);
            n2 = Convert.ToInt32(KhungCSMoi.Text);
            n3 = n2 - n1;
            if (n3 < 0)
            {
                MessageBox.Show("Nhap so cu, so moi sai quy dinh", "Thong Bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                KhungCSCu.Clear();
                KhungCSMoi.Clear();
                KhungCSCu.Focus();
                return;
            }
            SoKWTieeuThu.Text = Convert.ToString(n3);
            if (n3 < 50)
            {
                SoTRongDinhMuc.Text = Convert.ToString(n3);
                SoVuotDinhMuc.Text = Convert.ToString(0);
                n6 = n3 * 500;
                KhungTongTien.Text = Convert.ToString(n6);
            }
            else
            {
                n5 = n3 - n4;
                SoTRongDinhMuc.Text = Convert.ToString(n4);
                SoVuotDinhMuc.Text = Convert.ToString(n5);
                n6 = n4 * 500 + n5 * 1000;
                KhungTongTien.Text = Convert.ToString(n6);
            }
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            rtbXuatKetQua.Text = cbTenKhachHang.SelectedItem + "\r\n"
                + " SO kw tieu thu:" + SoKWTieeuThu.Text + "\r\n"
                + " SO kw trong dinh muc:" + SoTRongDinhMuc.Text + "\r\n"
                + " SO kw vuot dinh muc:" + SoVuotDinhMuc.Text + "\r\n"
                + " Tong tien:" + KhungTongTien.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }


}

