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
    public partial class _2Transfer_Amount_2 : Form
    {
        public _2Transfer_Amount_2()
        {
            InitializeComponent();
        }

        private void _2Transfer_Amount_2_Load(object sender, EventArgs e)
        {
            currentAmountBox.Text = CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].Amount.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            long amount = Convert.ToInt64(transferAmountBox.Text);
            while (amount > CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].Amount)
            {
                MessageBox.Show("Low Money!!!");
                transferAmountBox.Text = "";
                return;
            }
            CustomerDL.getListofCustomer()[CustomerDL.atmINdex].Amount = amount + CustomerDL.getListofCustomer()[CustomerDL.atmINdex].Amount;
            CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].Amount = CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].Amount - amount;
            currentAmountBox.Text = CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].Amount.ToString();
            transferAmountBox.Text = "";
            MessageBox.Show("Transfer Successfully!!!");
            CustomerDL.add_CustomersInTo_file2("Customer.txt", CustomerDL.getListofCustomer());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CurrentAccountType cT = new CurrentAccountType();
            cT.Show();
            this.Hide();
        }
    }
}
