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
    public partial class Check_Balance : Form
    {
        public Check_Balance()
        {
            InitializeComponent();
        }

        private void Check_Balance_Load(object sender, EventArgs e)
        {
            amountBox.Text = CustomerDL.getListofCustomer()[CustomerDL.specificIndexForCustomer].Amount.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SavingAccountType cT = new SavingAccountType();
            cT.Show();
            this.Hide();
        }
    }
}
