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
    public partial class CustomerPersonal : Form
    {
        public CustomerPersonal()
        {
            InitializeComponent();
        }

        private void CustomerPersonal_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].Name, CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].Email, CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].Password, CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].PhoneNo, CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].CNIC, CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].Address, CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].AtmId, CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].AtmPassword, CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].AccountType, CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].Amount);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerMenu cM = new CustomerMenu();
            cM.Show();
            this.Hide();
        }
    }
}
