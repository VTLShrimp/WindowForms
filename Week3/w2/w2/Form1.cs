namespace w2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            double height = double.Parse(txtHeight.Text);
            double weight = double.Parse(txtWeight.Text);
            double idealWeight;

            if (rdoMale.Checked)
            {
                idealWeight = height - 100 - (height - 150) / 4;
            }
            else
            {
                idealWeight = height - 100 - (height - 150) / 2;
            }



            if (weight < idealWeight)
            {
                lblResult.Text = "Cân nặng lý tưởng của " + name + " là: " + idealWeight.ToString() + " kg" + " " + "Ban dang thieu can";

            }
            else
            {
                lblResult.Text = lblResult.Text = "Cân nặng lý tưởng của " + name + " là: " + idealWeight.ToString() + " kg" + " "
                    + "Bạn đang thừa cân.";
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtHeight.Text = "";
            txtWeight.Text = "";
            lblResult.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
