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
    public partial class PayBills : Form
    {
        public PayBills()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gas_Bill gB = new Gas_Bill();
            gB.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ElectricityBill eB = new ElectricityBill();
            eB.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WaterBills wB = new WaterBills();
            wB.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CurrentAccountType cT = new CurrentAccountType();
            cT.Show();
            this.Hide();
        }
    }
}
