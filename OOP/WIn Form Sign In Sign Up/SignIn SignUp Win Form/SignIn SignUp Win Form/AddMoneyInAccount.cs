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
    public partial class AddMoneyInAccount : Form
    {
        public AddMoneyInAccount()
        {
            InitializeComponent();
        }

        private void AddMoneyInAccount_Load(object sender, EventArgs e)
        {
            (CurrentBox.Text) = CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].Amount.ToString();
            remainBox.Text = CustomerDL.dailyAmount.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            while (Convert.ToInt64(AmountBox.Text) > CustomerDL.dailyAmount)
            {

                MessageBox.Show("Limit Exceeded!!!");
                AmountBox.Text = "";
                return;
            }            
            CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].Amount = CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].Amount + Convert.ToInt64(AmountBox.Text);
            MessageBox.Show("Amount Added Successfully!!!");

            CustomerDL.dailyAmount = CustomerDL.dailyAmount - Convert.ToInt64(AmountBox.Text);
            remainBox.Text = CustomerDL.dailyAmount.ToString();
            CurrentBox.Text = CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].Amount.ToString();
            AmountBox.Text = "";
            CustomerDL.add_CustomersInTo_file2("Customer.txt",CustomerDL.getListofCustomer());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Atm_Main_Interface aI = new Atm_Main_Interface();
            aI.Show();
            this.Close();
        }

        private void remainBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
