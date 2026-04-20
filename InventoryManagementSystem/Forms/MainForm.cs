using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagementSystem.Forms.Product;

namespace InventoryManagementSystem.Forms
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnProductForm_Click(object sender, EventArgs e)
        {
           AddProductForm pForm = new AddProductForm();
            pForm.Show();
            this.Hide();



        }
    }
}
