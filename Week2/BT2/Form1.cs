using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            try
            {
                int number = Convert.ToInt32(numberbox.Text);
                listsonguyen.Items.Add(number);
            }
            catch 
            {
                MessageBox.Show("Sai Dinh Dang", "Thong bao");
            }

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
          int index = listsonguyen.SelectedIndex;
          if(index >= 0)
          {
            listsonguyen.Items.RemoveAt(index);
          }
            else
            {
                MessageBox.Show("chua chon phan tu");
            }
            
        
        }

        private void changebutton_Click(object sender, EventArgs e)
        {
            int index = listsonguyen.SelectedIndex;
            int number = Convert.ToInt32(numberbox.Text);
            if(index >= 0)
            {
                try
                {
                    listsonguyen.Items[index] = number;
                }
                catch
                {
                    MessageBox.Show("Co loi");
                }
            }
            else
            {
                MessageBox.Show("Ko sua duoc");
            }
        }

        private void result_button_Click(object sender, EventArgs e)
        {
            int tong = 0;
            for(int i = 0;i < listsonguyen.Items.Count;i++)
            {
                tong += Convert.ToInt32(listsonguyen.Items[i]);
            }
            result_box.Text = tong.ToString();
        }
    }
}
