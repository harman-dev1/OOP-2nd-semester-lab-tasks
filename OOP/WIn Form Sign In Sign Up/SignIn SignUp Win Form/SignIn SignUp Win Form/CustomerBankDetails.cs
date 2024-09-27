using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMS.BL;
using BMS.DL;

namespace SignIn_SignUp_Win_Form
{
    public partial class CustomerBankDetails : Form
    {
        public CustomerBankDetails()
        {
            InitializeComponent();
        }

        private void CustomerBankDetails_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(ListsDLUser.getlistOfBank()[0].BankName,ListsDLUser.getlistOfBank()[0].BankEmail, ListsDLUser.getlistOfBank()[0].BankBranchID, ListsDLUser.getlistOfBank()[0].BankAdddress, ListsDLUser.getlistOfBank()[0].BankNo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerMenu cM = new CustomerMenu();
            cM.Show();
            this.Hide();
        }
    }
}
