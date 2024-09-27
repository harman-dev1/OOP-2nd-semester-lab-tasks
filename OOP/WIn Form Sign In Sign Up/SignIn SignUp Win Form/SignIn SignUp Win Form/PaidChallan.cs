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
    public partial class PaidChallan : Form
    {
        public PaidChallan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CurrentAccountType cT = new CurrentAccountType();
            cT.Show();
            this.Hide();
        }
    }
}
