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
    public partial class Note : Form
    {
        public Note()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminForm aF = new AdminForm();
            aF.Show();
            this.Hide();
        }
    }
}
