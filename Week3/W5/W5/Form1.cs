namespace W5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.ResetText();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            textBox1.ResetText();
            textBox2.ResetText();
            listBox2.Items.Add("Bóng đá");
            listBox2.Items.Add("Bóng bàn");
            listBox2.Items.Add("Cầu lông");
            listBox2.Items.Add("Nhảy dù");
            listBox2.Items.Add("Bắn bi");
            listBox2.Items.Add("Bập bênh");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString("dd/MM/yyyy");
            textBox2.Text = DateTime.Now.ToString("hh:mm:ss tt");
            comboBox1.Items.Add("Nguyễn Văn A");
            comboBox1.Items.Add("Nguyễn Trung Tính");
            comboBox1.Items.Add("Đặng Sỹ Nhật");
            comboBox1.Items.Add("Hồ NGọc Quang");
            comboBox1.Items.Add("Nguyễn Ngô Vũ Hoàng Gia");
            comboBox1.SelectedItem = " Vũ Thanh Lâm";

            listBox2.Items.Add("Bóng đá");
            listBox2.Items.Add("Bóng bàn");
            listBox2.Items.Add("Cầu lông");
            listBox2.Items.Add("Nhảy dù");
            listBox2.Items.Add("Bắn bi");
            listBox2.Items.Add("Bập bênh");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = listBox2.SelectedIndex;
            string item = listBox2.Items[i].ToString();
            listBox1.Items.Add(item);
            listBox2.Items.Remove(item);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            string item = listBox1.Items[i].ToString();
            listBox2.Items.Add(item);
            listBox1.Items.Remove(item);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            int n = listBox2.Items.Count;
            for (i = 0; i <= n - 1; i++)
            {
                listBox2.SelectedIndex = 0;
                listBox1.Items.Add(listBox2.SelectedItem.ToString());
                listBox2.Items.Remove(listBox2.SelectedItem.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i;
            int n = listBox1.Items.Count;
            for (i = 0; i <= n - 1; i++)
            {
                listBox1.SelectedIndex = 0;
                listBox2.Items.Add(listBox1.SelectedItem.ToString());
                listBox1.Items.Remove(listBox1.SelectedItem.ToString());
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i;
            int n = listBox1.Items.Count;
            richTextBox1.Text = comboBox1.Text +
                "\r\n" + textBox1.Text +
                " " + textBox2.Text +
                "\r\n** Mon da chon: \r\n";
            for (i= 0; i < n; i++)
            {
                listBox1.SelectedIndex = i;
                richTextBox1.Text += listBox1.Text + ", ";

            }
        }
    }

}
