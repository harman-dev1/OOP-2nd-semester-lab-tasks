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
using BMS.BL;

namespace SignIn_SignUp_Win_Form
{
    public partial class AdminPersonal : Form
    {
        public AdminPersonal()
        {
            InitializeComponent();
        }

        private void AdminPersonal_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(ListsDLUser.getListOfAdminandManager()[0].Name, ListsDLUser.getListOfAdminandManager()[0].PhoneNo, ListsDLUser.getListOfAdminandManager()[0].CNIC, ListsDLUser.getListOfAdminandManager()[0].Address, ListsDLUser.getListOfAdminandManager()[0].Email, ListsDLUser.getListOfAdminandManager()[0].Password);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminForm aF = new AdminForm();
            aF.Show();
            this.Hide();
        }
    }
}
