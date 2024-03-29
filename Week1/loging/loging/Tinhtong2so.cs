using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loging
{
    public partial class Tinhtong2so : Form
    {
        public Tinhtong2so()
        {
            InitializeComponent();
        }

        private void Tinhtong2so_Load(object sender, EventArgs e)
        {

        }

        private void Tinhtong2so_closed(object sender, FormClosedEventArgs e)
        {
            trangchinhlogin login = new trangchinhlogin();
            login.ShowDialog();
        }
    }
}
