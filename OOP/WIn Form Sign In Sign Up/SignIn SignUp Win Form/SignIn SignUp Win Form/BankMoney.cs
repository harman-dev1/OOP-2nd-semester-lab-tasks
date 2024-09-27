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
    public partial class BankMoney : Form
    {
        public BankMoney()
        {
            InitializeComponent();
        }

        private void BankMoney_Load(object sender, EventArgs e)
        {
            long money = 0;
            foreach(var a in CustomerDL.getListofCustomer())
            {
                money = a.Amount + money;
            }
            (moneyBox.Text) = money.ToString();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeMenu af = new EmployeeMenu();
            af.Show();
            this.Hide();
        }
    }
}
