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
    public partial class Atm_Main_Interface : Form
    {
        public Atm_Main_Interface()
        {
            InitializeComponent();
        }

        private void Atm_Main_Interface_Load(object sender, EventArgs e)
        {
            if(CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].AccountType == "Saving")
            {
                label1.Text = "Your account Type is Saving so You only can add money";
            }
            else if (CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].AccountType == "Current")
            {
                label1.Text = " Your account Type is Current so You can Perform Multiple Operations";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

            CustomerMenu cM = new CustomerMenu();
            cM.Show();
            this.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
            if (CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].AccountType == "Current")
            {
                CurrentAccountType cT = new CurrentAccountType();
                cT.Show();
                this.Hide();
            }
            else if (CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].AccountType == "Saving")
            {
                SavingAccountType cT = new SavingAccountType();
                cT.Show();
                this.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
