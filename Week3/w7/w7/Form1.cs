namespace w7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (int factor in lstFactors.Items)
            {
                sum += factor;
            }
            MessageBox.Show($"Tổng các ước số: {sum}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập
            if (int.TryParse(txtInput.Text, out int number))
            {

                // Xóa textbox nhập và đặt con trỏ lại textbox nhập
                txtInput.Clear();
                txtInput.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hiển thị các ước số của số được chọn vào Listbox
            int number = (int)cmbNumbers.SelectedItem;
            lstFactors.Items.Clear();
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    lstFactors.Items.Add(i);
                }
            }
        }
    }
}
