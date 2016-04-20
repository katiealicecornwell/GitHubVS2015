using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowData SD = new ShowData();
            SD.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Menu MU = new Menu();
            MU.Show();
            this.Hide();
        }

    } 
}
