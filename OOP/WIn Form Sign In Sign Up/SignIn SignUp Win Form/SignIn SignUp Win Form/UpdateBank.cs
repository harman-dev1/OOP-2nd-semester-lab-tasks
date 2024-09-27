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
    public partial class UpdateBank : Form
    {
        public UpdateBank()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = NameBox.Text;
            string email = EmailBox.Text;
            string bankId = IdBox.Text;
            string no = PhoneNoBox.Text;
            long bankPhone = Convert.ToInt64(no);
            string address = addresBox.Text;
            string lo = textBox1.Text;
            long money = Convert.ToInt64(lo);
            AdminBL a = new AdminBL();
            a.setBankDetails(name, email, bankId, address, bankPhone, money);
            ListsDLUser.setlistOfBank(a);
            string path = "Bank_Data.txt";
            ListsDLUser.Store_Bank_Data_Into_File(path, a);
            MessageBox.Show("Update Successfully!!!");
            this.Hide();
            AdminForm aF = new AdminForm();
            aF.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AdminForm aF = new AdminForm();
            aF.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void AddressBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
