using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignIn_SignUp_Win_Form
{
    public partial class EmployeeMenu : Form
    {
        public EmployeeMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCustomer ac = new AddCustomer();
            ac.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            SearchCustomerByEmployee sE = new SearchCustomerByEmployee();
            sE.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            BankData bD = new BankData();
            bD.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            UpdateEmployee uE = new UpdateEmployee();
            uE.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            BankMoney bM = new BankMoney();
            bM.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            EmployeePersonalData eD = new EmployeePersonalData();
            eD.Show();
            this.Hide();
        }
    }
}
