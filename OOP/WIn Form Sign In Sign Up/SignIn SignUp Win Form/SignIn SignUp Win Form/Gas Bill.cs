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
    public partial class Gas_Bill : Form
    {
        public Gas_Bill()
        {
            InitializeComponent();
        }

        private void Gas_Bill_Load(object sender, EventArgs e)
        {
            currentBox.Text = CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].Amount.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt64(gasBox.Text) > CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].Amount)
            {
                MessageBox.Show("Low Money!!!");
                MessageBox.Show("Are You sure you enter correct bill price");
                Gas_Bill gB = new Gas_Bill();
                gB.Show();
                this.Hide();
            }
            else
            {
                long amount = Convert.ToInt64(gasBox.Text);
                CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].Amount = CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].Amount - amount;
                MessageBox.Show("Payment Successfull!!!!");
                currentBox.Text = CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].Amount.ToString();
                CustomerDL.add_CustomersInTo_file2("Customer.txt",CustomerDL.getListofCustomer());
                PayBills pB = new PayBills();
                pB.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PayBills pB = new PayBills();
            pB.Show();
            this.Hide();
        }
    }
}
