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
    public partial class LoanFromBank : Form
    {
        public LoanFromBank()
        {
            InitializeComponent();
        }

        private void LoanFromBank_Load(object sender, EventArgs e)
        {
            CurrentBox.Text = CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].Amount.ToString();
            remainBox.Text = CustomerDL.loanDail.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            while (Convert.ToInt64(AmountBox.Text) > CustomerDL.loanDail)
            {

                MessageBox.Show("Limit Exceeded!!!");
                AmountBox.Text = "";
                return;
            }
            CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].Amount = CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].Amount + Convert.ToInt64(AmountBox.Text);
            CustomerDL.loanDail = CustomerDL.loanDail - Convert.ToInt64(AmountBox.Text);
            MessageBox.Show("Amount Added Successfully!!!");
            ListsDLUser.getlistOfBank()[0].BankMoney = ListsDLUser.getlistOfBank()[0].BankMoney - Convert.ToInt64(AmountBox.Text);
            remainBox.Text = CustomerDL.loanDail.ToString();
            CurrentBox.Text = CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].Amount.ToString();
            AmountBox.Text = "";
            CustomerDL.add_CustomersInTo_file2("Customer.txt", CustomerDL.getListofCustomer());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SavingAccountType cT = new SavingAccountType();
            cT.Show();
            this.Close();
        }
    }
}
