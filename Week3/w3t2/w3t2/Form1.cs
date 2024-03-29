namespace w3t2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, dt, x1, x2;
            string kq = "";

            a = Convert.ToDouble(txta.Text);
            b = Convert.ToDouble(txtb.Text);
            c = Convert.ToDouble(txtc.Text);
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        kq = " Phương trình có vô số nghiệm";
                    }
                    else// c khác 0
                    {
                        kq = " Phương trình vô nghiệm";
                    }
                }
                else// b khac 0
                {
                    kq = String.Format("Phương trình có nghiệm là {0}", ((-c) / b));
                }
            }
            else// a khac 0 
            {
                dt = b * b - 4 * a * c;

                if (dt < 0)
                {
                    kq = " Phương trình vô nghiệm";
                }
                else if (dt == 0)
                {
                    kq = String.Format("Phương trình có nghiệm kép là {0}", ((-b) / (2 * a)));
                }
                else // dt >0
                {
                    x1 = (-b + Math.Sqrt(dt)) / (2 * a);
                    x2 = (-b - Math.Sqrt(dt)) / (2 * a);

                    kq = String.Format("Phương trình có 2 nghiệm phân biệt là: x1= {0}, x2= {1}", x1, x2);
                }


            }


            txtkq.Text = kq;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close  (); 
        }
    }
}

