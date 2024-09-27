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
    public partial class Bank : Form
    {
        public Bank()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminForm aF = new AdminForm();
            aF.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                AdminBL a = new AdminBL();
                string BankName = BankNameBox.Text;
                string BankEmail = BankEmailBox.Text;
                string BankBranchID = BankBranchBox.Text;
                long BankNo = Convert.ToInt64(BankNoBox.Text);
                string BankAdddress = BankAddressBox.Text;
            long loan = Convert.ToInt64(moneyLoanBox.Text);
                a.setBankDetails(BankName, BankEmail, BankBranchID, BankAdddress, BankNo,loan);
                ListsDLUser.setlistOfBank(a);
                string path = "Bank_Data.txt";
                ListsDLUser.Store_Bank_Data_Into_File(path,a);
                MessageBox.Show("Data Save Successfully!!!");
            this.Hide();
            AdminForm aF = new AdminForm();
            aF.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
