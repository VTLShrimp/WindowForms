using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataBaseFakeDataSet1.BT1week3' table. You can move, or remove it, as needed.
            this.bT1week3TableAdapter1.Fill(this.dataBaseFakeDataSet1.BT1week3);


        }

        private void CalButton_Click(object sender, EventArgs e)
        {
            int kwold = Convert.ToInt32(oldnum.Text);
            int kwnew = Convert.ToInt32(newnum.Text);
            int consume = kwnew - kwold ;
            int consumeOl = consume - Convert.ToInt32(textBox6.Text);
            int money;
            PrintButton.Enabled = true;
            
            if(consume < 0)
            {
                MessageBox.Show("Chi so moi sai");
                newnum.Clear();
                return;
            }
            else
            {
                kwconsume.Text = consume.ToString();
            }


            if(consumeOl < 0)
            {
                kwOL.Text = "0";
                money = consume * 500;
                textBox7.Text = money.ToString();   
            }
            else
            {
                kwOL.Text = (consume - Convert.ToInt32(textBox6.Text)).ToString();
                money = (consume * 500) + (consumeOl * 1000);
                textBox7.Text = money.ToString();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                
              /*  SqlConnection con = new SqlConnection(@"Data Source=LamLmao;Initial Catalog=DataBaseFake;Integrated Security=True");
                string name = comboBox1.Text;
                con.Open();
                string check = "select Old_number from BT1week3 where Name = '"+ name +"'";
                SqlCommand cmd = new SqlCommand(check, con);
                SqlDataReader checking = cmd.ExecuteReader();
                while (checking.Read())
                {
                    int d = Convert.ToInt32(checking["Old_number"]);
                    oldnum.Text = d.ToString();
                }
                checking.Close();
                con.Close();*/
              
           
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.Text);
            listBox1.Items.Add("Số Kw tiêu thụ : " + kwconsume.Text);
            listBox1.Items.Add("Tổng tiền : " + textBox7.Text);
            PrintButton.Enabled = false;
            kwconsume.Clear();
            textBox7.Clear();
            kwOL.Clear();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
