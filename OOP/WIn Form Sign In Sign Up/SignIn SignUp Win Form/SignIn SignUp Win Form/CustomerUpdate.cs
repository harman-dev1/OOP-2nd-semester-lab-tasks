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
    public partial class CustomerUpdate : Form
    {
        public CustomerUpdate()
        {
            InitializeComponent();
        }

        private void CustomerUpdate_Load(object sender, EventArgs e)
        {
            NameBox.Text = CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].Name;
            EmailBox.Text = CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].Email;
            PasswordBox.Text = CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].Password;
            PhoneNoBox.Text = CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].PhoneNo.ToString();
            CNICBox.Text = CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].CNIC.ToString();
            AddressBox.Text = CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].Address;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].Name = NameBox.Text;
            CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].Email = EmailBox.Text;
            CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].Password = PasswordBox.Text;
            CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].CNIC = Convert.ToInt64(CNICBox.Text);
            CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].Address = AddressBox.Text;
            CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].PhoneNo = Convert.ToInt64(PhoneNoBox.Text);
            CustomerDL.add_CustomersInTo_file2("Customer.txt",CustomerDL.getListofCustomer());
            MessageBox.Show("Updated Successfully!!!");
            clear();
        }
        private void clear()
        {
            NameBox.Text = "";
            EmailBox.Text = "";
            PasswordBox.Text = "";
            CNICBox.Text = "";
            PhoneNoBox.Text = "";
            AddressBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerMenu cM = new CustomerMenu();
            cM.Show();
            this.Hide();
        }
    }
}
