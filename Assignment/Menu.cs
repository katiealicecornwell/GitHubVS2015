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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ShowData_Click(object sender, EventArgs e)
        {
            ShowData SD = new ShowData();
            SD.Show();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Add AddData = new Add();
            AddData.Show();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Edit EditData = new Edit();
            EditData.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Delete DeleteData = new Delete();
            DeleteData.Show();
        }

        private void btnEmails_Click(object sender, EventArgs e)
        {
            Emails ShowEmails = new Emails();
            ShowEmails.Show();
        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            OrderHistory History = new OrderHistory();
            History.Show();
        }
    }
}
