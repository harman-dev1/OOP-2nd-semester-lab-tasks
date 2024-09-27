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
    public partial class CurrentAccountType : Form
    {
        public CurrentAccountType()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CurrentCheckBalance cB = new CurrentCheckBalance();
            cB.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddMoneyInAccount aA = new AddMoneyInAccount();
            this.Hide();
            aA.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Atm_Main_Interface aI = new Atm_Main_Interface();
            aI.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PIN_AND_ATM pA = new PIN_AND_ATM();
            pA.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PayBills pB = new PayBills();
            pB.Show();
            this.Hide();
        }
    }
}
