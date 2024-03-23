using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {       
                if (String.IsNullOrEmpty(CustomBox.Text) != true)
                {
                    InfoList.Items.Add("Khách hàng : " + CustomBox.Text);
                }
                else
                {
                    MessageBox.Show("Chua nhap ten khach hang", "Thong bao");
                    return;
                }
                DateTime Now = DateTime.Now;
                DateTime SelectedDate = DatebirthSelect.Value;
                if(DatebirthSelect.Value > Now) 
                {
                    MessageBox.Show("Ngay chon ko dung","Thong bao");
                    return;
             
                }
                else
                {
                    InfoList.Items.Add("Ngày sinh : " + DatebirthSelect.Text);
                }
                if(String.IsNullOrEmpty(AddressBox.Text) == true)
                {
                    MessageBox.Show("Chua nhap dia chi","Thong bao");
                    return;
                }
                else
                {
                    InfoList.Items.Add("Địa chỉ : " + AddressBox.Text);
                }
                if(String.IsNullOrEmpty(ComboGo.Text) == true || String.IsNullOrEmpty(ComboTo.Text) == true)
                {
                    MessageBox.Show("Chua nhap du diem di va diem den", "Thong bao");
                    return;
                }
                else
                {
                    InfoList.Items.Add("Địa điểm đi : " + ComboGo.Text);
                    InfoList.Items.Add("Địa điểm tới : " + ComboTo.Text);
                }

                var timego = DateGo.Value;
                var timecome = DateCome.Value;
                var value = timecome - timego ;

                if(timego == timecome)
                {
                    MessageBox.Show("Ngay di va ve dang bi trung", "Thong bao");
                    return;
                }
                else if(timego < timecome)
                {
                    MessageBox.Show("Ngay di va ve bi sai", "Thong bao");
                    return;
                }
                else
                {
                    TotalDayBox.Text = Convert.ToString(value.Days);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }

        private void ResetButton_Click(object sender, EventArgs e)
        { 
            InfoList.Items.Clear(); 
            CustomBox.Clear();
            DatebirthSelect.ResetText();
            AddressBox.Clear();
            ComboGo.ResetText();
            ComboTo.ResetText();
            DateGo.ResetText();
            DateCome.ResetText();  
            TotalDayBox.Clear();
        }
    }
}
