using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMS.DL;
using BMS.DL;

namespace SignIn_SignUp_Win_Form
{
    public partial class PinAndAtmBills : Form
    {
        public PinAndAtmBills()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string atmId = IdBox.Text;
            int password = Convert.ToInt32(PINBox.Text);
            bool flag = CustomerDL.verifyATM(atmId, password);
            if (flag == false)
            {
                MessageBox.Show("Not Verify Enter ATM ID and PIN again");
                CurrentAccountType cT = new CurrentAccountType();
                cT.Show();
                this.Hide();
            }
            else if (flag == true)
            {
                PayBills pB = new PayBills();
                pB.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CurrentAccountType cT = new CurrentAccountType();
            cT.Show();
            this.Hide();
        }
    }
}
