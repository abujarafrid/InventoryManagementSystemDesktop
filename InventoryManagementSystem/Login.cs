using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagementSystem.Forms;
using InventoryManagementSystem.Forms.Product;

namespace InventoryManagementSystem
{
    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            //Check
            if (userName == "admin" && password == "admin") 
            {
                MainForm mForm = new MainForm();
                mForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User name or password incorrect");
            }

            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
