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
    public partial class AtmUpdate : Form
    {
        public AtmUpdate()
        {
            InitializeComponent();
        }

        private void typeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AtmUpdate_Load(object sender, EventArgs e)
        {
            IdBox.Text = CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].AtmId;
            passwordBox.Text = CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].AtmPassword.ToString();
            typeCombo.Text = CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].AccountType.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].AtmId = IdBox.Text;
            CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].AtmPassword = Convert.ToInt32(passwordBox.Text);
            CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].AccountType = typeCombo.Text;
            CustomerDL.add_CustomersInTo_file2("Customer.txt",CustomerDL.getListofCustomer());  
            MessageBox.Show("Updated Successfully!!!");
            clear();
        }
        private void clear()
        {
            IdBox.Text = "";
            passwordBox.Text = "";
            typeCombo.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomerMenu cM = new CustomerMenu();
            cM.Show();
            this.Close();
        }
    }
}
