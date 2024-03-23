using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT6
{
    public partial class Form1 : Form
    {

        double money = 0;
        int count = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Chua nhap khach hang", "Thong bao");
            }
            else
            {
                count += 1;
                if (radioButton1.Checked)
                {
                    if (checkBox1.Checked)
                    {
                        money += 20000 - (20000 * 0.2);
                        radioButton1 .Checked = false;
                        MessageBox.Show("Khach hang " + textBox1.Text + " vua thanh toan cafe den voi gia " + (20000-(20000 * 0.2)) + " dong", "Thong bao");
                    }
                    else
                    {
                        money += 20000;
                        radioButton1.Checked = false;
                        MessageBox.Show("Khach hang " + textBox1.Text + " vua thanh toan cafe den voi gia " + 20000  + " dong", "Thong bao");
                    }
                }
                else if (radioButton2.Checked)
                {
                    if (checkBox1.Checked)
                    {
                        money += 25000 - (25000 * 0.2);
                        radioButton2 .Checked = false;
                        MessageBox.Show("Khach hang " + textBox1.Text + " vua thanh toan cafe sua voi gia " + (25000 - (25000 * 0.2)) + " dong", "Thong bao");
                    }
                    else
                    {
                        money += 25000;
                        radioButton2.Checked = false;
                        MessageBox.Show("Khach hang " + textBox1.Text + " vua thanh toan cafe sua voi gia " + 25000 + " dong", "Thong bao");
                    }
                }
                else if (radioButton3.Checked)
                {
                    if (checkBox1.Checked)
                    {
                        money += 30000 - (30000 * 0.2);
                        radioButton3 .Checked = false;
                        MessageBox.Show("Khach hang " + textBox1.Text + " vua thanh toan cafe sua da voi gia " + (30000 - (30000 * 0.2)) + " dong", "Thong bao");
                    }
                    else
                    {
                        money += 30000;
                        radioButton3.Checked = false;
                        MessageBox.Show("Khach hang " + textBox1.Text + " vua thanh toan cafe sua da voi gia " + 30000 + " dong", "Thong bao");
                    }
                }
                else if (radioButton4.Checked)
                {
                    if (checkBox1.Checked)
                    {
                        money += 25000 - (25000 * 0.2);
                        radioButton4 .Checked = false;
                        MessageBox.Show("Khach hang " + textBox1.Text + " vua thanh toan cafe da voi gia " + (25000 - (25000 * 0.2)) + " dong", "Thong bao");

                    }
                    else
                    {
                        money += 25000;
                        radioButton4 .Checked = false;
                        MessageBox.Show("Khach hang " + textBox1.Text + " vua thanh toan cafe da voi gia " + 25000 + " dong", "Thong bao");
                    }
                }
                else if (radioButton5.Checked)
                {
                    if (checkBox1.Checked)
                    {
                        money += 35000 - (35000 * 0.2);
                        radioButton5 .Checked = false;
                        MessageBox.Show("Khach hang " + textBox1.Text + " vua thanh toan cafe kem voi gia " + (35000 - (35000 * 0.2)) + " dong", "Thong bao");
                    }
                    else
                    {
                        money += 35000;
                        radioButton5.Checked = false;
                        MessageBox.Show("Khach hang " + textBox1.Text + " vua thanh toan cafe kem voi gia " + 35000 + " dong", "Thong bao");
                    }
                }
                else
                {
                    MessageBox.Show("Chua chon mon", "Thong Bao");
                }
            }
            textBox1.Clear();
            button2.Enabled = false;
            button3.Enabled = true;
            button1.Enabled = false;
            checkBox1.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = count.ToString();
            textBox3.Text = money.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            radioButton1 .Checked = false;
            radioButton2 .Checked = false;
            radioButton3 .Checked = false;
            radioButton4 .Checked = false;
            radioButton5 .Checked = false;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true || radioButton4.Checked == true || radioButton5.Checked ==true )
            {
                button1 .Enabled = true;
                button2 .Enabled = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) == false)
            {
                button1.Enabled = true;
                button2.Enabled=true;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) == false)
            {
                button1.Enabled = true;
                button2.Enabled=true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) == false)
            {
                button1.Enabled = true;
                button2.Enabled=true;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) == false)
            {
                button1.Enabled = true;
                button2.Enabled = true; 
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) == false)
            {
                button1.Enabled = true;
                button2.Enabled=true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Co chac muon thoat ?","Thong bao",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
           if(r == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
