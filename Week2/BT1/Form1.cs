using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTinh_Click(object sender, EventArgs e)
        {
            try {
                double tong = 0;
                string dayso = numbersBox.Text;
                string[] daysochuan = dayso.Split(',');
                for (int i = 0; i < daysochuan.Length; i++)
                {
                    double so = Convert.ToDouble(daysochuan[i]);
                    tong = tong + so;
                }
                    double tbc = (tong / (daysochuan.Length));
                    result_box.Text = tbc.ToString();
                }
                catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
        }   
    }
}
