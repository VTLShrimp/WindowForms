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

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalButton_Click(object sender, EventArgs e)
        {
            int Perfect;
            int T = Convert.ToInt32(HightBox.Text);
            int N = 0;
            if (MaleButton.Checked)
            {
                N = 4;
                Perfect = T - 100 - ((T - 150) / N);
                if (Perfect > Convert.ToInt32(WeightButton.Text))
                {
                    listInfo.Items.Add(NameBox.Text + " có cân nặng lý tưởng là : " + Perfect + " Bạn này bị thừa cân");
                }
                else if (Perfect < Convert.ToInt32(WeightButton.Text))
                {
                    listInfo.Items.Add(NameBox.Text + " có cân nặng lý tưởng là : " + Perfect + " Bạn này bị thiếu cân");
                }
                else
                {
                    listInfo.Items.Add(NameBox.Text + " có cân nặng lý tưởng là : " + Perfect + " Bạn này có cân nặng chuẩn");
                }
            }
            if(FemaleButton.Checked)
            {
                N = 2;
                Perfect = T - 100 - ((T - 150) / N);
                if (Perfect > Convert.ToInt32(WeightButton.Text))
                {
                    listInfo.Items.Add(NameBox.Text + " có cân nặng lý tưởng là : " + Perfect + " Bạn này bị thừa cân");
                }
                else if (Perfect < Convert.ToInt32(WeightButton.Text))
                {
                    listInfo.Items.Add(NameBox.Text + " có cân nặng lý tưởng là : " + Perfect + " Bạn này bị thiếu cân");
                }
                else
                {
                    listInfo.Items.Add(NameBox.Text + " có cân nặng lý tưởng là : " + Perfect + " Bạn này có cân nặng chuẩn");
                }
            }

        
            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
