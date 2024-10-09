using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkManagementSystem.Models;

namespace WorkManagementSystem.Forms
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        LoginUser _loginUser;
        public MainForm(LoginUser user)
        {
            InitializeComponent();
            _loginUser = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomersForm createCustomerForm = new CustomersForm(_loginUser);
            createCustomerForm.ShowDialog();
        }
    }
}
