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
    public partial class CustomerMenu : Form
    {
        public CustomerMenu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
                CustomerPersonal cP = new CustomerPersonal();
                cP.Show();
                this.Hide();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            CustomerBankDetails cD = new CustomerBankDetails();
            cD.Show();
            this.Hide();
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            AtmUpdate aU = new AtmUpdate();
            aU.Show();
            this.Hide();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            CustomerUpdate cU = new CustomerUpdate();
            cU.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Atm_Main_Interface aI = new Atm_Main_Interface();
            aI.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
