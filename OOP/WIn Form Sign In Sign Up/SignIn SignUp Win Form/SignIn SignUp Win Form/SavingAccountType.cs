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
    public partial class SavingAccountType : Form
    {
        public SavingAccountType()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Atm_Main_Interface cM = new Atm_Main_Interface();
            cM.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoanFromBank lB = new LoanFromBank();
            lB.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddMoneyInAccount aA = new AddMoneyInAccount();
            aA.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Check_Balance cB = new Check_Balance();
            cB.Show();
            this.Hide();
        }
    }
}
